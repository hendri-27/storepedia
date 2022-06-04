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
    public partial class FormTambahSupplier : Form
    {
        FormDaftarSupplier formDaftarSupplier;
        public FormTambahSupplier()
        {
            InitializeComponent();
        }

        private void FormTambahSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                formDaftarSupplier = (FormDaftarSupplier)this.Owner;

                textBoxKode.Text = Supplier.GenerateKode();
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
                Supplier.TambahData(new Supplier(textBoxKode.Text, textBoxNama.Text, textBoxAlamat.Text));

                MessageBox.Show("Data Supplier berhasil disimpan.", "Info");

                formDaftarSupplier.FormDaftarSupplier_Load(buttonSimpan, e);

                textBoxKode.Text = Supplier.GenerateKode();

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
            textBoxNama.Text = textBoxAlamat.Text = "";
            textBoxNama.Focus();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
