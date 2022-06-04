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
    public partial class FormTambahKategori : Form
    {
        FormDaftarKategori formDaftarKategori;
        public FormTambahKategori()
        {
            InitializeComponent();
        }

        private void FormTambahKategori_Load(object sender, EventArgs e)
        {
            try
            {
                formDaftarKategori = (FormDaftarKategori)this.Owner;
                textBoxKode.Text = Kategori.GenerateKode();
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
                Kategori.TambahData(new Kategori(textBoxKode.Text, textBoxNama.Text));

                MessageBox.Show("Data Kategori berhasil disimpan.", "Info");

                formDaftarKategori.FormDaftarKategori_Load(buttonSimpan, e);

                textBoxKode.Text = Kategori.GenerateKode();

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
            textBoxNama.Text = "";
            textBoxNama.Focus();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
