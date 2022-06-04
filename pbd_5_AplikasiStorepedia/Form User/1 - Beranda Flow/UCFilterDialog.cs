using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FilterDialog : UserControl
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

        public FilterDialog()
        {
            InitializeComponent();
        }

        private void FilterDialog_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxKategori.DataSource = Kategori.BacaData("", "");
                comboBoxKategori.DisplayMember = "Nama";

                comboBoxMerek.DataSource = Supplier.BacaData("", "");
                comboBoxMerek.DisplayMember = "Nama";

                comboBoxKategori.SelectedIndex = comboBoxMerek.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonHarga1_Click(object sender, EventArgs e)
        {
            textBoxMin.Text = "0";
            textBoxMax.Text = "200000";
        }

        private void ButtonHarga2_Click(object sender, EventArgs e)
        {
            textBoxMin.Text = "200000";
            textBoxMax.Text = "1500000";
        }

        private void ButtonHarga3_Click(object sender, EventArgs e)
        {
            textBoxMin.Text = "1500000";
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMin.Text == "")
                {
                    textBoxMin.Text = "0";
                }
                FormBeranda.min = textBoxMin.Text;
                FormBeranda.max = textBoxMax.Text;
                FormBeranda.kategori = comboBoxKategori.Text;
                FormBeranda.merek = comboBoxMerek.Text;
                FormUserUtama.buttonFilter = true;
                ButtonClose_Click(e, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            ((FormUserUtama)ParentForm).Controls.RemoveAt(1);
            ((FormUserUtama)ParentForm).Repainting(false);
            ((FormUserUtama)ParentForm).Controls.RemoveAt(0);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
