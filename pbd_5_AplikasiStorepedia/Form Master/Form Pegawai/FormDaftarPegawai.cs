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
    public partial class FormDaftarPegawai : Form
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

        List<Pegawai> listPegawai = new List<Pegawai>();
        public FormDaftarPegawai()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewPegawai.Columns.Clear();

            dataGridViewPegawai.Columns.Add("IdPegawai", "Id Pegawai");
            dataGridViewPegawai.Columns.Add("NamaPeg", "Nama Pegawai");
            dataGridViewPegawai.Columns.Add("NamaPang", "Nama Panggilan");
            dataGridViewPegawai.Columns.Add("TglLahir", "Tgl Lahir");
            dataGridViewPegawai.Columns.Add("Email", "Email");
            dataGridViewPegawai.Columns.Add("Alamat", "Alamat");
            dataGridViewPegawai.Columns.Add("Gaji", "Gaji");
            dataGridViewPegawai.Columns.Add("Username", "Username");
            dataGridViewPegawai.Columns.Add("NamaJab", "Nama Jabatan");


            dataGridViewPegawai.Columns["IdPegawai"].AutoSizeMode =
            dataGridViewPegawai.Columns["NamaPeg"].AutoSizeMode =
            dataGridViewPegawai.Columns["NamaPang"].AutoSizeMode =
            dataGridViewPegawai.Columns["TglLahir"].AutoSizeMode =
            dataGridViewPegawai.Columns["Email"].AutoSizeMode =
            dataGridViewPegawai.Columns["Alamat"].AutoSizeMode =
            dataGridViewPegawai.Columns["Gaji"].AutoSizeMode =
            dataGridViewPegawai.Columns["Username"].AutoSizeMode =
            dataGridViewPegawai.Columns["NamaJab"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewPegawai.Columns["Gaji"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewPegawai.Columns["Gaji"].DefaultCellStyle.Format = "#,###";
        }

        private void TampilDataGrid()
        {
            try
            {
                dataGridViewPegawai.Rows.Clear();
                foreach (Pegawai p in listPegawai)
                {
                    dataGridViewPegawai.Rows.Add(p.IdPegawai, p.Nama, p.NamaPanggilan, p.TglLahir.ToString("yyyy-MM-dd"), p.Email, p.Alamat, p.Gaji, p.Username, p.Jabatan.Nama);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void FormDaftarPegawai_Load(object sender, EventArgs e)
        {
            try
            {
                listPegawai = Pegawai.BacaData("", "");

                if (sender is FormDaftarPegawai)
                    FormatDataGrid();

                if (listPegawai.Count > 0)
                {
                    TampilDataGrid();
                }
                else
                {
                    dataGridViewPegawai.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPegawai formTambahPegawai = new FormTambahPegawai()
            {
                Owner = this
            };
            formTambahPegawai.ShowDialog();
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPegawai formUbahPegawai = new FormUbahPegawai()
            {
                Owner = this
            };
            formUbahPegawai.ShowDialog();
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPegawai formHapusPegawai = new FormHapusPegawai()
            {
                Owner = this
            };
            formHapusPegawai.ShowDialog();
        }

        private void TextBoxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCari.SelectedIndex != -1)
                {
                    string kriteria = "";
                    switch (comboBoxCari.Text)
                    {
                        case "Id Pegawai":
                            kriteria = "peg.IdPegawai";
                            break;
                        case "Nama":
                            kriteria = "peg.Nama";
                            break;
                        case "Nama Panggilan":
                            kriteria = "peg.NamaPanggilan";
                            break;
                        case "Tgl Lahir":
                            kriteria = "peg.TglLahir";
                            break;
                        case "Email":
                            kriteria = "peg.Email";
                            break;
                        case "Alamat":
                            kriteria = "peg.Alamat";
                            break;
                        case "Gaji":
                            kriteria = "peg.Gaji";
                            break;
                        case "Username":
                            kriteria = "peg.Username";
                            break;
                        case "Nama Jabatan":
                            kriteria = "j.Nama";
                            break;
                    }

                    listPegawai = Pegawai.BacaData(kriteria, textBoxCari.Text);

                    TampilDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
