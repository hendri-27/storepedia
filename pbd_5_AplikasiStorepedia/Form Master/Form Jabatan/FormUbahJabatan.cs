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
    public partial class FormUbahJabatan : Form
    {
        FormDaftarJabatan formDaftarJabatan;
        List<Jabatan> listJabatan = new List<Jabatan>();

        public FormUbahJabatan()
        {
            InitializeComponent();
        }

        private void FormUbahJabatan_Load(object sender, EventArgs e)
        {
            formDaftarJabatan = (FormDaftarJabatan)this.Owner;
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 2)
                {
                    Jabatan.UbahData(new Jabatan(textBoxKode.Text, textBoxNama.Text));

                    MessageBox.Show("Data Jabatan berhasil diubah.", "Info");

                    formDaftarJabatan.FormDaftarJabatan_Load(buttonUbah, e);

                    ButtonKosongi_Click(e, e);
                }
                else if (string.IsNullOrWhiteSpace(textBoxKode.Text))
                {
                    MessageBox.Show("Id Jabatan harus diisi.", "Kesalahan");
                    textBoxKode.Focus();
                }
                else
                {
                    MessageBox.Show("Id Jabatan harus terdiri dari 2 karakter.", "Kesalahan");
                    textBoxKode.Focus();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pengubahan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKode.Clear();
            textBoxNama.Clear();
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
                if (textBoxKode.TextLength == 2)
                {
                    listJabatan = Jabatan.BacaData("idJabatan", textBoxKode.Text);
                    if (listJabatan.Count > 0)
                    {
                        textBoxNama.Text = listJabatan[0].Nama;
                        textBoxKode.Enabled = false;
                        textBoxNama.Enabled = true;
                        textBoxNama.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Id Jabatan tidak ditemukan.", "Kesalahan");
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
