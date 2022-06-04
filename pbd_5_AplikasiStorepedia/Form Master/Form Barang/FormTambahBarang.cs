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
    public partial class FormTambahBarang : Form
    {
        FormDaftarBarang formDaftarBarang;
        List<Kategori> listKategori = new List<Kategori>();
        List<Supplier> listMerek = new List<Supplier>();
        string pathGambar;
        public FormTambahBarang()
        {
            InitializeComponent();
            textBoxHargaJual.KeyPress += KeyPressed;
            textBoxStok.KeyPress += KeyPressed;
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

        private void FormTambahBarang_Load(object sender, EventArgs e)
        {
            try
            {
                formDaftarBarang = (FormDaftarBarang)this.Owner;
                textBoxKode.Text = Barang.GenerateKode();

                listKategori = Kategori.BacaData("", "");
                comboBoxKategori.DataSource = listKategori;
                comboBoxKategori.DisplayMember = "Nama";

                listMerek = Supplier.BacaData("", "");
                comboBoxMerek.DataSource = listMerek;
                comboBoxMerek.DisplayMember = "Nama";

                comboBoxKategori.SelectedIndex = comboBoxMerek.SelectedIndex = -1;

                comboBoxKategori.SelectedIndexChanged += GenerateBarcode;
                comboBoxMerek.SelectedIndexChanged += GenerateBarcode;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBarcode.Text != "" && pathGambar != null)
                {
                    //Save Gambar
                    byte[] gambar = File.ReadAllBytes(@pathGambar);

                    Barang.TambahData(new Barang(textBoxKode.Text, textBoxNama.Text, textBoxBarcode.Text, int.Parse(textBoxHargaJual.Text), int.Parse(textBoxStok.Text), gambar, textBoxDeskripsi.Text, (Kategori)comboBoxKategori.SelectedItem, (Supplier)comboBoxMerek.SelectedItem));

                    MessageBox.Show("Data Barang berhasil disimpan.", "Info");

                    formDaftarBarang.FormDaftarBarang_Load(buttonSimpan, e);

                    textBoxKode.Text = Barang.GenerateKode();

                    ButtonKosongi_Click(e, e);
                }
                else if (textBoxBarcode.Text == "")
                {
                    MessageBox.Show("Semua ComboBox harus dipilih.", "Kesalahan");
                }
                else
                {
                    MessageBox.Show("Gambar harus dipilih.", "Kesalahan");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan");
            }
            catch (FormatException)
            {
                MessageBox.Show("Harga Jual dan Stok harus diisi.", "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Penyimpanan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelBarang.Controls)
            {
                if (c is TextBox box && c != textBoxKode)
                {
                    box.Clear();
                }
            }
            pathGambar = null;
            labelGambar.Text = "No File Choosen.";
            comboBoxMerek.SelectedIndex = comboBoxKategori.SelectedIndex = -1;
            textBoxNama.Focus();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
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
