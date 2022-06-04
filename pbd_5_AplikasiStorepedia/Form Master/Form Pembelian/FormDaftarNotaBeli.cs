using class_Storepedia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormDaftarNotaBeli : Form
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

        List<NotaBeli> listNotaBeli = new List<NotaBeli>();

        string kriteria = "";

        public FormDaftarNotaBeli()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarNotaJual.Columns.Clear();

            dataGridViewDaftarNotaJual.Columns.Add("NoNota", "No Nota");
            dataGridViewDaftarNotaJual.Columns.Add("TanggalPesan", "Tanggal Pesan");
            dataGridViewDaftarNotaJual.Columns.Add("IdPegawai", "Id Pegawai");
            dataGridViewDaftarNotaJual.Columns.Add("NamaPegawai", "Nama Pegawai");
            dataGridViewDaftarNotaJual.Columns.Add("IdSupplier", "Id Supplier");
            dataGridViewDaftarNotaJual.Columns.Add("NamaSupplier", "Nama Supplier");
            dataGridViewDaftarNotaJual.Columns.Add("AlamatSupplier", "Alamat Supplier");
            dataGridViewDaftarNotaJual.Columns.Add("TanggalTerima", "Tanggal Terima");
            dataGridViewDaftarNotaJual.Columns.Add("NamaKurir", "Nama Kurir");
            dataGridViewDaftarNotaJual.Columns.Add("IdBarang", "Id Barang");
            dataGridViewDaftarNotaJual.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewDaftarNotaJual.Columns.Add("Harga", "Harga");
            dataGridViewDaftarNotaJual.Columns.Add("Jumlah", "Jumlah");

            dataGridViewDaftarNotaJual.Columns["NoNota"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["TanggalPesan"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["IdPegawai"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["NamaPegawai"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["IdSupplier"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["NamaSupplier"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["AlamatSupplier"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["TanggalTerima"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["NamaKurir"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["IdBarang"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["NamaBarang"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["Harga"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarNotaJual.Columns["Harga"].DefaultCellStyle.Alignment =
            dataGridViewDaftarNotaJual.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewDaftarNotaJual.Columns["Harga"].DefaultCellStyle.Format =
            dataGridViewDaftarNotaJual.Columns["Jumlah"].DefaultCellStyle.Format = "#,###";
        }

        private void TampilDataGrid()
        {
            try
            {
                dataGridViewDaftarNotaJual.Rows.Clear();

                if (listNotaBeli.Count > 0)
                {
                    foreach (NotaBeli nota in listNotaBeli)
                    {
                        foreach (DetilNotaBeli dnb in nota.ListDetilNotaBeli)
                        {
                            dataGridViewDaftarNotaJual.Rows.Add(nota.NoNota, nota.TanggalPesan.ToString("yyyy-MM-dd HH:mm:ss"), nota.Pegawai.IdPegawai, nota.Pegawai.Nama, nota.Supplier.IdSupplier, nota.Supplier.Nama, nota.Supplier.Alamat, (nota.TanggalTerima.Year == 0001) ? null : nota.TanggalTerima.ToString("yyyy-MM-dd HH:mm:ss"), nota.NamaKurir, dnb.Barang.IdBarang, dnb.Barang.NamaBarang, dnb.Harga, dnb.Jumlah);
                        }
                    }
                }
                else
                {
                    dataGridViewDaftarNotaJual.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void FormDaftarNotaBeli_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMasterUtama.p.Jabatan.IdJabatan == "03")
                    buttonTambah.Visible = buttonUpdate.Visible = false;

                FormatDataGrid();

                listNotaBeli = NotaBeli.BacaData("", "");

                TampilDataGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNotaBeli formTambahNotaBeli = new FormTambahNotaBeli()
            {
                Owner = this
            };
            formTambahNotaBeli.ShowDialog();
        }

        private void ButtonCetak_Click(object sender, EventArgs e)
        {
            try
            {
                NotaBeli.CetakNota(kriteria, textBoxCari.Text, "[STOREPEDIA]daftar_nota_beli.txt", new Font("Courier New", 12));

                MessageBox.Show("Nota berhasil dicetak.", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nota gagal dicetak. Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
        
        private void TextBoxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCari.SelectedIndex != -1)
                {
                    if (comboBoxCari.Text == "No Nota")
                    {
                        kriteria = "N.NoNota";
                    }
                    else if (comboBoxCari.Text == "Tanggal Pesan")
                    {
                        kriteria = "N.TanggalPesan";
                    }
                    else if (comboBoxCari.Text == "Id Pegawai")
                    {
                        kriteria = "N.IdPegawai";
                    }
                    else if (comboBoxCari.Text == "Nama Pegawai")
                    {
                        kriteria = "Peg.Nama";
                    }
                    else if (comboBoxCari.Text == "Id Supplier")
                    {
                        kriteria = "N.IdSupplier";
                    }
                    else if (comboBoxCari.Text == "Nama Supplier")
                    {
                        kriteria = "S.Nama";
                    }
                    else if (comboBoxCari.Text == "Alamat Supplier")
                    {
                        kriteria = "S.Alamat";
                    }
                    else if (comboBoxCari.Text == "Nama Kurir")
                    {
                        kriteria = "N.NamaKurir";
                    }
                    else if (comboBoxCari.Text == "Tanggal Terima")
                    {
                        kriteria = "N.TanggalTerima";
                    }

                    listNotaBeli = NotaBeli.BacaData(kriteria, textBoxCari.Text);

                    TampilDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateTerimaBarang formUpdateTerimaBarang = new FormUpdateTerimaBarang()
            {
                Owner = this
            };
            formUpdateTerimaBarang.ShowDialog();
        }
    }
}
