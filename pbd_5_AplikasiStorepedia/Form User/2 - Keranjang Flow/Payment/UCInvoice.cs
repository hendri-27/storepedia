using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCInvoice : UserControl
    {
        public UCInvoice()
        {
            InitializeComponent();
        }

        public UCPayment ucPayment;

        public long SubTotalProduk
        {
            set
            {
                labelSubProduk.Text = "Rp " + value.ToString("N0");
            }
        }

        public int OngkosKirim
        {
            set
            {
                labelHargaPengiriman.Text = "Rp " + value.ToString("N0");
            }
        }

        private void ButtonMetodeBayar_TextChanged(object sender, EventArgs e)
        {
            if (buttonMetodeBayar.Text != "Pilih Metode Pembayaran")
            {
                ucPayment.buttonBuatPesanan.Enabled = true;
            }    
        }

        private void ButtonMetodeBayar_Click(object sender, EventArgs e)
        {
            FormMetodeBayar metodeBayar = new FormMetodeBayar();
            metodeBayar.ShowDialog();
        }
    }
}
