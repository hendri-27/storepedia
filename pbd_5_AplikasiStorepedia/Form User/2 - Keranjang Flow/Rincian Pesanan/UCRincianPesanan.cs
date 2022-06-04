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
using System.Linq.Expressions;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCRincianPesanan : UserControl
    {
        public NotaJual nota;
        public long subTotal;

        public UCRincianPesanan()
        {
            InitializeComponent();
        }

        private void UCRincianPesanan_Load(object sender, EventArgs e)
        {
            try
            {
                UCInformasiBayar informasiBayar = new UCInformasiBayar()
                {
                    TotalPesanan = "Rp " + (subTotal + nota.OngkosKirim).ToString("N0")
                };
                flowLayoutRincian.Controls.Add(informasiBayar);

                UCMetodeBayar metodeBayar = new UCMetodeBayar()
                {
                    MetodeBayar = nota.TipePembayaran
                };
                flowLayoutRincian.Controls.Add(metodeBayar);

                flowLayoutRincian.Controls.Add(new UCHeaderBarang());
                foreach (DetilNotaJual detilNotaJual in nota.ListDetilNotaJual)
                {
                    UCDetailInvoice dInvoice = new UCDetailInvoice()
                    {
                        NamaBarang = detilNotaJual.Barang.NamaBarang,
                        HargaBarang = detilNotaJual.Harga,
                        JumlahBarang = detilNotaJual.Jumlah,
                        SubTotal = detilNotaJual.Jumlah * detilNotaJual.Harga
                    };
                    flowLayoutRincian.Controls.Add(dInvoice);
                }

                UCRincianLain rincianLain = new UCRincianLain()
                {
                    OngkosKirim = "Rp " + nota.OngkosKirim.ToString("N0")
                };
                flowLayoutRincian.Controls.Add(rincianLain);

                UCAlamat alamat = new UCAlamat()
                {
                    Profil = $"{FormUserUtama.p.Nama} ({FormUserUtama.p.NoTelp})",
                    Alamat = FormUserUtama.p.Alamat
                };
                alamat.labelUbah.Visible = false;
                flowLayoutRincian.Controls.Add(alamat);

                UCPesanan pesanan = new UCPesanan()
                {
                    NomorPesanan = nota.NoNota,
                    WaktuPesan = nota.Tanggal.ToString("yyyy-MM-dd HH:mm:ss")
                };
                flowLayoutRincian.Controls.Add(pesanan);

                UCRincianPesanan_Resize(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (ParentForm is FormRiwayatTransaksi riwayatTransaksi)
            {
                riwayatTransaksi.rincianPesanan = null;
                this.Dispose();
            }
            else
                FormUserUtama.formUserUtama.ButtonRiwayat_Click(this, e);
        }

        private void ButtonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(49, 50, 111);
        }

        private void ButtonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(31, 32, 71);
        }

        private void UCRincianPesanan_Resize(object sender, EventArgs e)
        {
            flowLayoutRincian.SuspendLayout();
            foreach (Control ctrl in flowLayoutRincian.Controls)
            {
                ctrl.Width = flowLayoutRincian.ClientSize.Width;
            }
            flowLayoutRincian.ResumeLayout();
        }

        public void DisplayNotaJual(NotaJual notaJual)
        {
            nota = notaJual;
            subTotal = 0;

            foreach (DetilNotaJual detilNota in notaJual.ListDetilNotaJual)
            {
                subTotal += detilNota.Jumlah * detilNota.Harga;
            }
        }
    }
}
