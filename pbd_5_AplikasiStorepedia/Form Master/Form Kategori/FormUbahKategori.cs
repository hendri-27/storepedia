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
    public partial class FormUbahKategori : Form
    {
        FormDaftarKategori formDaftarKategori;
        List<Kategori> listKategori = new List<Kategori>();
        public FormUbahKategori()
        {
            InitializeComponent();
        }

        private void FormUbahKategori_Load(object sender, EventArgs e)
        {
            formDaftarKategori = (FormDaftarKategori)this.Owner;
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 2)
                {
                    Kategori.UbahData(new Kategori(textBoxKode.Text, textBoxNama.Text));

                    MessageBox.Show("Data Kategori berhasil diubah.", "Info");

                    formDaftarKategori.FormDaftarKategori_Load(buttonUbah, e);

                    ButtonKosongi_Click(e, e);
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
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Penghapusan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKode.Text = textBoxNama.Text = "";
            textBoxKode.Enabled = true;
            textBoxNama.Enabled = false;
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
                        textBoxKode.Enabled = false;
                        textBoxNama.Enabled = true;
                        textBoxNama.Focus();
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
