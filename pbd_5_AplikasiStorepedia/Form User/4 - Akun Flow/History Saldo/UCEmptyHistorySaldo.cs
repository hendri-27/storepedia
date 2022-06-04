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
    public partial class UCEmptyHistorySaldo : UserControl
    {
        public UCEmptyHistorySaldo()
        {
            InitializeComponent();
        }

        private void ButtonBelanja_Click(object sender, EventArgs e)
        {
            FormUserUtama.formUserUtama.ButtonBeranda_Click(this, e);
        }
    }
}
