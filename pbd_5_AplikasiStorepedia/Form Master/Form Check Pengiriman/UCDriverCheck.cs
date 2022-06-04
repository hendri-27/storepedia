using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCDriverCheck : UserControl
    {
        public Pengiriman peng;

        public UCDriverCheck()
        {
            InitializeComponent();
        }
        
        public string NoNota
        {
            get => labelNoNota.Text;
            set => labelNoNota.Text = value;
        }

        public string Alamat
        {
            get => textBoxAlamat.Text;
            set => textBoxAlamat.Text = value;
        }

        public bool SudahDikirim
        {
            get => checkBoxSudahDikirim.Checked;
            set => checkBoxSudahDikirim.Checked = value;
        }

        private void UCDriverCheck_Load(object sender, EventArgs e)
        {
            checkBoxSudahDikirim.CheckedChanged += CheckBoxSudahDikirim_CheckedChanged;
        }

        private void CheckBoxSudahDikirim_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string status = "";
                DateTime date = DateTime.MinValue;
                if (checkBoxSudahDikirim.Checked)
                {
                    status = "sudah";
                    date = DateTime.Now;
                }
                Pengiriman.UbahData(new Pengiriman(peng.Nota, peng.Pegawai, date, status));

                FormMessageBox.ShowBox("Update Pengiriman Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan kesalahan: {ex.Message}", "Kesalahan");
            }
        }
    }
}
