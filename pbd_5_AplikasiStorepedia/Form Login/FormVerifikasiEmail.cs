using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using class_Storepedia;
using System.Text.RegularExpressions;
using System.Linq.Expressions;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormVerifikasiEmail : Form
    {
        string kode;

        public FormVerifikasiEmail()
        {
            InitializeComponent();
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verifikasi())
                {
                    ParentForm.SuspendLayout();
                    ParentForm.Height = 195;
                    UCGantiPassword uCGantiPassword = new UCGantiPassword();                      
                    ParentForm.Controls.Add(uCGantiPassword);
                    uCGantiPassword.BringToFront();
                    ParentForm.ResumeLayout();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}");
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
            FormLupaPassword formLupaPassword = (FormLupaPassword)ParentForm;
            if (FormLogin.formLogin.timerRetry.Enabled == false)
            {
                FormLogin.formLogin.timerRetry.Start();
                buttonSendVerification.Text = "Coba Lagi (60s)";
                buttonSendVerification.Enabled = false;
                string email;
                if (formLupaPassword.pel != null)
                    email = formLupaPassword.pel.Email;
                else
                    email = formLupaPassword.peg.Email;
                kode = KodeOTP.GenerateKode(email);
                FormMessageBox.ShowBox($"Kode Verifikasi telah dikirim\nke {email.Substring(0, 2)}*****{email.Substring(email.IndexOf('@'))}");
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
