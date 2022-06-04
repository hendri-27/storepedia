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
    public partial class FormDaftarBarang : Form
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

        List<Barang> listBarang = new List<Barang>();
        public FormDaftarBarang()
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
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };

            dataGridViewBarang.Columns.Add("IdBarang", "Id Barang");
            dataGridViewBarang.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewBarang.Columns.Add("Barcode", "Barcode");
            dataGridViewBarang.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewBarang.Columns.Add("Stok", "Stok");
            dataGridViewBarang.Columns.Add(imageColumn);
            dataGridViewBarang.Columns.Add("NamaKategori", "Nama Kategori");
            dataGridViewBarang.Columns.Add("NamaSupplier", "Nama Merek");
            dataGridViewBarang.Columns.Add("Deskripsi", "Deskripsi");

            dataGridViewBarang.Columns["IdBarang"].AutoSizeMode =
            dataGridViewBarang.Columns["NamaBarang"].AutoSizeMode =
            dataGridViewBarang.Columns["Barcode"].AutoSizeMode =
            dataGridViewBarang.Columns["HargaJual"].AutoSizeMode =
            dataGridViewBarang.Columns["Stok"].AutoSizeMode =
            dataGridViewBarang.Columns["NamaKategori"].AutoSizeMode =
            dataGridViewBarang.Columns["NamaSupplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBarang.Columns["Deskripsi"].Width = 520;
            dataGridViewBarang.Columns["Deskripsi"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //Format from left to right
            dataGridViewBarang.Columns["HargaJual"].DefaultCellStyle.Alignment =
            dataGridViewBarang.Columns["Stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Format thousand separator
            dataGridViewBarang.Columns["HargaJual"].DefaultCellStyle.Format = "#,###";

            //Format height dan width
            dataGridViewBarang.RowTemplate.Height = 200;

            //Format header text alignment
            foreach (DataGridViewColumn col in dataGridViewBarang.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void TampilDataGrid()
        {
            try
            {
                dataGridViewBarang.Rows.Clear();
                foreach (Barang b in listBarang)
                {
                    //Load gambar dari byte
                    MemoryStream ms = new MemoryStream(b.Gambar);
                    Image img = Image.FromStream(ms);
                    ms.Dispose();

                    dataGridViewBarang.Rows.Add(b.IdBarang, b.NamaBarang, b.Barcode, b.Harga, b.Stok, img, b.Kategori.Nama, b.Supplier.Nama, b.Deskripsi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void FormDaftarBarang_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormMasterUtama.p.Jabatan.IdJabatan == "01")
                {
                    buttonUbah.Visible = buttonHapus.Visible = false;
                }

                listBarang = Barang.BacaData("", "");

                if (sender is FormDaftarBarang)
                    FormatDataGrid();

                if (listBarang.Count > 0)
                {
                    TampilDataGrid();
                }
                else
                {
                    dataGridViewBarang.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarang formTambahBarang = new FormTambahBarang()
            {
                Owner = this
            };
            formTambahBarang.ShowDialog();
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            FormUbahBarang formUbahBarang = new FormUbahBarang()
            {
                Owner = this
            };
            formUbahBarang.ShowDialog();
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            FormHapusBarang formHapusBarang = new FormHapusBarang()
            {
                Owner = this
            };
            formHapusBarang.ShowDialog();
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
                        case "Id Barang":
                            kriteria = "b.IdBarang";
                            break;
                        case "Nama Barang":
                            kriteria = "b.NamaBarang";
                            break;
                        case "Barcode":
                            kriteria = "b.Barcode";
                            break;
                        case "Harga Jual":
                            kriteria = "b.HargaJual";
                            break;
                        case "Stok":
                            kriteria = "b.Stok";
                            break;
                        case "Nama Kategori":
                            kriteria = "k.Nama";
                            break;
                        case "Nama Merek":
                            kriteria = "sup.Nama";
                            break;
                        case "Deskripsi":
                            kriteria = "b.Deskripsi";
                            break;
                    }

                    listBarang = Barang.BacaData(kriteria, textBoxCari.Text);
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
