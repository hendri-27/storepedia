using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormDetailBarang : Form
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

        public FormDetailBarang()
        {
            InitializeComponent();
        }

        public Barang brg;

        private void FormDetailBarang_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormUserUtama.p.ListFavorit.Any(f => f.IdBarang == brg.IdBarang))
                {
                    buttonFavorit.Image = Properties.Resources.heart_solid;
                    buttonFavorit.Tag = "on";
                }
                MemoryStream ms = new MemoryStream(brg.Gambar);
                gambarBarang.Image = Image.FromStream(ms);
                ms.Dispose();
                labelNamaBrg.Text = brg.NamaBarang;
                labelHarga.Text = "Rp" + brg.Harga.ToString("n0");
                labelStok.Text = brg.Stok.ToString();
                labelNamaMerek.Text = brg.Supplier.Nama;
                labelDeskripsi.Text = brg.Deskripsi;
                labelTotalTerjual.Text = DetilNotaJual.JumlahTerjual(brg.IdBarang);
                if (brg.Stok == 0)
                {
                    buttonBeliSekarang.Text = "Stok Habis";
                    buttonBeliSekarang.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonFavorit_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (buttonFavorit.Tag.ToString() == "off")
                {
                    buttonFavorit.Image = Properties.Resources.heart_solid;
                    buttonFavorit.Tag = "on";
                    FormUserUtama.p.TambahFavorit(brg);
                }
                else
                {
                    buttonFavorit.Image = Properties.Resources.heart_regular;
                    buttonFavorit.Tag = "off";
                    FormUserUtama.p.HapusFavorit(brg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(49, 50, 111);
        }

        private void ButtonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(31, 32, 71);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBeliSekarang_Click(object sender, EventArgs e)
        {
            try
            {
                TambahKeranjang keranjang = new TambahKeranjang()
                {
                    Location = new Point(0, 380)
                };
                InvisiblePanel invisiblePanel = new InvisiblePanel()
                {
                    Dock = DockStyle.Fill,
                    Opacity = 60,
                    BackColor = Color.DarkGray
                };
                invisiblePanel.Click += ClosingControl;
                this.Controls.Add(invisiblePanel);
                invisiblePanel.BringToFront();
                this.Controls.Add(keranjang);
                keranjang.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void ClosingControl(object sender, EventArgs e)
        {
            this.Controls.RemoveAt(1);
            this.Controls.RemoveAt(0);
        }

        public void AddToCart(int jumlah)
        {
            try
            {
                int idx = -1;

                for (int i = 0; i < FormUserUtama.p.ListCart.Count; i++)
                {
                    if (FormUserUtama.p.ListCart[i].IdBarang == brg.IdBarang)
                    {
                        idx = i;
                        break;
                    }
                }

                if (FormUserUtama.p.ListCart.Count == 0 || idx == -1)
                {
                    Barang b = new Barang(brg);
                    FormUserUtama.p.TambahCart(b, jumlah);
                }
                else
                {
                    if (FormUserUtama.p.ListCart[idx].IdBarang == brg.IdBarang && FormUserUtama.p.ListCart[idx].Stok + jumlah <= brg.Stok)
                    {
                        FormUserUtama.p.ListCart[idx].Stok += jumlah;
                    }
                    else
                    {
                        MessageBox.Show("Pembelian tidak dapat dilakukan\nkarena jumlah produk pembelian melebihi stok.", "Kesalahan");
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
