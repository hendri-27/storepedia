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
    public partial class FormUbahBarang : Form
    {
        FormDaftarBarang formDaftarBarang;
        List<Kategori> listKategori = new List<Kategori>();
        List<Supplier> listMerek = new List<Supplier>();
        List<Barang> listBarang = new List<Barang>();
        string pathGambar;
        public FormUbahBarang()
        {
            InitializeComponent();
            textBoxHargaJual.KeyPress += KeyPressed;
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 9)
                e.Handled = true;
        }

        private void GenerateBarcode(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxKategori.SelectedIndex != -1 && comboBoxMerek.SelectedIndex != -1)
                {
                    textBoxBarcode.Text = Barang.GenerateBarcode(textBoxKode.Text, ((Kategori)comboBoxKategori.SelectedItem).KodeKategori, ((Supplier)comboBoxMerek.SelectedItem).IdSupplier);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void FormUbahBarang_Load(object sender, EventArgs e)
        {
            try
            {
                formDaftarBarang = (FormDaftarBarang)this.Owner;

                listKategori = Kategori.BacaData("", "");
                comboBoxKategori.DataSource = listKategori;
                comboBoxKategori.DisplayMember = "Nama";

                listMerek = Supplier.BacaData("", "");
                comboBoxMerek.DataSource = listMerek;
                comboBoxMerek.DisplayMember = "Nama";

                comboBoxMerek.SelectedIndex = comboBoxKategori.SelectedIndex = -1;

                comboBoxKategori.SelectedIndexChanged += GenerateBarcode;
                comboBoxMerek.SelectedIndexChanged += GenerateBarcode;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 3)
                {
                    //Save Gambar
                    byte[] gambar = listBarang[0].Gambar;
                    if (pathGambar != null)
                    {
                        gambar = File.ReadAllBytes(@pathGambar);
                    }

                    Barang.UbahData(new Barang(textBoxKode.Text, textBoxNama.Text, textBoxBarcode.Text, int.Parse(textBoxHargaJual.Text), listBarang[0].Stok, gambar, textBoxDeskripsi.Text, (Kategori)comboBoxKategori.SelectedItem, (Supplier)comboBoxMerek.SelectedItem));

                    MessageBox.Show("Data Barang berhasil diubah.", "Info");

                    formDaftarBarang.FormDaftarBarang_Load(buttonUbah, e);

                    ButtonKosongi_Click(e, e);
                }
                else if (string.IsNullOrWhiteSpace(textBoxKode.Text))
                {
                    MessageBox.Show("Id Barang harus diisi.", "Kesalahan");
                    textBoxKode.Focus();
                }
                else
                {
                    MessageBox.Show("Id Barang harus terdiri dari 3 karakter.", "Kesalahan");
                    textBoxKode.Focus();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan");
            }
            catch (FormatException)
            {
                MessageBox.Show("Harga Jual harus diisi.", "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pengubahan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void Enabling(bool sender)
        {
            foreach (Control c in panelBarang.Controls)
            {
                if (c is TextBox box && c != textBoxBarcode)
                {
                    box.Enabled = sender;
                }
            }
            textBoxKode.Enabled = !sender;
            comboBoxMerek.Enabled = comboBoxKategori.Enabled = sender;
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
            labelGambar.Text = "No File Choosen.";
            pathGambar = null;
            comboBoxMerek.SelectedIndex = comboBoxKategori.SelectedIndex = -1;

            Enabling(false);

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
                        textBoxDeskripsi.Text = listBarang[0].Deskripsi.ToString();
                        comboBoxKategori.Text = listBarang[0].Kategori.Nama;
                        comboBoxMerek.Text = listBarang[0].Supplier.Nama;

                        Enabling(true);

                        textBoxNama.Focus();
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

        private void ButtonGambar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog
                {
                    Filter = "JPEG files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png",
                    DefaultExt = ".jpg"
                };
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pathGambar = open.FileName;

                    string namaFile = Path.GetFileName(pathGambar);
                    string ext = Path.GetExtension(pathGambar);
                    int length = namaFile.Length;
                    labelGambar.Text = namaFile;
                    if (length > 25)
                    {
                        if (namaFile[length - 5] == '.')
                            labelGambar.Text = namaFile.Substring(0, 19) + "..." + ext;
                        else
                            labelGambar.Text = namaFile.Substring(0, 20) + "..." + ext;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxDeskripsi_TextChanged(object sender, EventArgs e)
        {
            int length = textBoxDeskripsi.TextLength;
            if (length <= textBoxDeskripsi.MaxLength)
            {
                labelJum.Text = length.ToString();
            }
            else
            {
                MessageBox.Show("Jumlah karakter telah mencapai maksimum");
                textBoxDeskripsi.Text = textBoxDeskripsi.Text.Substring(0, 1000);
            }
        }
    }
}
