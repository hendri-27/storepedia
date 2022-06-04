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
    public partial class UCInformasiBayar : UserControl
    {
        public UCInformasiBayar()
        {
            InitializeComponent();
        }

        public string TotalPesanan
        {
            set
            {
                labelTotalPesanan.Text = value;
            }
        }
    }
}
