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
    public partial class FormHapusKategori : Form
    {
        FormDaftarKategori formDaftarKategori;
        List<Kategori> listKategori = new List<Kategori>();
        public FormHapusKategori()
        {
            InitializeComponent();
        }

        private void FormHapusKategori_Load(object sender, EventArgs e)
        {
            formDaftarKategori = (FormDaftarKategori)this.Owner;
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 2)
                {
                    if (Barang.BacaData("b.KodeKategori", listKategori[0].KodeKategori).Count > 0)
                    {
                        MessageBox.Show($"Kategori {listKategori[0].Nama} sedang dipakai di tabel Barang.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ButtonKosongi_Click(e, e);
                        return;
                    }

                    if (MessageBox.Show($"Kode: {textBoxKode.Text}\nNama: {textBoxNama.Text}\nData Kategori berikut akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Kategori.HapusData(listKategori[0]);

                        MessageBox.Show("Data Kategori berhasil dihapus.", "Info");

                        formDaftarKategori.FormDaftarKategori_Load(buttonHapus, e);

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
                    MessageBox.Show("Kode Kategori harus diisi.", "Kesalahan");
                    textBoxKode.Focus();
                }
                else
                {
                    MessageBox.Show("Kode Kategori harus terdiri dari 2 karakter.", "Kesalahan");
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
            textBoxKode.Text = textBoxNama.Text = "";
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
                if (textBoxKode.Text.Length == 2)
                {
                    listKategori = Kategori.BacaData("kodeKategori", textBoxKode.Text);
                    if (listKategori.Count > 0)
                    {
                        textBoxNama.Text = listKategori[0].Nama;
                    }
                    else
                    {
                        MessageBox.Show("Kode Kategori tidak ditemukan.", "Kesalahan");
                        ButtonKosongi_Click(e, e);
                    }
                }
                else if (string.IsNullOrWhiteSpace(textBoxKode.Text))
                {
                    ButtonKosongi_Click(e, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
