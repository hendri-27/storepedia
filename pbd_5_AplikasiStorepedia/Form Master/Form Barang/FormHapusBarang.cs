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
    public partial class FormHapusBarang : Form
    {
        FormDaftarBarang formDaftarBarang;
        List<Barang> listBarang = new List<Barang>();
        public FormHapusBarang()
        {
            InitializeComponent();
        }

        private void FormHapusBarang_Load(object sender, EventArgs e)
        {
            formDaftarBarang = (FormDaftarBarang)this.Owner;
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 3)
                {
                    if (MessageBox.Show($"Id: {textBoxKode.Text}\nNama Barang: {textBoxNama.Text}\nBarcode: {textBoxBarcode.Text}\nHarga Jual: Rp. {int.Parse(textBoxHargaJual.Text):n0}\nStok: {textBoxStok.Text}\nNama Kategori: {textBoxKategori.Text}\nNama Merek: {textBoxMerek.Text}\nData Barang berikut akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Barang.HapusData(listBarang[0]);

                        MessageBox.Show("Data Barang berhasil dihapus.", "Info");

                        formDaftarBarang.FormDaftarBarang_Load(buttonHapus, e);

                        ButtonKosongi_Click(e, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan dibatalkan.", "Info");
                        textBoxKode.Focus();
                    }
                }
                else if (string.IsNullOrWhiteSpace(textBoxKode.Text))
                {
                    MessageBox.Show("TextBox Kode harus diisi.", "Kesalahan");
                    textBoxKode.Focus();
                }
                else
                {
                    MessageBox.Show("TextBox Kode harus terdiri dari 3 karakter.", "Kesalahan");
                    textBoxKode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Penghapusan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelBarang.Controls)
            {
                if (c is TextBox box)
                {
                    box.Clear();
                }
            }
            textBoxKode.Focus();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxKode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxKode.TextLength == 3)
                {
                    listBarang = Barang.BacaData("b.IdBarang", textBoxKode.Text);
                    if (listBarang.Count > 0)
                    {
                        textBoxNama.Text = listBarang[0].NamaBarang;
                        textBoxBarcode.Text = listBarang[0].Barcode;
                        textBoxHargaJual.Text = listBarang[0].Harga.ToString();
                        textBoxStok.Text = listBarang[0].Stok.ToString();
                        textBoxKategori.Text = listBarang[0].Kategori.Nama;
                        textBoxMerek.Text = listBarang[0].Supplier.Nama;
                        textBoxKode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Id barang tidak ditemukan.", "Kesalahan");
                        ButtonKosongi_Click(e, e);
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
