using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using class_Storepedia;
using System.Transactions;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCPayment : UserControl
    {
        public static UCInvoice invoice;
        int ongkos;

        public UCPayment()
        {
            InitializeComponent();
        }

        private void UCPayment_Load(object sender, EventArgs e)
        {
            try
            {
                UCAlamat alamat = new UCAlamat()
                {
                    Profil = $"{FormUserUtama.p.Nama} ({FormUserUtama.p.NoTelp})",
                    Alamat = FormUserUtama.p.Alamat
                };
                flowLayoutPanelDetail.Controls.Add(alamat);
                flowLayoutPanelDetail.Controls.Add(new UCHeaderBarang());
                foreach (Barang b in UCNotEmptyCart.listCheckOut)
                {
                    UCDetailInvoice dInvoice = new UCDetailInvoice()
                    {
                        NamaBarang = b.NamaBarang,
                        HargaBarang = b.Harga,
                        JumlahBarang = b.Stok,
                        SubTotal = b.Stok * b.Harga
                    };

                    flowLayoutPanelDetail.Controls.Add(dInvoice);
                }

                int ongkosKirim = (int)(0.01 * UCNotEmptyCart.subTotal);
                ongkos = ongkosKirim;
                invoice = new UCInvoice()
                {
                    SubTotalProduk = UCNotEmptyCart.subTotal,
                    OngkosKirim = ongkosKirim,
                    ucPayment = this
                };
                flowLayoutPanelDetail.Controls.Add(invoice);
                labelTotalHarga.Text = "Rp " + (UCNotEmptyCart.subTotal + ongkosKirim).ToString("N0");
                UCPayment_Resize(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void UCPayment_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelDetail.SuspendLayout();
            foreach (Control ctrl in flowLayoutPanelDetail.Controls)
            {
                ctrl.Width = flowLayoutPanelDetail.ClientSize.Width;
            }
            flowLayoutPanelDetail.ResumeLayout();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ((FormKeranjang)ParentForm).Resize -= ((FormKeranjang)ParentForm).FormKeranjang_Resize;
            this.Dispose();
        }

        private void ButtonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(49, 50, 111);
        }

        private void ButtonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(31, 32, 71);
        }
        
        private void ButtonBuatPesanan_Click(object sender, EventArgs e)
        {
            using (TransactionScope transScope = new TransactionScope())
            {
                try
                {
                    DateTime tanggal = DateTime.Now;
                    string noNota = NotaJual.GenerateNoNota(tanggal);
                    NotaJual nota = new NotaJual(noNota, tanggal, ongkos, invoice.buttonMetodeBayar.Text, FormUserUtama.p);
                    long subTotal = 0;

                    for (int i = 0; i < UCNotEmptyCart.listCheckOut.Count; i++)
                    {
                        subTotal += UCNotEmptyCart.listCheckOut[i].Harga * UCNotEmptyCart.listCheckOut[i].Stok;
                        nota.TambahDetilNotaJual(UCNotEmptyCart.listCheckOut[i], UCNotEmptyCart.listCheckOut[i].Harga, UCNotEmptyCart.listCheckOut[i].Stok);

                    }
                    FormUserUtama.p.MengurangiSaldo(subTotal + nota.OngkosKirim);
                    foreach (Barang brg in UCNotEmptyCart.listCheckOut)
                    {
                        FormUserUtama.p.ListCart.Remove(brg);
                        FormUserUtama.p.HapusCart(brg);
                    }
                    NotaJual.TambahData(nota);

                    this.Dispose();
                    FormKeranjang.formKeranjang.payment = null;
                    FormKeranjang.formKeranjang.CreateRincian(nota, subTotal);
                    transScope.Complete();
                    FormMessageBox.ShowBox("Pembayaran berhasil!");
                }
                catch (Exception ex)
                {
                    transScope.Dispose();
                    MessageBox.Show($"Pembayaran gagal. Pesan kesalahan: {ex.Message}");
                }
            }
        }
    }
}
