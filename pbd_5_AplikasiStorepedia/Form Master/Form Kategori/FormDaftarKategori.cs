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
    public partial class FormDaftarKategori : Form
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

        List<Kategori> listKategori = new List<Kategori>();
        public FormDaftarKategori()
        {
            InitializeComponent();
        }

        public void FormDaftarKategori_Load(object sender, EventArgs e)
        {
            try
            {
                listKategori = Kategori.BacaData("", "");

                if (listKategori.Count > 0)
                {
                    dataGridViewKategori.DataSource = listKategori;
                }
                else
                {
                    dataGridViewKategori.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategori formTambahKategori = new FormTambahKategori()
            {
                Owner = this
            };
            formTambahKategori.ShowDialog();
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            FormUbahKategori formUbahKategori = new FormUbahKategori()
            {
                Owner = this
            };
            formUbahKategori.ShowDialog();
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            FormHapusKategori formHapusKategori = new FormHapusKategori()
            {
                Owner = this
            };
            formHapusKategori.ShowDialog();
        }

        private void TextBoxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCari.SelectedIndex != -1)
                {
                    string kriteria = "kodeKategori";
                    if (comboBoxCari.Text == "Nama")
                    {
                        kriteria = "nama";
                    }
                    listKategori = Kategori.BacaData(kriteria, textBoxCari.Text);

                    if (listKategori.Count > 0)
                    {
                        dataGridViewKategori.DataSource = listKategori;
                    }
                    else
                    {
                        dataGridViewKategori.DataSource = null;
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
