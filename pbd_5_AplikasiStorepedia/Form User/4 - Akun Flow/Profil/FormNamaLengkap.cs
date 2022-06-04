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

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormNamaLengkap : Form
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

        public FormNamaLengkap()
        {
            InitializeComponent();
            textBoxNamaLengkap.Text = FormUserUtama.p.Nama;
            textBoxNamaLengkap.Focus();
        }
        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxNamaLengkap_Validation(sender, e);
                if (lblNama.ForeColor != Color.Red)
                {
                    uCProfil.labelNamaLengkap.Text = textBoxNamaLengkap.Text;
                    FormUserUtama.p.Nama = textBoxNamaLengkap.Text;
                    Pelanggan.UbahData(FormUserUtama.p);
                    FormMessageBox.ShowBox("Nama Lengkap berhasil diubah");
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

        private void TextBoxNamaLengkap_Validation(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNamaLengkap.Text))
            {
                lblNama.ForeColor = Color.White;
                textBoxNamaLengkap.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                lblNama.ForeColor = Color.Red;
                textBoxNamaLengkap.BorderColor = Color.Red;
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
