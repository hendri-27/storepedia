using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_Storepedia;
using System.Text.RegularExpressions;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormHandphone : Form
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

        public FormHandphone()
        {
            InitializeComponent();
        }
        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxHandphone_Validation(sender, e);
                if (lblNoTelp.ForeColor != Color.Red)
                {
                    uCProfil.labelHandphone.Text = $"*****{textBoxHandphone.Text.Substring(textBoxHandphone.Text.Length - 2)}";
                    FormUserUtama.p.NoTelp = textBoxHandphone.Text.Replace("+62", "0");
                    Pelanggan.UbahData(FormUserUtama.p);
                    FormMessageBox.ShowBox("Nomor Handphone berhasil diubah");
                    this.Close();
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

        private void TextBoxHandphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 43)
                e.Handled = true;
        }

        private void TextBoxHandphone_Validation(object sender, EventArgs e)
        {
            if (new Regex(@"^((\+62)|(0))\d{9,12}$").IsMatch(textBoxHandphone.Text))
            {
                lblNoTelp.ForeColor = Color.White;
                textBoxHandphone.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                lblNoTelp.ForeColor = Color.Red;
                textBoxHandphone.BorderColor = Color.Red;
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
