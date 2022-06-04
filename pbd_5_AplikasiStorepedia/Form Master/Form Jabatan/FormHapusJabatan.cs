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
    public partial class FormHapusJabatan : Form
    {
        FormDaftarJabatan formDaftarJabatan;
        List<Jabatan> listJabatan = new List<Jabatan>();

        public FormHapusJabatan()
        {
            InitializeComponent();
        }

        private void FormHapusJabatan_Load(object sender, EventArgs e)
        {
            formDaftarJabatan = (FormDaftarJabatan)this.Owner;
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 2)
                {
                    if (Pegawai.BacaData("peg.IdJabatan", listJabatan[0].IdJabatan).Count > 0)
                    {
                        MessageBox.Show($"Jabatan {listJabatan[0].Nama} sedang dipakai di tabel Pegawai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ButtonKosongi_Click(e, e);
                        return;
                    }    

                    if (MessageBox.Show($"Id: {textBoxKode.Text}\nNama: {textBoxNama.Text}\nData Jabatan berikut akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Jabatan.HapusData(listJabatan[0]);

                        MessageBox.Show("Data Jabatan berhasil dihapus", "Info");

                        formDaftarJabatan.FormDaftarJabatan_Load(buttonHapus, e);

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
                    MessageBox.Show("TextBox Kode harus terdiri dari 2 karakter.", "Kesalahan");
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
                if (textBoxKode.TextLength == 2)
                {
                    listJabatan = Jabatan.BacaData("idJabatan", textBoxKode.Text);
                    if (listJabatan.Count > 0)
                    {
                        textBoxNama.Text = listJabatan[0].Nama;
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
