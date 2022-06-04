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
    public partial class FormDaftarSupplier : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        List<Supplier> listSupplier = new List<Supplier>();
        public FormDaftarSupplier()
        {
            InitializeComponent();
        }

        public void FormDaftarSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                listSupplier = Supplier.BacaData("", "");

                if (listSupplier.Count > 0)
                {
                    dataGridViewSupplier.DataSource = listSupplier;
                    dataGridViewSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {
                    dataGridViewSupplier.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahSupplier formTambahSupplier = new FormTambahSupplier()
            {
                Owner = this
            };
            formTambahSupplier.ShowDialog();
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            FormUbahSupplier formUbahSupplier = new FormUbahSupplier()
            {
                Owner = this
            };
            formUbahSupplier.ShowDialog();
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            FormHapusSupplier formHapusSupplier = new FormHapusSupplier()
            {
                Owner = this
            };
            formHapusSupplier.ShowDialog();
        }

        private void TextBoxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCari.SelectedIndex != -1)
                {
                    string kriteria = "idSupplier";
                    if (comboBoxCari.Text == "Nama")
                    {
                        kriteria = "nama";
                    }
                    else if (comboBoxCari.Text == "Alamat")
                    {
                        kriteria = "alamat";
                    }
                    listSupplier = Supplier.BacaData(kriteria, textBoxCari.Text);


                    if (listSupplier.Count > 0)
                    {
                        dataGridViewSupplier.DataSource = listSupplier;
                    }
                    else
                    {
                        dataGridViewSupplier.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
