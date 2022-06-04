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
    public partial class FormUpdateTerimaBarang : Form
    {
        List<NotaBeli> listNotaBeli = new List<NotaBeli>();

        public FormUpdateTerimaBarang()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewNotaBeli.Columns.Clear();

            dataGridViewNotaBeli.Columns.Add("IdBarang", "Id Barang");
            dataGridViewNotaBeli.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewNotaBeli.Columns.Add("HargaBeli", "Harga Beli");
            dataGridViewNotaBeli.Columns.Add("Jumlah", "Jumlah");
            dataGridViewNotaBeli.Columns.Add("SubTotal", "SubTotal");

            dataGridViewNotaBeli.Columns["IdBarang"].AutoSizeMode =
            dataGridViewNotaBeli.Columns["NamaBarang"].AutoSizeMode =
            dataGridViewNotaBeli.Columns["HargaBeli"].AutoSizeMode =
            dataGridViewNotaBeli.Columns["Jumlah"].AutoSizeMode =
            dataGridViewNotaBeli.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewNotaBeli.Columns["HargaBeli"].DefaultCellStyle.Alignment =
            dataGridViewNotaBeli.Columns["Jumlah"].DefaultCellStyle.Alignment =
            dataGridViewNotaBeli.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewNotaBeli.Columns["HargaBeli"].DefaultCellStyle.Format =
            dataGridViewNotaBeli.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";
        }

        private void FormUpdateTerimaBarang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            labelPegawai.Text = $"{FormMasterUtama.p.IdPegawai} - {FormMasterUtama.p.Nama}";

            comboBoxNoNota.DataSource = NotaBeli.BacaData("N.TanggalTerima", "NULL");
            comboBoxNoNota.DisplayMember = "NoNota";
            comboBoxNoNota.SelectedIndex = -1;
            comboBoxNoNota.SelectedIndexChanged += comboBoxNoNota_SelectedIndexChanged;
        }

        private void comboBoxNoNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxNoNota.SelectedIndex != -1)
                {
                    dataGridViewNotaBeli.Rows.Clear();

                    listNotaBeli = NotaBeli.BacaData("N.NoNota", comboBoxNoNota.Text);
                    if (string.IsNullOrWhiteSpace(listNotaBeli[0].NamaKurir))
                    {
                        dateTimePickerTanggalTerima.Enabled = textBoxNamaKurir.Enabled = true;
                    }

                    if (listNotaBeli[0].TanggalTerima.Year != 0001)
                    {
                        dateTimePickerTanggalTerima.Value = listNotaBeli[0].TanggalTerima;
                    }

                    dateTimePickerTanggalPesan.Value = listNotaBeli[0].TanggalPesan;
                    textBoxNamaKurir.Text = listNotaBeli[0].NamaKurir ?? "";
                    textBoxNamaSupplier.Text = listNotaBeli[0].Supplier.Nama;
                    textBoxAlamat.Text = listNotaBeli[0].Supplier.Alamat;
                    labelPegawai.Text = listNotaBeli[0].Pegawai.Nama;

                    int totalHarga = 0;
                    foreach (DetilNotaBeli dnb in listNotaBeli[0].ListDetilNotaBeli)
                    {
                        int subTotal = dnb.Harga * dnb.Jumlah;
                        dataGridViewNotaBeli.Rows.Add(dnb.Barang.IdBarang, dnb.Barang.NamaBarang, dnb.Harga, dnb.Jumlah, subTotal);
                        totalHarga += subTotal;
                    }
                    labelGrandTotal.Text = "Rp" + totalHarga.ToString("#,###");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxNamaKurir.Text))
                {
                    NotaBeli.UpdateTerimaBarang(new NotaBeli(listNotaBeli[0].NoNota, listNotaBeli[0].TanggalPesan, listNotaBeli[0].Pegawai, listNotaBeli[0].Supplier, dateTimePickerTanggalTerima.Value, textBoxNamaKurir.Text));

                    MessageBox.Show("Data berhasil diupdate.", "Informasi");

                    ((FormDaftarNotaBeli)Owner).FormDaftarNotaBeli_Load(sender, e);

                    ButtonKosongi_Click(sender, e);
                }
                else
                    MessageBox.Show("Nama Kurir tidak boleh kosong.", "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            comboBoxNoNota.SelectedIndex = -1;
            dateTimePickerTanggalTerima.Enabled = textBoxNamaKurir.Enabled = false;
            dateTimePickerTanggalPesan.Value = dateTimePickerTanggalTerima.Value = DateTime.Now;
            foreach (Control c in panelNotaBeli.Controls)
            {
                if (c is TextBox tb)
                    tb.Clear();
            }
            labelGrandTotal.Text = "Rp0";
            dataGridViewNotaBeli.Rows.Clear();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
