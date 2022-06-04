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
    public partial class FormTambahPegawai : Form
    {
        FormDaftarPegawai formDaftarPegawai;
        List<Jabatan> listJabatan = new List<Jabatan>();
        public FormTambahPegawai()
        {
            InitializeComponent();
        }

        private void FormTambahPegawai_Load(object sender, EventArgs e)
        {
            try
            {
                formDaftarPegawai = (FormDaftarPegawai)this.Owner;
                textBoxKode.Text = Pegawai.GenerateKode();

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

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Pegawai.BacaData("peg.Username", textBoxUsername.Text, true).Count == 0)
                {
                    if (comboBoxJabatan.SelectedIndex != -1 && textBoxPassword.Text == textBoxUlangiPass.Text)
                    {
                        Pegawai.TambahData(new Pegawai(textBoxKode.Text, textBoxNama.Text, textBoxNamaPanggilan.Text, dateTimePickerTanggalLahir.Value, textBoxEmail.Text, textBoxAlamat.Text, int.Parse(textBoxGaji.Text), textBoxUsername.Text, textBoxPassword.Text, (Jabatan)comboBoxJabatan.SelectedItem));

                        MessageBox.Show("Data Pegawai berhasil disimpan", "Info");

                        formDaftarPegawai.FormDaftarPegawai_Load(buttonSimpan, e);

                        textBoxKode.Text = Pegawai.GenerateKode();

                        ButtonKosongi_Click(e, e);

                        textBoxNama.Focus();
                    }
                    else if (comboBoxJabatan.SelectedIndex == -1)
                        MessageBox.Show("ComboBox Jabatan harus dipilih.", "Kesalahan");
                    else
                        MessageBox.Show("Password tidak sama dengan Ulangi Password.", "Kesalahan");
                }
                else
                {
                    MessageBox.Show("Pesan Kesalahan : Username tidak tersedia.", "Kesalahan");
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan");
            }
            catch(FormatException)
            {
                MessageBox.Show("Gaji harus diisi.", "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Penyimpanan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelPegawai.Controls)
            {
                if (c is TextBox box && c != textBoxKode)
                {
                    box.Clear();
                }
            }
            dateTimePickerTanggalLahir.Value = DateTime.Now;
            comboBoxJabatan.SelectedIndex = -1;
            textBoxNama.Focus();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxGaji_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
