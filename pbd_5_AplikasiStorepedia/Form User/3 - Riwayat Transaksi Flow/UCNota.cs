using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_Storepedia;
using System.IO;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCNota : UserControl
    {
        public NotaJual nota;

        public UCNota()
        {
            InitializeComponent();
        }

        private void UCNota_Load(object sender, EventArgs e)
        {
            try
            {
                int jumlah = 0, n = nota.ListDetilNotaJual.Count;
                long total = 0;

                UCHeader header = new UCHeader()
                {
                    NoNota = nota.NoNota,
                    TglTransaksi = nota.Tanggal
                };
                flowLayoutPanelDetil.Controls.Add(header);

                foreach (DetilNotaJual detilNota in nota.ListDetilNotaJual)
                {
                    using (MemoryStream ms = new MemoryStream(detilNota.Barang.Gambar))
                    {
                        UCDetilNota ucDetilNota = new UCDetilNota()
                        {
                            Gambar = Image.FromStream(ms),
                            NamaBarang = detilNota.Barang.NamaBarang,
                            Harga = detilNota.Harga,
                            Jumlah = detilNota.Jumlah
                        };
                        flowLayoutPanelDetil.Controls.Add(ucDetilNota);
                    }
                    total += detilNota.Jumlah * detilNota.Harga;
                    jumlah += detilNota.Jumlah;
                }

                UCFooter footer = new UCFooter()
                {
                    TotalPembayaran = total,
                    Jumlah = jumlah
                };
                flowLayoutPanelDetil.Controls.Add(footer);

                this.Height += 108 * (n - 1);
                UCNota_Resize(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void UCNota_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelDetil.SuspendLayout();
            foreach (Control ctrl in flowLayoutPanelDetil.Controls)
            {
                ctrl.Width = flowLayoutPanelDetil.ClientSize.Width;
            }
            flowLayoutPanelDetil.ResumeLayout();
        }

        private void InvisiblePanel_Click(object sender, EventArgs e)
        {
            try
            {
                UCRincianPesanan rincianPesanan = FormRiwayatTransaksi.riwayatTransaksi.rincianPesanan = new UCRincianPesanan();
                rincianPesanan.DisplayNotaJual(nota);

                FormRiwayatTransaksi.riwayatTransaksi.Controls.Add(rincianPesanan);
                rincianPesanan.BringToFront();

                FormRiwayatTransaksi.riwayatTransaksi.FormRiwayatTransaksi_Resize(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
