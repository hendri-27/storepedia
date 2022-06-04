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
    public partial class FormTambahNotaJual : Form
    {
        int grandTotal = 0;

        public FormTambahNotaJual()
        {
            InitializeComponent();
        }

        private void FormTambahNotaJual_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxPelanggan.DataSource = Pelanggan.BacaData("", "");
                comboBoxPelanggan.DisplayMember = "Nama";
                comboBoxPelanggan.SelectedIndex = -1;

                textBoxNoNota.Text = NotaJual.GenerateNoNota(DateTime.Now);

                FormatDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void FormatDataGrid()
        {
            dataGridViewNotaJual.Columns.Clear();

            dataGridViewNotaJual.Columns.Add("IdBarang", "Id Barang");
            dataGridViewNotaJual.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewNotaJual.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewNotaJual.Columns.Add("Jumlah", "Jumlah");
            dataGridViewNotaJual.Columns.Add("SubTotal", "SubTotal");

            dataGridViewNotaJual.Columns["IdBarang"].AutoSizeMode =
            dataGridViewNotaJual.Columns["NamaBarang"].AutoSizeMode =
            dataGridViewNotaJual.Columns["HargaJual"].AutoSizeMode =
            dataGridViewNotaJual.Columns["Jumlah"].AutoSizeMode =
            dataGridViewNotaJual.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewNotaJual.Columns["HargaJual"].DefaultCellStyle.Alignment =
            dataGridViewNotaJual.Columns["Jumlah"].DefaultCellStyle.Alignment =
            dataGridViewNotaJual.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewNotaJual.Columns["HargaJual"].DefaultCellStyle.Format =
            dataGridViewNotaJual.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            using (System.Transactions.TransactionScope tranScope = new System.Transactions.TransactionScope())
            {
                try
                {
                    if (dataGridViewNotaJual.Rows.Count > 0 && comboBoxTipeBayar.SelectedIndex != -1 && comboBoxPelanggan.SelectedIndex != -1)
                    {
                        Pelanggan pelangganDipilih = (Pelanggan)comboBoxPelanggan.SelectedItem;

                        int ongkos = grandTotal * 10 / 100;

                        NotaJual notaJual = new NotaJual(textBoxNoNota.Text, dateTimePickerTanggal.Value, ongkos, comboBoxTipeBayar.Text, pelangganDipilih);

                        List<Barang> listBarangTerjual = new List<Barang>();
                        for (int i = 0; i < dataGridViewNotaJual.Rows.Count; i++)
                        {
                            listBarangTerjual = Barang.BacaData("IdBarang", dataGridViewNotaJual.Rows[i].Cells["IdBarang"].Value.ToString());
                            notaJual.TambahDetilNotaJual(listBarangTerjual[0], (int)double.Parse(dataGridViewNotaJual.Rows[i].Cells["HargaJual"].Value.ToString()), int.Parse(dataGridViewNotaJual.Rows[i].Cells["Jumlah"].Value.ToString()));
                        }

                        pelangganDipilih.MengurangiSaldo(grandTotal + ongkos);

                        NotaJual.TambahData(notaJual);

                        tranScope.Complete();
                        tranScope.Dispose();

                        ((FormDaftarNotaJual)Owner).FormDaftarNotaJual_Load(sender, e);

                        MessageBox.Show("Data nota jual telah tersimpan.", "Informasi");

                        ButtonKosongi_Click(sender, e);

                        textBoxNoNota.Text = NotaJual.GenerateNoNota(dateTimePickerTanggal.Value);

                        //buttonCetak_Click(sender, e);

                    }
                    else
                    {
                        tranScope.Dispose();
                        MessageBox.Show("Data nota jual gagal tersimpan.", "Kesalahan");
                    }
                }
                catch (Exception ex)
                {
                    tranScope.Dispose();
                    MessageBox.Show($"Terjadi Kesalahan. Pesan Kesalahan: {ex.Message}", "Kesalahan");
                }
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            foreach(Control c in panelNotaJual.Controls)
            {
                if (c is TextBox tb && c != textBoxNoNota)
                {
                    tb.Clear();
                }
                else if (c is ComboBox cb)
                {
                    cb.SelectedIndex = -1;
                }
            }
            dataGridViewNotaJual.Rows.Clear();
            dateTimePickerTanggal.Value = DateTime.Now;
            labelNamaBarang.Text = labelKode.Text = labelHarga.Text = "";
            labelGrandTotal.Text = "Rp0";
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBarcode.Text.Length == textBoxBarcode.MaxLength)
                {
                    List<Barang> listBarang = Barang.BacaData("Barcode", textBoxBarcode.Text);
                    if (listBarang.Count != 0)
                    {
                        labelKode.Text = listBarang[0].IdBarang;
                        labelNamaBarang.Text = listBarang[0].NamaBarang;
                        labelHarga.Text = listBarang[0].Harga.ToString();
                        textBoxJum.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Barang dengan barcode tersebut tidak ditemukan");
                        textBoxBarcode.Clear();
                        labelKode.Text = labelNamaBarang.Text = labelHarga.Text = "";
                        textBoxJum.Clear();
                        textBoxBarcode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxJum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TextBoxJum_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && textBoxBarcode.Text.Length == textBoxBarcode.MaxLength && int.Parse(textBoxJum.Text) > 0)
                {
                    int subTotal = int.Parse(labelHarga.Text) * int.Parse(textBoxJum.Text);

                    bool isAvailable = false;
                    for (int i = 0; i < dataGridViewNotaJual.Rows.Count; i++)
                    {
                        if (dataGridViewNotaJual.Rows[i].Cells["IdBarang"].Value.ToString() == labelKode.Text)
                        {
                            dataGridViewNotaJual.Rows[i].Cells["Jumlah"].Value = int.Parse(dataGridViewNotaJual.Rows[i].Cells["Jumlah"].Value.ToString()) + int.Parse(textBoxJum.Text);
                            dataGridViewNotaJual.Rows[i].Cells["SubTotal"].Value = double.Parse(dataGridViewNotaJual.Rows[i].Cells["SubTotal"].Value.ToString()) + subTotal;
                            isAvailable = true;
                        }
                    }

                    if (!isAvailable)
                        dataGridViewNotaJual.Rows.Add(labelKode.Text, labelNamaBarang.Text, int.Parse(labelHarga.Text), textBoxJum.Text, subTotal);

                    labelGrandTotal.Text = "Rp" + HitungGrandTotal().ToString("#,###");

                    textBoxBarcode.Text = labelKode.Text = labelNamaBarang.Text = labelHarga.Text = textBoxJum.Text = "";

                    textBoxBarcode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan. Pesan Kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private int HitungGrandTotal()
        {
            for (int i = 0; i < dataGridViewNotaJual.Rows.Count; i++)
            {
                int subtotal = int.Parse(dataGridViewNotaJual.Rows[i].Cells["SubTotal"].Value.ToString());
                grandTotal += subtotal;
            }
            return grandTotal;
        }

        private void ComboBoxPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPelanggan.SelectedIndex != -1)
                {
                    Pelanggan pelangganDipilih = (Pelanggan)comboBoxPelanggan.SelectedItem;
                    textBoxAlamat.Text = pelangganDipilih.Alamat;

                    textBoxBarcode.Focus();
                }
                else
                {
                    textBoxAlamat.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
