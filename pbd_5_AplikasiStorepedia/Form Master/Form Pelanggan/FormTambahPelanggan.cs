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
    public partial class FormTambahPelanggan : Form
    {
        FormDaftarPelanggan formDaftarPelanggan;
        public FormTambahPelanggan()
        {
            InitializeComponent();
        }

        private void FormTambahPelanggan_Load(object sender, EventArgs e)
        {
            try
            {
                formDaftarPelanggan = (FormDaftarPelanggan)this.Owner;

                textBoxKode.Text = Pelanggan.GenerateKode();
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
                if (Pelanggan.BacaData("Username", textBoxUsername.Text, true).Count == 0)
                {
                    Pelanggan.TambahData(new Pelanggan(textBoxKode.Text, textBoxNama.Text, textBoxNamaPanggilan.Text, dateTimePickerTanggalLahir.Value, textBoxEmail.Text, textBoxAlamat.Text, textBoxTelpon.Text, textBoxUsername.Text, textBoxPassword.Text, 0));
                    //Saldo masih belum tau
                    MessageBox.Show("Data Pelanggan berhasil disimpan.", "Info");

                    formDaftarPelanggan.FormDaftarPelanggan_Load(buttonSimpan, e);

                    textBoxKode.Text = Pelanggan.GenerateKode();

                    ButtonKosongi_Click(e, e);

                    textBoxNama.Focus();
                }
                else
                {
                    MessageBox.Show("Pesan Kesalahan : Username tidak tersedia.", "Kesalahan");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Penyimpanan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelPelanggan.Controls)
            {
                if (c is TextBox box && c != textBoxKode)
                {
                    box.Clear();
                }
            }
            dateTimePickerTanggalLahir.Value = DateTime.Now;
            textBoxNama.Focus();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxTelpon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 43)
                e.Handled = true;
        }
    }
}
