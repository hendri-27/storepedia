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
    public partial class FormAlamat : Form
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
        public FormAlamat()
        {
            InitializeComponent();
            textBoxAlamat.Text = FormUserUtama.p.Alamat;
            textBoxAlamat.Focus();
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxAlamat_Validation(sender, e);
                if (lblAlamat.ForeColor != Color.Red)
                {
                    FormUserUtama.p.Alamat = textBoxAlamat.Text;
                    Pelanggan.UbahData(FormUserUtama.p);
                    FormMessageBox.ShowBox("Alamat berhasil diubah");
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

        private void TextBoxAlamat_Validation(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAlamat.Text))
            {
                lblAlamat.ForeColor = Color.White;
                textBoxAlamat.BorderColor = Color.FromArgb(213, 218, 223);
            }
            else
            {
                lblAlamat.ForeColor = Color.Red;
                textBoxAlamat.BorderColor = Color.Red;
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
