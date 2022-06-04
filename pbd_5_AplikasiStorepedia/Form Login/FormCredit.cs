using Guna.UI2.WinForms;
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
    public partial class FormCredit : Form
    {
        public FormCredit()
        {
            InitializeComponent();
        }

        private void labelGuna_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gunaframework.com/");
        }

        private void labelFontAwesome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://fontawesome.com/");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MouseEnterEvent(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Aquamarine;
        }

        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.White;
        }

        private void MouseEntering(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(61, 56, 132);
        }

        private void MouseLeaving(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(22, 20, 52);
        }
    }
}
