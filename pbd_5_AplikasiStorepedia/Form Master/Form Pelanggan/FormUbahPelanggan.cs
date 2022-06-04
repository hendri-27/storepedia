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
    public partial class FormUbahPelanggan : Form
    {
        FormDaftarPelanggan formDaftarPelanggan;
        List<Pelanggan> listPelanggan = new List<Pelanggan>();
        public FormUbahPelanggan()
        {
            InitializeComponent();
        }

        private void FormUbahPelanggan_Load(object sender, EventArgs e)
        {
            formDaftarPelanggan = (FormDaftarPelanggan)this.Owner;
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 3)
                {
                    Pelanggan.UbahData(new Pelanggan(textBoxKode.Text, textBoxNama.Text, textBoxNamaPanggilan.Text, dateTimePickerTanggalLahir.Value, textBoxEmail.Text, textBoxAlamat.Text, textBoxTelpon.Text, listPelanggan[0].Username, listPelanggan[0].Password, listPelanggan[0].Saldo));

                    MessageBox.Show("Data Pelanggan berhasil diubah.", "Info");

                    formDaftarPelanggan.FormDaftarPelanggan_Load(buttonUbah, e);

                    ButtonKosongi_Click(e, e);
                }
                else if (string.IsNullOrWhiteSpace(textBoxKode.Text))
                {
                    MessageBox.Show("Id Pelanggan harus diisi.", "Kesalahan");
                    textBoxKode.Focus();
                }
                else
                {
                    MessageBox.Show("Id Pelanggan harus terdiri dari 3 karakter.", "Kesalahan");
                    textBoxKode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pengubahan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void Enabling(bool sender)
        {
            foreach (Control c in panelPelanggan.Controls)
            {
                if (c is TextBox box)
                {
                    box.Enabled = sender;
                }
            }

            textBoxKode.Enabled = !sender;
            dateTimePickerTanggalLahir.Enabled = sender;
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelPelanggan.Controls)
            {
                if (c is TextBox box)
                {
                    box.Clear();
                }
            }
            Enabling(false);
            dateTimePickerTanggalLahir.Value = DateTime.Now;
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
                if (textBoxKode.Text.Length == 3)
                {
                    listPelanggan = Pelanggan.BacaData("idPelanggan", textBoxKode.Text);
                    if (listPelanggan.Count > 0)
                    {
                        textBoxNama.Text = listPelanggan[0].Nama;
                        textBoxNamaPanggilan.Text = listPelanggan[0].NamaPanggilan;
                        dateTimePickerTanggalLahir.Value = listPelanggan[0].TglLahir;
                        textBoxEmail.Text = listPelanggan[0].Email;
                        textBoxAlamat.Text = listPelanggan[0].Alamat;
                        textBoxTelpon.Text = listPelanggan[0].NoTelp;
                        Enabling(true);
                        textBoxNama.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Id Pelanggan tidak ditemukan.", "Kesalahan");
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
