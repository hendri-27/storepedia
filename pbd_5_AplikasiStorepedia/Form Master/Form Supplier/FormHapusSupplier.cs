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
    public partial class FormHapusSupplier : Form
    {
        FormDaftarSupplier formDaftarSupplier;
        List<Supplier> listSupplier = new List<Supplier>();
        public FormHapusSupplier()
        {
            InitializeComponent();
        }

        private void FormHapusSupplier_Load(object sender, EventArgs e)
        {
            formDaftarSupplier = (FormDaftarSupplier)this.Owner;
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxKode.Text) && textBoxKode.TextLength == 2)
                {
                    if (Barang.BacaData("b.IdMerek", listSupplier[0].IdSupplier).Count > 0)
                    {
                        MessageBox.Show($"Supplier {listSupplier[0].Nama} sedang dipakai di tabel Barang.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ButtonKosongi_Click(e, e);
                        return;
                    }

                    if (MessageBox.Show($"Id: {textBoxKode.Text}\nNama: {textBoxNama.Text}\nAlamat: {textBoxAlamat.Text}\nData Supplier berikut akan terhapus. Apakah Anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Supplier.HapusData(listSupplier[0]);

                        MessageBox.Show("Data Supplier berhasil dihapus.", "Info");

                        formDaftarSupplier.FormDaftarSupplier_Load(buttonHapus, e);

                        ButtonKosongi_Click(e, e);
                    }
                    else
                        MessageBox.Show("Penghapusan dibatalkan.", "Info");
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
            textBoxKode.Text = textBoxNama.Text = textBoxAlamat.Text = "";
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
