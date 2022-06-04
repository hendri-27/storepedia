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
    public partial class FormTambahPengiriman : Form
    {
        public FormTambahPengiriman()
        {
            InitializeComponent();
        }

        private void ComboBoxNoNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Pengiriman> listPengiriman = Pengiriman.BacaData("", "", "");
            foreach (Pengiriman kirim in listPengiriman)
            {
                comboBoxPegawai.SelectedIndex = -1;
                if (kirim.Nota.NoNota == comboBoxNoNota.Text)
                {
                    comboBoxPegawai.Enabled = buttonSimpan.Enabled = false;
                    comboBoxPegawai.Text = kirim.Pegawai.Nama;
                    break;
                }
                else
                {
                    comboBoxPegawai.Enabled = buttonSimpan.Enabled = true;
                }
            }
        }

        private void FormTambahPengiriman_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxNoNota.DataSource = NotaJual.BacaData("", "", "N.NoNota DESC");
                comboBoxNoNota.DisplayMember = "NoNota";

                comboBoxPegawai.DataSource = Pegawai.BacaData("peg.idJabatan", "05");
                comboBoxPegawai.DisplayMember = "Nama";
                comboBoxNoNota.SelectedIndex = comboBoxPegawai.SelectedIndex = -1;
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
                if (comboBoxNoNota.SelectedIndex != -1)
                {
                    Pengiriman.TambahData(new Pengiriman((NotaJual)comboBoxNoNota.SelectedItem, (Pegawai)comboBoxPegawai.SelectedItem, DateTime.MinValue, null));

                    MessageBox.Show("Data Pengiriman berhasil disimpan", "Info");

                    ((FormDaftarPengiriman)Owner).FormDaftarPengiriman_Load(buttonSimpan, e);

                    ButtonKosongi_Click(sender, e);
                }
                else
                    MessageBox.Show("Silahkan pilih terlebih dahulu nomor nota yang ingin disimpan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Penyimpanan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            comboBoxNoNota.SelectedIndex = comboBoxPegawai.SelectedIndex = -1;
            comboBoxPegawai.Enabled = false;
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
