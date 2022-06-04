using class_Storepedia;
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
    public partial class FormTglLahir : Form
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
        public UCProfil uCProfil;

        public FormTglLahir()
        {
            InitializeComponent();
        }
        
        private void FormTglLahir_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePickerTglLahir.Value = FormUserUtama.p.TglLahir;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                uCProfil.labelTglLahir.Text = dateTimePickerTglLahir.Value.ToString("dd-MM-yyyy");
                FormUserUtama.p.TglLahir = dateTimePickerTglLahir.Value;
                Pelanggan.UbahData(FormUserUtama.p);
                FormMessageBox.ShowBox("Tanggal Lahir berhasil diubah");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateTimePickerTglLahir_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePickerTglLahir.Value != FormUserUtama.p.TglLahir)
                {
                    panelSimpan.Visible = false;
                    buttonSimpan.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(49, 50, 111);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(31, 32, 71);
        }
    }
}
