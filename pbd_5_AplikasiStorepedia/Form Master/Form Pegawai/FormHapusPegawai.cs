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
    public partial class FormHapusPegawai : Form
    {
        FormDaftarPegawai formDaftarPegawai;
        List<Pegawai> listPegawai = new List<Pegawai>();
        public FormHapusPegawai()
        {
            InitializeComponent();
        }

        private void FormHapusPegawai_Load(object sender, EventArgs e)
        {
            formDaftarPegawai = (FormDaftarPegawai)this.Owner;
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 3)
                {
                    if (MessageBox.Show($"Id: {textBoxKode.Text}\nNama: {textBoxNama.Text}\nNama Panggilan: {textBoxNamaPanggilan.Text}\nTgl Lahir: {dateTimePickerTanggalLahir.Value:yyyy-MM-dd}\nEmail: {textBoxEmail.Text}\nAlamat: {textBoxAlamat.Text}\nGaji: Rp. {int.Parse(textBoxGaji.Text):n0}\nJabatan: {textBoxJabatan.Text}\nUsername: {textBoxUsername.Text}\nData Pegawai berikut akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Pegawai.HapusData(listPegawai[0]);

                        MessageBox.Show("Data Pegawai berhasil dihapus.", "Info");

                        formDaftarPegawai.FormDaftarPegawai_Load(buttonHapus, e);

                        ButtonKosongi_Click(e, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan dibatalkan.", "Info");
                    }
                }
                else if (string.IsNullOrWhiteSpace(textBoxKode.Text))
                {
                    MessageBox.Show("Id Pegawai harus diisi.", "Kesalahan");
                    textBoxKode.Focus();
                }
                else
                {
                    MessageBox.Show("Id Pegawai harus terdiri dari 3 karakter.", "Kesalahan");
                    textBoxKode.Focus();
                }
            }
            catch(ArgumentException ex)
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
            foreach (Control c in panelPegawai.Controls)
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
                    listPegawai = Pegawai.BacaData("idPegawai", textBoxKode.Text);
                    if (listPegawai.Count > 0)
                    {
                        textBoxNama.Text = listPegawai[0].Nama;
                        textBoxNamaPanggilan.Text = listPegawai[0].NamaPanggilan;
                        dateTimePickerTanggalLahir.Value = listPegawai[0].TglLahir;
                        textBoxEmail.Text = listPegawai[0].Email;
                        textBoxAlamat.Text = listPegawai[0].Alamat;
                        textBoxGaji.Text = listPegawai[0].Gaji.ToString();
                        textBoxJabatan.Text = listPegawai[0].Jabatan.Nama;
                        textBoxUsername.Text = listPegawai[0].Username;
                    }
                    else
                    {
                        MessageBox.Show("Id Pegawai tidak ditemukan.", "Kesalahan");
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
