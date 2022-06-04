using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCGantiPassword : UserControl
    {

        public UCGantiPassword()
        {
            InitializeComponent();
        }
        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxPass_Validation(sender, e);
                TextBoxUlangPass_Validation(sender, e);
                if (lblPass.ForeColor != Color.Red && lblUlangPass.ForeColor != Color.Red)
                {
                    if (ParentForm is FormLupaPassword formLupaPassword)
                    {
                        if (formLupaPassword.pel != null)
                        {
                            formLupaPassword.pel.Password = textBoxPass.Text;
                            Pelanggan.UbahData(formLupaPassword.pel);
                        }
                        else
                        {
                            formLupaPassword.peg.Password = textBoxPass.Text;
                            Pegawai.UbahData(formLupaPassword.peg);
                        }
                    }
                    else
                    {
                        FormUserUtama.p.Password = textBoxPass.Text;
                        Pelanggan.UbahData(FormUserUtama.p);
                    }
                    FormMessageBox.ShowBox("Password berhasil diubah");
                    ParentForm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}");
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ParentForm.Height = 125;
            this.Dispose();
        }

        private void LookUp(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            switch (p.Tag.ToString())
            {
                case "eyeClose":
                    p.Image = Properties.Resources.eye_open;
                    p.Tag = "eyeOpen";
                    switch (p == pictureBoxShowPass1)
                    {
                        case true:
                            textBoxPass.PasswordChar = '\0';
                            break;
                        default:
                            textBoxUlangPass.PasswordChar = '\0';
                            break;
                    }
                    break;
                default:
                    p.Image = Properties.Resources.eye_close;
                    p.Tag = "eyeClose";
                    switch (p == pictureBoxShowPass1)
                    {
                        case true:
                            textBoxPass.PasswordChar = '*';
                            break;
                        default:
                            textBoxUlangPass.PasswordChar = '*';
                            break;
                    }
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
                lblPass.ForeColor = Color.Red;
                textBoxPass.BorderColor = Color.Red;
            }
        }

        private void TextBoxUlangPass_Validation(object sender, EventArgs e)
        {
            if (textBoxPass.Text == textBoxUlangPass.Text && textBoxUlangPass.Text != "")
            {
                lblUlangPass.ForeColor = Color.White;
                textBoxUlangPass.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else if (textBoxUlangPass.Text == "")
            {
                lblUlangPass.ForeColor = textBoxUlangPass.BorderColor = Color.Red;
                lblUlangPass.Text = "Password harus diisi.";

            }
            else
            {
                lblUlangPass.ForeColor = textBoxUlangPass.BorderColor = Color.Red;
                lblUlangPass.Text = "Password tidak sama. Coba masukkan ulang.";
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
    }
}
