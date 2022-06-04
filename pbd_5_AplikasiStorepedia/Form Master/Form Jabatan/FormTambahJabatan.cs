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
    public partial class FormTambahJabatan : Form
    {
        FormDaftarJabatan formDaftarJabatan;

        public FormTambahJabatan()
        {
            InitializeComponent();
        }

        private void FormTambahJabatan_Load(object sender, EventArgs e)
        {
            try
            {
                formDaftarJabatan = (FormDaftarJabatan)this.Owner;
                textBoxKode.Text = Jabatan.GenerateKode();
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
                Jabatan.TambahData(new Jabatan(textBoxKode.Text, textBoxNama.Text));

                MessageBox.Show("Data Jabatan berhasil disimpan.", "Info");

                formDaftarJabatan.FormDaftarJabatan_Load(buttonSimpan, e);
                
                textBoxKode.Text = Jabatan.GenerateKode();

                ButtonKosongi_Click(e, e);

                textBoxNama.Focus();
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
            textBoxNama.Clear();
            textBoxNama.Focus();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
