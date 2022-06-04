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
    public partial class UCEmail : UserControl
    {
        string kode;


        public UCEmail()
        {
            InitializeComponent();
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxEmail_Validation(sender, e);
                if (lblEmail.ForeColor != Color.Red)
                {
                    if (Verifikasi())
                    {
                        ((FormVerifikasiPass)ParentForm).uCProfil.labelEmail.Text = textBoxEmail.Text.Substring(0, 2).ToLower() + "*****" + textBoxEmail.Text.Substring(textBoxEmail.Text.IndexOf('@')).ToLower();
                        FormUserUtama.p.Email = textBoxEmail.Text.ToLower();
                        Pelanggan.UbahData(FormUserUtama.p);
                        FormMessageBox.ShowBox("Email berhasil diubah");
                        ParentForm.Close();
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
            this.Dispose();
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
                lblEmail.ForeColor = Color.White;
                textBoxEmail.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
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

        private void ButtonSendVerification_Click(object sender, EventArgs e)
        {
            if (FormUserUtama.formUserUtama.timerRetry.Enabled == false)
            {
                FormUserUtama.formUserUtama.timerRetry.Start();
                buttonSendVerification.Text = "Coba Lagi (60s)";
                buttonSendVerification.Enabled = false;
                kode = KodeOTP.GenerateKode(textBoxEmail.Text);
                FormMessageBox.ShowBox($"Kode Verifikasi telah dikirim\nke {textBoxEmail.Text}");
            }
        }

        private bool Verifikasi()
        {
            if (textBoxVerification.Text == kode)
            {
                lblVerifikasi.ForeColor = Color.White;
                return true;
            }
            else
            {
                lblVerifikasi.ForeColor = Color.Red;
                return false;
            }
        }
    }
}
