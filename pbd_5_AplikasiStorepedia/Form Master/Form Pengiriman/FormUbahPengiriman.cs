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
    public partial class FormUbahPengiriman : Form
    {
        List<Pengiriman> listPengiriman = new List<Pengiriman>();

        public FormUbahPengiriman()
        {
            InitializeComponent();
        }

        private void FormUbahPengiriman_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxNoNota.DataSource = NotaJual.BacaData("", "", "N.NoNota DESC");
                comboBoxNoNota.DisplayMember = "NoNota";

                comboBoxPegawai.DataSource = Pegawai.BacaData("peg.idJabatan", "05");
                comboBoxPegawai.DisplayMember = "Nama";
                comboBoxPegawai.SelectedIndex = comboBoxNoNota.SelectedIndex = -1;
                comboBoxNoNota.SelectedIndexChanged += ComboBoxNoNota_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ComboBoxNoNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxNoNota.SelectedIndex != -1)
                {
                    listPengiriman = Pengiriman.BacaData("pk.noNota", comboBoxNoNota.Text, "pk.noNota ASC");
                    if (listPengiriman.Count > 0)
                    {
                        if (string.IsNullOrWhiteSpace(listPengiriman[0].Status))
                        {
                            comboBoxNoNota.Enabled = false;
                            textBoxStatus.Enabled = comboBoxPegawai.Enabled = dateTimePickerTanggalKirim.Enabled = true;
                        }
                        else
                            comboBoxNoNota.Enabled = true;
                        comboBoxPegawai.Text = listPengiriman[0].Pegawai.Nama;
                        textBoxStatus.Text = listPengiriman[0].Status;
                        dateTimePickerTanggalKirim.Value = listPengiriman[0].Tanggal.Year == 0001 ? DateTime.Now : listPengiriman[0].Tanggal;
                    }
                    else
                    {
                        MessageBox.Show("Data dengan Nomor Nota tersebut tidak ditemukan.", "Kesalahan");
                        ButtonKosongi_Click(e, e);
                    }
                }
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
                if (comboBoxNoNota.SelectedIndex != -1)
                {
                    if (!string.IsNullOrWhiteSpace(textBoxStatus.Text))
                    {
                        Pengiriman.UbahData(new Pengiriman((NotaJual)comboBoxNoNota.SelectedItem, (Pegawai)comboBoxPegawai.SelectedItem, dateTimePickerTanggalKirim.Value, textBoxStatus.Text));

                        MessageBox.Show("Data Pengiriman berhasil diubah", "Info");

                        ((FormDaftarPengiriman)Owner).FormDaftarPengiriman_Load(buttonUbah, e);

                        ButtonKosongi_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Silahkan mengisikan status terlebih dahulu.\nFormat : 'sudah' jika pesanan sudah  dikirim sampai ke pelanggan.");
                }
                else
                    MessageBox.Show("Silahkan pilih terlebih dahulu nomor nota yang ingin diubah");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pengubahan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            comboBoxNoNota.SelectedIndex = comboBoxPegawai.SelectedIndex = -1;
            textBoxStatus.Clear();
            dateTimePickerTanggalKirim.Value = DateTime.Now;

            comboBoxNoNota.Enabled = true;
            comboBoxPegawai.Enabled = textBoxStatus.Enabled = dateTimePickerTanggalKirim.Enabled = false;
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
