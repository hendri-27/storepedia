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
    public partial class FormUbahPegawai : Form
    {
        FormDaftarPegawai formDaftarPegawai;
        List<Pegawai> listPegawai = new List<Pegawai>();
        List<Jabatan> listJabatan = new List<Jabatan>();

        public FormUbahPegawai()
        {
            InitializeComponent();
        }

        private void FormUbahPegawai_Load(object sender, EventArgs e)
        {
            try
            {
                formDaftarPegawai = (FormDaftarPegawai)this.Owner;

                listJabatan = Jabatan.BacaData("", "");
                comboBoxJabatan.DataSource = listJabatan;
                comboBoxJabatan.DisplayMember = "Nama";
                comboBoxJabatan.SelectedIndex = -1;
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
                    if (Pegawai.BacaData("peg.Username", textBoxUsername.Text, true).Count == 0)
                    {
                        Pegawai.UbahData(new Pegawai(textBoxKode.Text, textBoxNama.Text, textBoxNamaPanggilan.Text, dateTimePickerTanggalLahir.Value, textBoxEmail.Text, textBoxAlamat.Text, long.Parse(textBoxGaji.Text), textBoxUsername.Text, listPegawai[0].Password, (Jabatan)comboBoxJabatan.SelectedItem));

                        MessageBox.Show("Data Pegawai berhasil diubah.", "Info");

                        formDaftarPegawai.FormDaftarPegawai_Load(buttonUbah, e);

                        ButtonKosongi_Click(e, e);
                    }
                    else
                    {
                        MessageBox.Show("Pesan Kesalahan : Username tidak tersedia.", "Kesalahan");
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
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan");
            }
            catch (FormatException)
            {
                MessageBox.Show("Gaji harus diisi.", "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pengubahan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void Enabling(bool sender)
        {
            foreach (Control c in panelPegawai.Controls)
            {
                if (c is TextBox box)
                {
                    box.Enabled = sender;
                }
            }
            textBoxKode.Enabled = !sender;
            comboBoxJabatan.Enabled = dateTimePickerTanggalLahir.Enabled = sender;
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
            Enabling(false);
            dateTimePickerTanggalLahir.Value = DateTime.Now;
            comboBoxJabatan.SelectedIndex = -1;
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
                        comboBoxJabatan.Text = listPegawai[0].Jabatan.Nama;
                        textBoxUsername.Text = listPegawai[0].Username;
                        Enabling(true);
                        textBoxNama.Focus();
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

        private void TextBoxGaji_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
