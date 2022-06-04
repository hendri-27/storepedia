using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCAlamat : UserControl
    {
        public UCAlamat()
        {
            InitializeComponent();
        }

        public string Profil
        {
            set
            {
                labelProfil.Text = value;
            }
        }

        public string Alamat
        {
            set
            {
                textBoxAlamat.Text = value;
            }
        }

        private void TextBoxAlamat_Leave(object sender, EventArgs e)
        {
            textBoxAlamat.Leave -= TextBoxAlamat_Leave;
            Check();
        }

        private void LabelUbah_MouseDown(object sender, MouseEventArgs e)
        {
            if (labelUbah.Text == "Ubah")
            {
                labelUbah.Text = "Selesai";
                textBoxAlamat.Leave += TextBoxAlamat_Leave;
                textBoxAlamat.Enabled = true;
                textBoxAlamat.Focus();
            }
            else
                Check();
        }

        private void Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxAlamat.Text))
            {
                textBoxAlamat.Text = FormUserUtama.p.Alamat;
            }
            else
            {
                if (FormUserUtama.p.Alamat != textBoxAlamat.Text)
                {
                    FormUserUtama.p.Alamat = textBoxAlamat.Text;
                    Pelanggan.UbahData(FormUserUtama.p);
                }
            }
            textBoxAlamat.Enabled = false;
            labelUbah.Text = "Ubah";
        }


    }
}
