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
    public partial class UCDetailSaldo : UserControl
    {
        public UCDetailSaldo()
        {
            InitializeComponent();
        }

        public string TipeTransaksi
        {
            set
            {
                labelTipeTransaksi.Text = value;
            }
        }

        public string NoTransaksi
        {
            set
            {
                labelNoTransaksi.Text = value;
            }
        }

        public DateTime TanggalTransaksi
        {
            set
            {
                labelWaktu.Text = $"{value:dd MMM yyyy - HH:mm}";
            }
        }

        public long Nominal
        {
            set
            {
                labelNominal.Text = labelTipeTransaksi.Text == "Pembayaran" ? $"-Rp {value:N0}" : $"+Rp {value:N0}";
            }
        }
    }
}
