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
    public partial class UCDetailInvoice : UserControl
    {
        public UCDetailInvoice()
        {
            InitializeComponent();
        }

        public string NamaBarang
        {
            set
            {
                labelNamaBarang.Text = value;
            }
        }

        public long HargaBarang
        {
            set
            {
                labelHarga.Text = "Rp " + value.ToString("N0");
            }
        }

        public int JumlahBarang
        {
            set
            {
                labelJumlah.Text = "x" + value.ToString("N0");
            }
        }

        public long SubTotal
        {
            set
            {
                labelSubTotal.Text = "Rp " + value.ToString("N0");
            }
        }
    }
}
