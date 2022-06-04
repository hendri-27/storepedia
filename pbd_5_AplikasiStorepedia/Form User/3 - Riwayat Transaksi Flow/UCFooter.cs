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
    public partial class UCFooter : UserControl
    {
        public UCFooter()
        {
            InitializeComponent();
        }

        public int Jumlah
        {
            set
            {
                labelJumlah.Text = value.ToString("N0") + " produk";
            }
        }

        public long TotalPembayaran
        {
            set
            {
                string pad = "21";
                if (value.ToString().Length <= 4)
                    pad = "10";
                labelTotalPembayaran.Text = $"<div style='padding-top: {pad}px;'>Total Pembayaran: &nbsp;<span style='color: #8B0000;'><b>Rp{value:N0}</b></span></div>";
            }
        }
    }
}
