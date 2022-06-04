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
    public partial class FormDaftarPengiriman : Form
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

        List<Pengiriman> listPengiriman = new List<Pengiriman>();

        public FormDaftarPengiriman()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewPengiriman.Columns.Clear();

            dataGridViewPengiriman.Columns.Add("NoNota", "No Nota");
            dataGridViewPengiriman.Columns.Add("IdPeg", "Id Pegawai");
            dataGridViewPengiriman.Columns.Add("NamaPeg", "Nama Pegawai");
            dataGridViewPengiriman.Columns.Add("Tanggal", "Tanggal");
            dataGridViewPengiriman.Columns.Add("Status", "Status");

            
            dataGridViewPengiriman.Columns["NoNota"].AutoSizeMode =
            dataGridViewPengiriman.Columns["IdPeg"].AutoSizeMode =
            dataGridViewPengiriman.Columns["NamaPeg"].AutoSizeMode =
            dataGridViewPengiriman.Columns["Tanggal"].AutoSizeMode =
            dataGridViewPengiriman.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void TampilDataGrid()
        {
            try
            {
                dataGridViewPengiriman.Rows.Clear();
                foreach (Pengiriman kirim in listPengiriman)
                {
                    dataGridViewPengiriman.Rows.Add(kirim.Nota.NoNota, kirim.Pegawai.IdPegawai, kirim.Pegawai.Nama, (kirim.Tanggal.Year == 0001) ? null : kirim.Tanggal.ToString("yyyy-MM-dd HH-mm-ss"), kirim.Status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void FormDaftarPengiriman_Load(object sender, EventArgs e)
        {
            try
            {
                listPengiriman = Pengiriman.BacaData("", "", "");

                if (sender is FormDaftarPengiriman)
                    FormatDataGrid();

                if (listPengiriman.Count > 0)
                    TampilDataGrid();
                else
                    dataGridViewPengiriman.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPengiriman formTambahPengiriman = new FormTambahPengiriman()
            {
                Owner = this
            };
            formTambahPengiriman.ShowDialog();
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPengiriman formUbahPengiriman = new FormUbahPengiriman()
            {
                Owner = this
            };
            formUbahPengiriman.ShowDialog();
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPengiriman formHapusPengiriman = new FormHapusPengiriman()
            {
                Owner = this
            };
            formHapusPengiriman.ShowDialog();
        }

        private void TextBoxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCari.SelectedIndex != -1)
                {
                    string kriteria = "";
                    switch (comboBoxCari.Text)
                    {
                        case "No Nota":
                            kriteria = "pk.NoNota";
                            break;
                        case "Id Pegawai":
                            kriteria = "pk.IdPegawai";
                            break;
                        case "Nama Pegawai":
                            kriteria = "peg.Nama";
                            break;
                        case "Tanggal":
                            kriteria = "pk.Tanggal";
                            break;
                        case "Status":
                            kriteria = "pk.Status";
                            break;
                    }

                    listPengiriman = Pengiriman.BacaData(kriteria, textBoxCari.Text, "pk.noNota ASC");

                    TampilDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
