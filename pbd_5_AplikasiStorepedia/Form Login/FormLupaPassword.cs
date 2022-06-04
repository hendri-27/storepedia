using class_Storepedia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormLupaPassword : Form
    {
        public Pelanggan pel;
        public Pegawai peg;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public FormLupaPassword()
        {
            InitializeComponent();
        }

        private void ButtonLanjut_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxEmail_Validation(sender, e);
                if (lblEmail.ForeColor != Color.Red)
                {   
                    FormVerifikasiEmail formVerifikasiEmail = new FormVerifikasiEmail()
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill
                    };

                    FormLogin.formLogin.active = formVerifikasiEmail;

                    if (FormLogin.formLogin.timerRetry.Enabled == true)
                    {
                        formVerifikasiEmail.buttonSendVerification.Enabled = false;
                        formVerifikasiEmail.buttonSendVerification.Text = $"Coba Lagi ({FormLogin.formLogin.i}s)";
                    }

                    this.Controls.Add(formVerifikasiEmail);
                    formVerifikasiEmail.Show();
                    formVerifikasiEmail.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan: {ex.Message}");
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                e.Handled = true;
        }

        private void TextBoxEmail_Validation(object sender, EventArgs e)
        {
            if (new Regex(@"^([\w\.\-]+)@([\w]+)\.([\w]{2,3})$").IsMatch(textBoxEmail.Text))
            {
                List<Pelanggan> listPel = Pelanggan.BacaData("email", textBoxEmail.Text, true);
                List<Pegawai> listPeg = Pegawai.BacaData("peg.email", textBoxEmail.Text, true);
                if (listPel.Count != 0)
                    pel = listPel[0];
                else if (listPeg.Count != 0)
                    peg = listPeg[0];
                else
                {
                    lblEmail.ForeColor = Color.Red;
                    textBoxEmail.BorderColor = Color.Red;
                    lblEmail.Text = "Akun tidak ditemukan.";
                    return;
                }
                lblEmail.ForeColor = Color.White;
                textBoxEmail.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                lblEmail.Text = "Format email tidak sah.";
                lblEmail.ForeColor = Color.Red;
                textBoxEmail.BorderColor = Color.Red;
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(49, 50, 111);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(31, 32, 71);
        }

        private void FormLupaPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin.formLogin.TopMost = true;
            FormLogin.formLogin.TopMost = false;
        }
    }
}
