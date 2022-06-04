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
    public partial class FormNamaPanggil : Form
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

        public FormNamaPanggil()
        {
            InitializeComponent();
            textBoxNamaPanggil.Text = FormUserUtama.p.NamaPanggilan;
            textBoxNamaPanggil.Focus();
        }
        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxNamaPanggilan_Validation(sender, e);
                if (lblNamaPanggilan.ForeColor != Color.Red)
                {
                    FormUserUtama.formUserUtama.labelNamaPanggil.Text = uCProfil.labelNamaPanggil.Text = textBoxNamaPanggil.Text;
                    FormUserUtama.p.NamaPanggilan = textBoxNamaPanggil.Text;
                    Pelanggan.UbahData(FormUserUtama.p);
                    FormMessageBox.ShowBox("Nama Panggilan berhasil diubah");
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

        private void TextBoxNamaPanggilan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                e.Handled = true;
        }

        private void TextBoxNamaPanggilan_Validation(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNamaPanggil.Text))
            {
                lblNamaPanggilan.ForeColor = Color.Red;
                textBoxNamaPanggil.BorderColor = Color.Red;
                lblNamaPanggilan.Text = "Nama panggilan harus diisi";
            }
            else
            {
                if (new Regex(@"^(\w{1,10})$").IsMatch(textBoxNamaPanggil.Text))
                {
                    lblNamaPanggilan.ForeColor = Color.White;
                    textBoxNamaPanggil.BorderColor = Color.FromArgb(213, 218, 223);
                }
                else
                {
                    lblNamaPanggilan.ForeColor = Color.Red;
                    textBoxNamaPanggil.BorderColor = Color.Red;
                    lblNamaPanggilan.Text = "Maks. 10 karakter";
                }
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
