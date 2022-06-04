using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormLogin : Form
    {
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        Thread newForm;
        bool setFire = true;
        public object active;
        public int i = 60;
        public static FormLogin formLogin;

        public FormLogin()
        {
            InitializeComponent();
            formLogin = this;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxUsername_Leave(e, e);
                TextBoxPass_Leave(e, e);

                if (labelUsername.BackColor == Color.Green && labelPass.BackColor == Color.Green)
                {
                    // Jika ingin mengganti username dan password di database
                    Koneksi k = new Koneksi("localhost", "sistem_storepedia", "root", "");

                    bool success = k.CekUser(textBoxUsername.Text, textBoxPass.Text, out string id);
                    if (success)
                    {
                        if (id.Substring(0, 1) == "P")
                        {
                            List<Pegawai> p = Pegawai.BacaData("peg.idPegawai", id);
                            NewForm(p);
                        }
                        else
                        {
                            List<Pelanggan> pel = Pelanggan.BacaData("idPelanggan", id);
                            NewForm(pel);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Maaf username dan password salah.", "Kesalahan");
                        ClearInfo(sender);
                        textBoxPass.Focus();
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                if (ex.Message == "Unable to connect to any of the specified MySQL hosts.")
                    MessageBox.Show($"Pesan Kesalahan : Server Down. Error Code:500", "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void NewForm(object sender)
        {
            this.Close();
            newForm = new Thread(OpenNewForm);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start(sender);
        }

        private void OpenNewForm(object sender)
        {
            try
            {
                if (sender is List<Pegawai>)
                {
                    FormMasterUtama formMasterUtama = new FormMasterUtama();

                    formMasterUtama.PassingData(sender);
                    Application.Run(formMasterUtama);
                }
                else
                {
                    FormUserUtama formUserUtama = new FormUserUtama();
                    formUserUtama.PassingData(sender);
                    Application.Run(formUserUtama);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonLogin_MouseHover(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void ButtonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void LabelDaftar_Click(object sender, EventArgs e)
        {
            ClearInfo(sender);
            active = new UserControlRegister1();
            if (timerRetry.Enabled == true)
            {
                ((UserControlRegister1)active).buttonSendVerification.Enabled = false;
                ((UserControlRegister1)active).buttonSendVerification.Text = $"Coba Lagi ({i}s)";
            }
            this.panelLayout.Controls.Add(((UserControlRegister1)active));
            ((UserControlRegister1)active).BringToFront();
        }

        // Animation Untuk Label Daftar
        private void LabelDaftar_MouseEnter(object sender, EventArgs e)
        {
            labelDaftar.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Underline);
        }

        private void LabelDaftar_MouseLeave(object sender, EventArgs e)
        {
            labelDaftar.Font = new Font("Arial", 11.25f, FontStyle.Bold);
            labelDaftar.ForeColor = Color.FromArgb(20, 30, 54);
        }

        private void LabelDaftar_MouseDown(object sender, MouseEventArgs e)
        {
            labelDaftar.ForeColor = Color.Crimson;
        }

        private void ClearInfo (object sender)
        {
            //To check if the textchanged event handler not being called and reset all error to default
            this.ActiveControl = null; // to leave all focus
            if (pictureBoxShowPass.Tag.ToString() == "eyeOpen")
            {
                pictureBoxShowPass.Image = Properties.Resources.eye_close;
                pictureBoxShowPass.Tag = "eyeClose";
            }
            setFire = false;
            if (sender != buttonLogin)
                textBoxUsername.Clear();
            textBoxPass.Clear();
            labelUsername.BackColor = labelPass.BackColor = Color.Black;
            lblUsername.ForeColor = lblPass.ForeColor = Color.White;
            errorProviderLogin.Clear();
            setFire = true;
        }

        private void PictureBoxShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            switch(pictureBoxShowPass.Tag.ToString())
            {
                case "eyeClose":
                    pictureBoxShowPass.Image = Properties.Resources.eye_open;
                    pictureBoxShowPass.Tag = "eyeOpen";
                    textBoxPass.PasswordChar = '\0';
                    break;
                default:
                    pictureBoxShowPass.Image = Properties.Resources.eye_close;
                    pictureBoxShowPass.Tag = "eyeClose";
                    textBoxPass.PasswordChar = '*';
                    break;
            }
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (setFire)
                Regexp(textBoxUsername, labelUsername, lblUsername, "Format username tidak benar.");
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (labelUsername.BackColor != Color.Green)
                Regexp(textBoxUsername, labelUsername, lblUsername, "Format username tidak benar.");
        }

        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (setFire)
                Regexp(textBoxPass, labelPass, lblPass, "Format password tidak benar.");
        }

        private void TextBoxPass_Leave(object sender, EventArgs e)
        {
            if (labelPass.BackColor != Color.Green)
                Regexp(textBoxPass, labelPass, lblPass, "Format password tidak benar.");
        }

        private void Regexp(TextBox tb, Label lb, Label msg, string error)
        {
            if (!string.IsNullOrWhiteSpace(tb.Text))
            {
                lb.BackColor = Color.Green;
                msg.ForeColor = Color.White;
                errorProviderLogin.Clear();
            }
            else
            {
                lb.BackColor = msg.ForeColor = Color.Red;
                errorProviderLogin.SetError(tb, error);
            }
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelCredits_Click(object sender, EventArgs e)
        {
            FormCredit formCredit = new FormCredit();
            formCredit.ShowDialog();
        }

        private void MouseEntering(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(61, 56, 132);
        }

        private void MouseLeaving(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(22, 20, 52);
        }

        private void LabelCredits_MouseEnter(object sender, EventArgs e)
        {
            labelCredits.ForeColor = Color.FromArgb(20, 30, 54);
        }

        private void LabelCredits_MouseLeave(object sender, EventArgs e)
        {
            labelCredits.ForeColor = SystemColors.ControlDarkDark;
        }

        private void TextBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                ButtonLogin_Click(buttonLogin, e);
            }
            else if (e.KeyChar == 9 || e.KeyChar == 32)
                e.Handled = true;
        }

        private void TextBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9 || e.KeyChar == 32)
                e.Handled = true;
        }

        private void TimerRetry_Tick(object sender, EventArgs e)
        {
            i--;
            
            if (active is UserControlRegister1 uc)
                uc.buttonSendVerification.Text = $"Coba Lagi ({i}s)";
            else
                ((FormVerifikasiEmail)active).buttonSendVerification.Text = $"Coba Lagi ({i}s)";
            

            if (i == 0)
            {
                timerRetry.Stop();
                i = 60;
                if (active is UserControlRegister1 ac)
                {
                    ac.buttonSendVerification.Text = "Kirim Verifikasi";
                    ac.buttonSendVerification.Enabled = true;
                }
                else
                {
                    ((FormVerifikasiEmail)active).buttonSendVerification.Text = "Kirim Verifikasi";
                    ((FormVerifikasiEmail)active).buttonSendVerification.Enabled = true;
                }
            }
        }

        private void LabelLupaPass_Click(object sender, EventArgs e)
        {
            ClearInfo(sender);
            FormLupaPassword formLupaPassword = new FormLupaPassword();
            formLupaPassword.ShowDialog();
        }
    }
}
