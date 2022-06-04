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
    public partial class FormDaftarJabatan : Form
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

        List<Jabatan> listJabatan = new List<Jabatan>();
        public FormDaftarJabatan()
        {
            InitializeComponent();
        }

        public void FormDaftarJabatan_Load(object sender, EventArgs e)
        {
            try
            {
                listJabatan = Jabatan.BacaData("", "");

                if (listJabatan.Count > 0)
                {
                    dataGridViewJabatan.DataSource = listJabatan;
                }
                else
                {
                    dataGridViewJabatan.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJabatan formTambahJabatan = new FormTambahJabatan()
            {
                Owner = this
            };
            formTambahJabatan.ShowDialog();
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            FormUbahJabatan formUbahJabatan = new FormUbahJabatan()
            {
                Owner = this
            };
            formUbahJabatan.ShowDialog();
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            FormHapusJabatan formHapusJabatan = new FormHapusJabatan()
            {
                Owner = this
            };
            formHapusJabatan.ShowDialog();
        }

        private void TextBoxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCari.SelectedIndex != -1)
                {
                    string kriteria = "idJabatan";
                    if (comboBoxCari.Text == "Nama")
                    {
                        kriteria = "nama";
                    }
                    listJabatan = Jabatan.BacaData(kriteria, textBoxCari.Text);

                    if (listJabatan.Count > 0)
                    {
                        dataGridViewJabatan.DataSource = listJabatan;
                    }
                    else
                    {
                        dataGridViewJabatan.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
