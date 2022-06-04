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
    public partial class FormUbahSupplier : Form
    {
        FormDaftarSupplier formDaftarSupplier;
        List<Supplier> listSupplier = new List<Supplier>();
        public FormUbahSupplier()
        {
            InitializeComponent();
        }

        private void FormUbahSupplier_Load(object sender, EventArgs e)
        {
            formDaftarSupplier = (FormDaftarSupplier)this.Owner;
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 2)
                {
                    Supplier.UbahData(new Supplier(textBoxKode.Text, textBoxNama.Text, textBoxAlamat.Text));

                    MessageBox.Show("Data Supplier berhasil diubah.", "Info");

                    formDaftarSupplier.FormDaftarSupplier_Load(buttonUbah, e);

                    ButtonKosongi_Click(e, e);
                }
                else if (string.IsNullOrWhiteSpace(textBoxKode.Text))
                {
                    MessageBox.Show("Id Supplier harus diisi.", "Kesalahan");
                    textBoxKode.Focus();
                }
                else
                {
                    MessageBox.Show("Id Supplier harus terdiri dari 2 karakter.", "Kesalahan");
                    textBoxKode.Focus();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pengubahan gagal. Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKode.Text = textBoxNama.Text = textBoxAlamat.Text = "";
            textBoxKode.Enabled = true;
            textBoxNama.Enabled = textBoxAlamat.Enabled = false;
            textBoxKode.Focus();
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxKode.Text.Length == 2)
                {
                    listSupplier = Supplier.BacaData("idSUpplier", textBoxKode.Text);
                    if (listSupplier.Count > 0)
                    {
                        textBoxNama.Text = listSupplier[0].Nama;
                        textBoxAlamat.Text = listSupplier[0].Alamat;
                        textBoxKode.Enabled = false;
                        textBoxNama.Enabled = textBoxAlamat.Enabled = true;
                        textBoxNama.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Id Supplier tidak ditemukan.", "Kesalahan");
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
