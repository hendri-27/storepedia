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
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormVerifikasiPass : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public UCProfil uCProfil;
        public bool parentIsEmail;

        public FormVerifikasiPass()
        {
            InitializeComponent();
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxPass_Validation(sender, e);
                if (textBoxPass.TextLength > 7 && textBoxPass.TextLength < 17)
                {
                    CekPass();
                    if (lblPass.ForeColor != Color.Red)
                    {
                        if (parentIsEmail)
                        {
                            UCEmail uCEmail = new UCEmail()
                            {
                                Dock = DockStyle.Fill
                            };
                            FormUserUtama.formUserUtama.ucEmail = uCEmail;
                            if (FormUserUtama.formUserUtama.timerRetry.Enabled == true)
                            {
                                uCEmail.buttonSendVerification.Enabled = false;
                                uCEmail.buttonSendVerification.Text = $"Coba Lagi ({FormUserUtama.formUserUtama.i}s)";
                            }
                            this.Controls.Add(uCEmail);
                            uCEmail.BringToFront();
                        }
                        else
                        {
                            UCGantiPassword uCGantiPassword = new UCGantiPassword();
                            this.Controls.Add(uCGantiPassword);
                            uCGantiPassword.BringToFront();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}");
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LookUp(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            switch (p.Tag.ToString())
            {
                case "eyeClose":
                    p.Image = Properties.Resources.eye_open;
                    p.Tag = "eyeOpen";
                    textBoxPass.PasswordChar = '\0';
                    break;
                default:
                    p.Image = Properties.Resources.eye_close;
                    p.Tag = "eyeClose";
                    textBoxPass.PasswordChar = '*';
                    break;
            }
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                e.Handled = true;
        }

        private void TextBoxPass_Validation(object sender, EventArgs e)
        {
            if (new Regex(@"^((\w|\W){8,16})$").IsMatch(textBoxPass.Text))
            {
                lblPass.ForeColor = Color.White;
                textBoxPass.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                lblPass.Text = "Password harus terdiri dari 8 - 16 digit.";
                lblPass.ForeColor = Color.Red;
                textBoxPass.BorderColor = Color.Red;
            }
        }

        private void CekPass()
        {
            if (textBoxPass.Text == FormUserUtama.p.Password)
            {
                lblPass.ForeColor = Color.White;
                textBoxPass.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                lblPass.Text = "Password salah.";
                lblPass.ForeColor = Color.Red;
                textBoxPass.BorderColor = Color.Red;
            }
        }
    }
}
