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
    public partial class UCPesanan : UserControl
    {
        public UCPesanan()
        {
            InitializeComponent();
        }

        public string NomorPesanan
        {
            set
            {
                labelNomorPesanan.Text = value;
            }
        }

        public string WaktuPesan
        {
            set
            {
                labelWaktuPesan.Text = value;
            }
        }
    }
}
