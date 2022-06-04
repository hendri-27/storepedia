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
    public partial class UserControlRegister1 : UserControl
    {
        string kode;

        public UserControlRegister1()
        {
            InitializeComponent();
        }

        private void ButtonLanjut_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxEmail_Leave(e, e);
                TextBoxNoTelp_Leave(e, e);
                if (labelEmail.BackColor == Color.Green && labelNoTelp.BackColor == Color.Green)
                {
                    Verifikasi();
                    if (labelVerifikasi.BackColor == Color.Green)
                    {
                        UserControlRegister2 userControlRegister2 = new UserControlRegister2();
                        this.Parent.Controls.Add(userControlRegister2);
                        userControlRegister2.GetValue(textBoxEmail.Text.ToLower(), textBoxNoTelp.Text.Replace("+62", "0"));
                        userControlRegister2.BringToFront();
                    }
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
            if (textBoxEmail.Text != "" || textBoxNoTelp.Text != "")
            {
                if (MessageBox.Show("Anda telah mengisi data registrasi.\nApakah Anda yakin meninggalkan halaman ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            this.Parent.Controls.Remove(this);
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

        private void LabelKembali_MouseDown(object sender, MouseEventArgs e)
        {
            labelKembali.ForeColor = Color.Crimson;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            Regexp(@"^([\w\.\-]+)@([\w]+)\.([\w]{2,3})$", textBoxEmail, labelEmail,  "Format email tidak benar.");
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (labelEmail.BackColor != Color.Green)
                Regexp(@"^([\w\.\-]+)@([\w]+)\.([\w]{2,3})$", textBoxEmail, labelEmail,  "Format email tidak benar.");
        }

        private void TextBoxNoTelp_TextChanged(object sender, EventArgs e)
        {
            Regexp(@"^((\+62)|(0))\d{9,12}$", textBoxNoTelp, labelNoTelp, "Format nomor telepon tidak benar.");
        }

        private void TextBoxNoTelp_Leave(object sender, EventArgs e)
        {
            if (labelNoTelp.BackColor != Color.Green)
                Regexp(@"^((\+62)|(0))\d{9,12}$", textBoxNoTelp, labelNoTelp, "Format nomor telepon tidak benar.");
        }

        private void Regexp(string rg, TextBox tb, Label lb, string error)
        {
            switch (new Regex(rg).IsMatch(tb.Text))
            {
                case true:
                    lb.BackColor = Color.Green;
                    errorProviderRegis.Clear();
                    break;
                default:
                    lb.BackColor = Color.Red;
                    errorProviderRegis.SetError(tb, error);
                    break;
            }
        }

        private void Verifikasi ()
        {
            if (textBoxVerification.Text == kode)
            {
                labelVerifikasi.BackColor = Color.Green;
                lblVerifikasi.ForeColor = Color.White;
            }
            else
            {
                labelVerifikasi.BackColor = lblVerifikasi.ForeColor = Color.Red;
            }
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if ((TextBox)sender == textBoxEmail)
            {
                if (e.KeyChar == 32 || e.KeyChar == 13)
                    e.Handled = true;
            }
            else if ((TextBox)sender == textBoxNoTelp)
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 43)
                    e.Handled = true;
            }
            else
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void ButtonSendVerification_Click(object sender, EventArgs e)
        {
            if (FormLogin.formLogin.timerRetry.Enabled == false)
            {
                TextBoxEmail_Leave(e, e);
                if (labelEmail.BackColor == Color.Green)
                {
                    FormLogin.formLogin.timerRetry.Start();
                    buttonSendVerification.Text = "Coba Lagi (60s)";
                    buttonSendVerification.Enabled = false;
                    kode = KodeOTP.GenerateKode(textBoxEmail.Text);
                }
            }
        }
    }
}
