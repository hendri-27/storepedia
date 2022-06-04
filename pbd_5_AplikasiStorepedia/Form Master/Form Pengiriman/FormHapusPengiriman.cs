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
    public partial class FormHapusPengiriman : Form
    {
        List<Pengiriman> listPengiriman = new List<Pengiriman>();

        public FormHapusPengiriman()
        {
            InitializeComponent();
        }

        private void FormHapusPengiriman_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxNoNota.DataSource = NotaJual.BacaData("", "", "N.NoNota DESC");
                comboBoxNoNota.DisplayMember = "NoNota";
                comboBoxNoNota.SelectedIndex = -1;
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
                        textBoxNamaPegawai.Text = listPengiriman[0].Pegawai.Nama;
                        textBoxStatus.Text = listPengiriman[0].Status;
                        dateTimePickerTanggalKirim.Value = listPengiriman[0].Tanggal.Year == 0001 ? DateTime.Now : listPengiriman[0].Tanggal;
                    }
                    else
                    {
                        MessageBox.Show("Data dengan Nomor Nota tersebut tidak ditemukan.", "Kesalahan");
                        ButtonKosongi_Click(e, e);
                    }
                }
                else
                    MessageBox.Show("Silahkan pilih terlebih dahulu nomor nota yang ingin dihapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxNoNota.SelectedIndex != -1)
                {
                    if (MessageBox.Show($"No Nota: {comboBoxNoNota.Text}\nNama Pegawai: {textBoxNamaPegawai.Text}\nStatus: {textBoxStatus.Text}\nTgl Pengiriman: {((listPengiriman[0].Tanggal.Year == 0001 )? "":listPengiriman[0].Tanggal.ToString("yyyy-MM-dd HH-mm-ss"))}\nData Pengiriman berikut akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Pengiriman.HapusData(listPengiriman[0]);
                        
                        MessageBox.Show("Data Pengiriman berhasil dihapus.", "Info");

                        ((FormDaftarPengiriman)Owner).FormDaftarPengiriman_Load(buttonHapus, e);

                        ButtonKosongi_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan dibatalkan.", "Info");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Penghapusan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            comboBoxNoNota.SelectedIndex = -1;
            textBoxNamaPegawai.Clear();
            textBoxStatus.Clear();
            dateTimePickerTanggalKirim.Value = DateTime.Now;
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
