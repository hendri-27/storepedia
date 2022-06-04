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
    public partial class FormDaftarPelanggan : Form
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

        List<Pelanggan> listPelanggan = new List<Pelanggan>();
        public FormDaftarPelanggan()
        {
            InitializeComponent();
        }

        public void FormDaftarPelanggan_Load(object sender, EventArgs e)
        {
            try
            {
                listPelanggan = Pelanggan.BacaData("", "");

                if (listPelanggan.Count > 0)
                {
                    dataGridViewPelanggan.DataSource = listPelanggan;
                    dataGridViewPelanggan.AutoGenerateColumns = true;
                    dataGridViewPelanggan.AutoGenerateColumns = false;
                    dataGridViewPelanggan.Columns["TglLahir"].DefaultCellStyle.Format = "yyyy-MM-dd";
                    dataGridViewPelanggan.Columns.RemoveAt(8);
                    dataGridViewPelanggan.Columns["Saldo"].DefaultCellStyle.Format = "N0";
                    dataGridViewPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {
                    dataGridViewPelanggan.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPelanggan formTambahPelanggan = new FormTambahPelanggan()
            {
                Owner = this
            };
            formTambahPelanggan.ShowDialog();
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPelanggan formUbahPelanggan = new FormUbahPelanggan()
            {
                Owner = this
            };
            formUbahPelanggan.ShowDialog();
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPelanggan formHapusPelanggan = new FormHapusPelanggan()
            {
                Owner = this
            };
            formHapusPelanggan.ShowDialog();
        }

        private void TextBoxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCari.SelectedIndex != -1)
                {
                    string kriteria = "idPelanggan";
                    switch (comboBoxCari.Text)
                    {
                        case "Nama":
                            kriteria = "nama";
                            break;
                        case "Nama Panggilan":
                            kriteria = "namaPanggilan";
                            break;
                        case "Tgl Lahir":
                            kriteria = "tglLahir";
                            break;
                        case "Email":
                            kriteria = "email";
                            break;
                        case "Alamat":
                            kriteria = "alamat";
                            break;
                        case "No Telp":
                            kriteria = "noTelp";
                            break;
                        case "Username":
                            kriteria = "username";
                            break;
                    }
                    listPelanggan = Pelanggan.BacaData(kriteria, textBoxCari.Text);

                    if (listPelanggan.Count > 0)
                    {
                        dataGridViewPelanggan.DataSource = listPelanggan;
                    }
                    else
                    {
                        dataGridViewPelanggan.DataSource = null;
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
