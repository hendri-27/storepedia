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
    public partial class UCHeader : UserControl
    {
        public UCHeader()
        {
            InitializeComponent();
        }

        public string NoNota
        {
            set
            {
                labelNoNota.Text = value;
            }
        }

        public DateTime TglTransaksi
        {
            set
            {
                labelTglTransaksi.Text = value.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
    }
}
