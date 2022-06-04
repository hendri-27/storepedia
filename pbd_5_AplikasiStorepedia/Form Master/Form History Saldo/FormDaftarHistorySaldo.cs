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
using System.IO;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormDaftarHistorySaldo : Form
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

        List<HistorySaldo> listHistory = new List<HistorySaldo>();

        public FormDaftarHistorySaldo()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Gambar",
                Name = "Gambar",
                Width = 200,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
            };
            imageColumn.DefaultCellStyle.NullValue = null;

            dataGridViewHistorySaldo.Columns.Add("NoTransaksi", "No Transaksi");
            dataGridViewHistorySaldo.Columns.Add("IdPelanggan", "Id Pelanggan");
            dataGridViewHistorySaldo.Columns.Add("NamaPelanggan", "Nama Pelanggan");
            dataGridViewHistorySaldo.Columns.Add("Nominal", "Nominal");
            dataGridViewHistorySaldo.Columns.Add("Tanggal", "Tanggal");
            dataGridViewHistorySaldo.Columns.Add("Keterangan", "Keterangan");
            dataGridViewHistorySaldo.Columns.Add("IdBukti", "Id Bukti");
            dataGridViewHistorySaldo.Columns.Add("NamaPemilik", "Nama Pemilik Rekening");
            dataGridViewHistorySaldo.Columns.Add("NoRek", "Nomor Rekening");
            dataGridViewHistorySaldo.Columns.Add("BankAsal", "Bank Asal");
            dataGridViewHistorySaldo.Columns.Add("BankTujuan", "Bank Tujuan");
            dataGridViewHistorySaldo.Columns.Add(imageColumn);

            dataGridViewHistorySaldo.Columns["NoTransaksi"].AutoSizeMode =
            dataGridViewHistorySaldo.Columns["IdPelanggan"].AutoSizeMode =
            dataGridViewHistorySaldo.Columns["NamaPelanggan"].AutoSizeMode =
            dataGridViewHistorySaldo.Columns["Nominal"].AutoSizeMode =
            dataGridViewHistorySaldo.Columns["Tanggal"].AutoSizeMode =
            dataGridViewHistorySaldo.Columns["Keterangan"].AutoSizeMode =
            dataGridViewHistorySaldo.Columns["IdBukti"].AutoSizeMode =
            dataGridViewHistorySaldo.Columns["NamaPemilik"].AutoSizeMode =
            dataGridViewHistorySaldo.Columns["NoRek"].AutoSizeMode =
            dataGridViewHistorySaldo.Columns["BankAsal"].AutoSizeMode =
            dataGridViewHistorySaldo.Columns["BankTujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Format from left to right
            dataGridViewHistorySaldo.Columns["Nominal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Format thousand separator
            dataGridViewHistorySaldo.Columns["Nominal"].DefaultCellStyle.Format = "#,###";

            //Format height dan width
            dataGridViewHistorySaldo.RowTemplate.Height = 200;

            //Format header text alignment
            foreach (DataGridViewColumn col in dataGridViewHistorySaldo.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void TampilDataGrid()
        {
            try
            {
                dataGridViewHistorySaldo.Rows.Clear();
                if (listHistory.Count != 0)
                {
                    foreach (HistorySaldo history in listHistory)
                    {
                        BuktiTransaksi bukti = history.Bukti;
                        Image img = null;
                        if (bukti != null)
                        {
                            MemoryStream ms = new MemoryStream(bukti.BuktiFoto);
                            img = Image.FromStream(ms);
                            ms.Dispose();
                        }
                        else
                        {
                            bukti = new BuktiTransaksi(0, "", "", "", "", null);
                        }

                        dataGridViewHistorySaldo.Rows.Add(history.NoTransaksi, history.Pelanggan.IdPelanggan, history.Pelanggan.Nama, history.Nominal, history.Tanggal.ToString("yyyy-MM-dd HH:mm:ss"), history.Keterangan, (bukti.Id == 0) ? "" : bukti.Id.ToString(), bukti.NamaPemilikRek, bukti.NoRekening, bukti.BankAsal, bukti.BankTujuan, img);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void FormBuktiTransaksi_Load(object sender, EventArgs e)
        {
            try
            {
                FormatDataGrid();

                listHistory = HistorySaldo.BacaData("", "");

                TampilDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCari.SelectedIndex != -1)
                {
                    string kriteria = "HS.NoTransaksi";
                    if (comboBoxCari.Text == "Id Pelanggan")
                    {
                        kriteria = "HS.IdPelanggan";
                    }
                    else if (comboBoxCari.Text == "Nama Pelanggan")
                    {
                        kriteria = "Pel.Nama";
                    }
                    else if (comboBoxCari.Text == "Nominal")
                    {
                        kriteria = "HS.Nominal";
                    }
                    else if (comboBoxCari.Text == "Tanggal")
                    {
                        kriteria = "HS.Tanggal";
                    }
                    else if (comboBoxCari.Text == "Keterangan")
                    {
                        kriteria = "HS.Keterangan";
                    }
                    else if (comboBoxCari.Text == "Id Bukti")
                    {
                        kriteria = "HS.IdBukti";
                    }
                    else if (comboBoxCari.Text == "Nama Pemilik Rekening")
                    {
                        kriteria = "BT.NamaPemilikRek";
                    }
                    else if (comboBoxCari.Text == "No Rekening")
                    {
                        kriteria = "BT.NoRekening";
                    }
                    else if (comboBoxCari.Text == "Bank Asal")
                    {
                        kriteria = "BT.BankAsal";
                    }
                    else if (comboBoxCari.Text == "Bank Tujuan")
                    {
                        kriteria = "BT.BankTujuan";
                    }

                    listHistory = HistorySaldo.BacaData(kriteria, textBoxCari.Text);

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
