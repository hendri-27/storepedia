using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH : mm : ss");
            labelDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH : mm : ss");
            labelDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }
    }
}
