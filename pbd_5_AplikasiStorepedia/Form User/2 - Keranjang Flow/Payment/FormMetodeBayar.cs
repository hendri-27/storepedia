using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormMetodeBayar : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public FormMetodeBayar()
        {
            InitializeComponent();

            foreach (Control c in Controls)
            {
                if (c is RadioButton rdo)
                {
                    if (rdo.Text == UCPayment.invoice.buttonMetodeBayar.Text)
                    {
                        rdo.Checked = true;
                        break;
                    }
                }

            }
           // this.ActiveControl = null;
        }

        private void RadioChecked(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonStorepediaPay.Checked)
                    UCPayment.invoice.buttonMetodeBayar.Text = radioButtonStorepediaPay.Text;
                else
                    return;
                panelSimpan.Visible = false;
                buttonSimpan.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            //this.ActiveControl = null;
            this.Close();
        }
    }
}
