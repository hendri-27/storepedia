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
    public partial class FormHapusPelanggan : Form
    {
        FormDaftarPelanggan formDaftarPelanggan;
        List<Pelanggan> listPelanggan = new List<Pelanggan>();

        public FormHapusPelanggan()
        {
            InitializeComponent();
        }

        private void FormHapusPelanggan_Load(object sender, EventArgs e)
        {
            formDaftarPelanggan = (FormDaftarPelanggan)this.Owner;
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 3)
                {
                    if (MessageBox.Show($"Id: {textBoxKode.Text}\nNama: {textBoxNama.Text}\nNama Panggilan: {textBoxNamaPanggilan.Text}\nTgl Lahir: {dateTimePickerTanggalLahir.Value:yyyy-MM-dd}\nEmail: {textBoxEmail.Text}\nAlamat: {textBoxAlamat.Text}\nNo Telp: {textBoxTelpon.Text}\nUsername: {textBoxUsername.Text}\nData Pelanggan berikut akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Pelanggan.HapusData(listPelanggan[0]);

                        MessageBox.Show("Data Pelanggan berhasil dihapus.", "Info");

                        formDaftarPelanggan.FormDaftarPelanggan_Load(buttonHapus, e);

                        ButtonKosongi_Click(e, e);
                    }
                    else
                        MessageBox.Show("Penghapusan dibatalkan.", "Info");
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
            foreach (Control c in panelPelanggan.Controls)
            {
                if (c is TextBox box)
                {
                    box.Clear();
                }
            }
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
                        textBoxUsername.Text = listPelanggan[0].Username;
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
