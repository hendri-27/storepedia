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
    public partial class UserControlRegister2 : UserControl
    {
        string email, notlp;

        public UserControlRegister2()
        {
            InitializeComponent();
        }

        private void ButtonLanjut_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxUsername_Leave(e, e);
                TextBoxPass_Leave(e, e);
                TextBoxUlangPass_Leave(e, e);

                if (textBoxUsername.TextLength > 3 && textBoxUsername.TextLength <= 50)
                    CekUsername(textBoxUsername);

                if (labelUsername.BackColor == Color.Green && labelPass.BackColor == Color.Green && labelUlangPass.BackColor == Color.Green)
                {
                    if (pictureBoxShowPass1.Tag.ToString() == "eyeOpen")
                    {
                        pictureBoxShowPass1.Image = Properties.Resources.eye_close;
                        pictureBoxShowPass1.Tag = "eyeClose";
                        textBoxPass.PasswordChar = '*';
                    }
                    if (pictureBoxShowPass2.Tag.ToString() == "eyeOpen")
                    {
                        pictureBoxShowPass2.Image = Properties.Resources.eye_close;
                        pictureBoxShowPass2.Tag = "eyeClose";
                        textBoxUlangPass.PasswordChar = '*';
                    }
                    UserControlRegister3 userControlRegister3 = new UserControlRegister3();
                    this.Parent.Controls.Add(userControlRegister3);
                    userControlRegister3.GetValue(email, notlp, textBoxUsername.Text, textBoxPass.Text);
                    userControlRegister3.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonLanjut_MouseEnter(object sender, EventArgs e)
        {
            buttonLanjut.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void ButtonLanjut_MouseLeave(object sender, EventArgs e)
        {
            buttonLanjut.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void LabelKembali_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text != "" || textBoxUlangPass.Text != "" || textBoxUsername.Text != "")
            {
                if (MessageBox.Show("Anda telah mengisi data registrasi.\nApakah Anda yakin meninggalkan halaman ini?", "Warning" , MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            this.Parent.Controls.Remove(this);
        }

        private void LabelKembali_MouseDown(object sender, MouseEventArgs e)
        {
            labelKembali.ForeColor = Color.Crimson;
        }

        private void LabelKembali_MouseEnter(object sender, EventArgs e)
        {
            labelKembali.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Underline);
        }

        private void LabelKembali_MouseLeave(object sender, EventArgs e)
        {
            labelKembali.Font = new Font("Arial", 11.25f, FontStyle.Bold);
            labelKembali.ForeColor = Color.FromArgb(20, 30, 54);
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            lblUsername.Text = "Username harus terdiri dari 4 - 50 karakter.";
            Regexp(@"^(\w{4,50})$", textBoxUsername, labelUsername, lblUsername, "Format username tidak benar.");
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (labelUsername.BackColor != Color.Green)
            {
                lblUsername.Text = "Username harus terdiri dari 4 - 50 karakter.";
                Regexp(@"^(\w{4,50})$", textBoxUsername, labelUsername, lblUsername, "Format username tidak benar.");
            }

            if (labelUsername.BackColor == Color.Green)
                CekUsername(textBoxUsername);
        }

        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {
            Regexp(@"^((\w|\W){8,16})$", textBoxPass, labelPass, lblPass, "Format password tidak benar.");
            TextBoxUlangPass_TextChanged(sender, e);
        }

        private void TextBoxPass_Leave(object sender, EventArgs e)
        {
            if (labelPass.BackColor != Color.Green)
                Regexp(@"^((\w|\W){8,16})$", textBoxPass, labelPass, lblPass, "Format password tidak benar.");
        }

        private void Regexp(string rg, TextBox tb, Label lb, Label msg, string error)
        {
            switch (new Regex(rg).IsMatch(tb.Text))
            {
                case true:
                    lb.BackColor = Color.Green;
                    msg.ForeColor = Color.White;
                    errorProviderRegis.Clear();
                    break;
                default:
                    lb.BackColor = msg.ForeColor = Color.Red;
                    errorProviderRegis.SetError(tb, error);
                    break;
            }
        }

        private void CekUsername(TextBox tb)
        {
            try
            {
                lblUsername.Text = "Username telah dipakai.";
                if (Pelanggan.BacaData(tb.Text.ToLower()).Count == 0)
                {
                    labelUsername.BackColor = Color.Green;
                    lblUsername.ForeColor = Color.White;
                    errorProviderRegis.Clear();
                }
                else
                {
                    labelUsername.BackColor = lblUsername.ForeColor = Color.Red;
                    errorProviderRegis.SetError(tb, "Username telah dipakai.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxUlangPass_TextChanged(object sender, EventArgs e)
        {
            CheckPass(textBoxPass.Text, textBoxUlangPass, labelUlangPass, lblUlangPass, "Password tidak sama.");
        }

        private void TextBoxUlangPass_Leave(object sender, EventArgs e)
        {
            if (labelUlangPass.BackColor != Color.Green)
                CheckPass(textBoxPass.Text, textBoxUlangPass, labelUlangPass, lblUlangPass, "Password tidak sama.");
        }

        private void CheckPass(string rg, TextBox tb, Label lb, Label msg, string error)
        {
            if (rg == tb.Text && tb.Text != "")
            {
                lb.BackColor = Color.Green;
                msg.ForeColor = Color.White;
                errorProviderRegis.Clear();
            }
            else if (tb.Text == "")
            {
                lb.BackColor = msg.ForeColor = Color.Red;
                errorProviderRegis.SetError(tb, error);
                msg.Text = "Password harus diisi.";
            }
            else
            {
                lb.BackColor = msg.ForeColor = Color.Red;
                errorProviderRegis.SetError(tb, error);
                msg.Text = "Password tidak sama. Coba masukkan ulang.";
            }
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
            switch ((TextBox)sender == textBoxUsername)
            {
                case true:
                    if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
                        e.Handled = true;
                    break;
                default:
                    if (e.KeyChar == 32 || e.KeyChar == 9)
                        e.Handled = true;
                    break;
            }
        }

        public void GetValue (string pEmail, string pNotlp)
        {
            email = pEmail;
            notlp = pNotlp;
        }
    }
}
