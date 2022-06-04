using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormAkun : Form
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

        public static FormAkun akun;

        public static UserControl ucActive;

        public FormAkun()
        {
            InitializeComponent();
            akun = this;
        }

        public void FormAkun_Resize(object sender, EventArgs e)
        {
            ucActive.Width = ClientSize.Width;
            ucActive.Height = ClientSize.Height;
        }

        private void ButtonIsiSaldo_Click(object sender, EventArgs e)
        {
            ucActive = new UCTambahSaldo();
            CreateUserControl(sender, e);
        }

        private void ButtonProfil_Click(object sender, EventArgs e)
        {
            ucActive = new UCProfil();
            CreateUserControl(sender, e);
        }

        private void ButtonFavorit_Click(object sender, EventArgs e)
        {
            ucActive = new UCFavorit();
            CreateUserControl(sender, e);
        }

        private void CreateUserControl(object sender, EventArgs e)
        {
            this.Resize += FormAkun_Resize;
            this.Controls.Add(ucActive);
            ucActive.BringToFront();
            FormAkun_Resize(sender, e);
        }

        public void FormAkun_Load(object sender, EventArgs e)
        {
            try
            {
                labelSaldo.Text = $"Rp {FormUserUtama.p.Saldo:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonHistorySaldo_Click(object sender, EventArgs e)
        {
            try
            {
                ucActive = new UCHistorySaldo();
                CreateUserControl(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
