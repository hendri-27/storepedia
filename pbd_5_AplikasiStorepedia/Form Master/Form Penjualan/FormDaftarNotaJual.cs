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
    public partial class FormDaftarNotaJual : Form
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

        List<NotaJual> listNotaJual = new List<NotaJual>();

        string kriteria = "";

        public FormDaftarNotaJual()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarNotaJual.Columns.Clear();

            dataGridViewDaftarNotaJual.Columns.Add("NoNota", "No Nota");
            dataGridViewDaftarNotaJual.Columns.Add("Tanggal", "Tanggal");
            dataGridViewDaftarNotaJual.Columns.Add("OngkosKirim", "Ongkos Kirim");
            dataGridViewDaftarNotaJual.Columns.Add("TipeBayar", "Tipe Pembayaran");
            dataGridViewDaftarNotaJual.Columns.Add("IdPelanggan", "Id Pelanggan");
            dataGridViewDaftarNotaJual.Columns.Add("NamaPelanggan", "Nama Pelanggan");
            dataGridViewDaftarNotaJual.Columns.Add("AlamatPelanggan", "Alamat Pelanggan");

            dataGridViewDaftarNotaJual.Columns.Add("IdBarang", "Id Barang");
            dataGridViewDaftarNotaJual.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewDaftarNotaJual.Columns.Add("Harga", "Harga");
            dataGridViewDaftarNotaJual.Columns.Add("Jumlah", "Jumlah");

            dataGridViewDaftarNotaJual.Columns["NoNota"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["Tanggal"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["OngkosKirim"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["TipeBayar"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["IdPelanggan"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["NamaPelanggan"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["AlamatPelanggan"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["IdBarang"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["NamaBarang"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["Harga"].AutoSizeMode =
            dataGridViewDaftarNotaJual.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarNotaJual.Columns["OngkosKirim"].DefaultCellStyle.Alignment =
            dataGridViewDaftarNotaJual.Columns["Harga"].DefaultCellStyle.Alignment =
            dataGridViewDaftarNotaJual.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewDaftarNotaJual.Columns["OngkosKirim"].DefaultCellStyle.Format =
            dataGridViewDaftarNotaJual.Columns["Harga"].DefaultCellStyle.Format =
            dataGridViewDaftarNotaJual.Columns["Jumlah"].DefaultCellStyle.Format = "#,###";
        }

        private void TampilDataGrid()
        {
            try
            {
                dataGridViewDaftarNotaJual.Rows.Clear();

                if (listNotaJual.Count > 0)
                {
                    foreach (NotaJual n in listNotaJual)
                    {
                        foreach (DetilNotaJual dnj in n.ListDetilNotaJual)
                        {
                            dataGridViewDaftarNotaJual.Rows.Add(n.NoNota, n.Tanggal.ToString("yyyy-MM-dd HH:mm:ss"), n.OngkosKirim, n.TipePembayaran, n.Pelanggan.IdPelanggan, n.Pelanggan.Nama, n.Pelanggan.Alamat, dnj.Barang.IdBarang, dnj.Barang.NamaBarang, dnj.Harga, dnj.Jumlah);
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

        public void FormDaftarNotaJual_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMasterUtama.p.Jabatan.IdJabatan == "03")
                    buttonTambah.Visible = false;

                FormatDataGrid();

                listNotaJual = NotaJual.BacaData("", "", "N.NoNota DESC");

                TampilDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNotaJual formTambahNotaJual = new FormTambahNotaJual()
            {
                Owner = this
            };
            formTambahNotaJual.ShowDialog();
        }

        private void ButtonCetak_Click(object sender, EventArgs e)
        {
            try
            {
                NotaJual.CetakNota(kriteria, textBoxCari.Text, "[STOREPEDIA]daftar_nota_jual.txt", new Font("Courier New", 12));

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
                    else if (comboBoxCari.Text == "Tanggal")
                    {
                        kriteria = "N.Tanggal";
                    }
                    else if (comboBoxCari.Text == "Ongkos Kirim")
                    {
                        kriteria = "N.OngkosKirim";
                    }
                    else if (comboBoxCari.Text == "Tipe Pembayaran")
                    {
                        kriteria = "N.TipePembayaran";
                    }
                    else if (comboBoxCari.Text == "Id Pelanggan")
                    {
                        kriteria = "N.IdPelanggan";
                    }
                    else if (comboBoxCari.Text == "Nama Pelanggan")
                    {
                        kriteria = "Plg.Nama";
                    }
                    else if (comboBoxCari.Text == "Alamat Pelanggan")
                    {
                        kriteria = "Plg.Alamat";
                    }

                    listNotaJual = NotaJual.BacaData(kriteria, textBoxCari.Text, "N.NoNota DESC");

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
