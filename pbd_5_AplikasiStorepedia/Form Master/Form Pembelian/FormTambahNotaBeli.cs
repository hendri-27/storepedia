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
    public partial class FormTambahNotaBeli : Form
    {
        int grandTotal = 0;

        public FormTambahNotaBeli()
        {
            InitializeComponent();
        }

        private void FormTambahNotaBeli_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxSupplier.DataSource = Supplier.BacaData("", "");
                comboBoxSupplier.DisplayMember = "Nama";
                comboBoxSupplier.SelectedIndex = -1;
                textBoxBarcode.Enabled = false;

                labelPegawai.Text = $"{FormMasterUtama.p.IdPegawai} - {FormMasterUtama.p.Nama}";

                textBoxNoNota.Text = NotaBeli.GenerateNoNota(DateTime.Now);

                FormatDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
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

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            using (System.Transactions.TransactionScope tranScope = new System.Transactions.TransactionScope())
            {
                try
                {
                    if (dataGridViewNotaBeli.Rows.Count > 0 && comboBoxSupplier.SelectedIndex != -1)
                    {
                        Supplier supplierDipilih = (Supplier)comboBoxSupplier.SelectedItem;

                        NotaBeli notaBeli = new NotaBeli(textBoxNoNota.Text, dateTimePickerTanggalPesan.Value, FormMasterUtama.p, supplierDipilih);

                        List<Barang> listBarangTerjual = new List<Barang>();
                        for (int i = 0; i < dataGridViewNotaBeli.Rows.Count; i++)
                        {
                            listBarangTerjual = Barang.BacaData("IdBarang", dataGridViewNotaBeli.Rows[i].Cells["IdBarang"].Value.ToString());
                            notaBeli.TambahDetilNotaBeli(listBarangTerjual[0], (int)double.Parse(dataGridViewNotaBeli.Rows[i].Cells["HargaBeli"].Value.ToString()), int.Parse(dataGridViewNotaBeli.Rows[i].Cells["Jumlah"].Value.ToString()));
                        }

                        NotaBeli.TambahData(notaBeli);
                        tranScope.Complete();
                        tranScope.Dispose();

                        ((FormDaftarNotaBeli)Owner).FormDaftarNotaBeli_Load(sender, e);

                        MessageBox.Show("Data nota beli telah tersimpan.", "Informasi");

                        ButtonKosongi_Click(sender, e);

                        textBoxNoNota.Text = NotaBeli.GenerateNoNota(dateTimePickerTanggalPesan.Value);
                    }
                    else
                    {
                        MessageBox.Show("Data nota beli gagal tersimpan.", "Kesalahan");
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
            foreach (Control c in panelNotaBeli.Controls)
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
            textBoxBarcode.Enabled = false;
            dataGridViewNotaBeli.Rows.Clear();
            dateTimePickerTanggalPesan.Value = DateTime.Now;
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
                    List<Barang> listBarang = Barang.BacaData("Barcode", textBoxBarcode.Text, $"AND b.idMerek = '{((Supplier)comboBoxSupplier.SelectedItem).IdSupplier}'");

                    if (listBarang.Count != 0)
                    {
                        labelKode.Text = listBarang[0].IdBarang;
                        labelNamaBarang.Text = listBarang[0].NamaBarang;
                        labelHarga.Text = listBarang[0].Harga.ToString();
                        textBoxJum.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Barang dengan barcode tersebut tidak ditemukan pada supplier {comboBoxSupplier.Text}");
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
                    for (int i = 0; i < dataGridViewNotaBeli.Rows.Count; i++)
                    {
                        if (dataGridViewNotaBeli.Rows[i].Cells["IdBarang"].Value.ToString() == labelKode.Text)
                        {
                            dataGridViewNotaBeli.Rows[i].Cells["Jumlah"].Value = int.Parse(dataGridViewNotaBeli.Rows[i].Cells["Jumlah"].Value.ToString()) + int.Parse(textBoxJum.Text);
                            dataGridViewNotaBeli.Rows[i].Cells["SubTotal"].Value = double.Parse(dataGridViewNotaBeli.Rows[i].Cells["SubTotal"].Value.ToString()) + subTotal;
                            isAvailable = true;
                        }
                    }

                    if (!isAvailable)
                        dataGridViewNotaBeli.Rows.Add(labelKode.Text, labelNamaBarang.Text, int.Parse(labelHarga.Text), textBoxJum.Text, subTotal);

                    labelGrandTotal.Text = "Rp" + HitungGrandTotal().ToString("#,###");

                    textBoxBarcode.Text = labelKode.Text = labelNamaBarang.Text = labelHarga.Text = textBoxJum.Text = "";

                    textBoxBarcode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"terjadi Kesalahan. Pesan Kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private int HitungGrandTotal()
        {
            for (int i = 0; i < dataGridViewNotaBeli.Rows.Count; i++)
            {
                int subtotal = int.Parse(dataGridViewNotaBeli.Rows[i].Cells["SubTotal"].Value.ToString());
                grandTotal += subtotal;
            }
            return grandTotal;
        }

        private void ComboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSupplier.SelectedIndex != -1)
                {
                    Supplier supplierDipilih = (Supplier)comboBoxSupplier.SelectedItem;
                    textBoxAlamat.Text = supplierDipilih.Alamat;

                    textBoxBarcode.Enabled = true;
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

        private void DateTimePickerTanggalPesan_ValueChanged(object sender, EventArgs e)
        {
            textBoxNoNota.Text = NotaBeli.GenerateNoNota(dateTimePickerTanggalPesan.Value);
        }
    }
}
