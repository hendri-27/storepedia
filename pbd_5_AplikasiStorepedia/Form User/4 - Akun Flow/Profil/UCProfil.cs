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
    public partial class UCProfil : UserControl
    {

        public UCProfil()
        {
            InitializeComponent();
        }

        private void UCProfil_Load(object sender, EventArgs e)
        {
            try
            {
                labelNamaLengkap.Text = FormUserUtama.p.Nama;
                labelNamaPanggil.Text = FormUserUtama.p.NamaPanggilan;
                labelUsername.Text = FormUserUtama.p.Username;
                labelTglLahir.Text = FormUserUtama.p.TglLahir.ToString("dd-MM-yyyy");
                labelHandphone.Text = $"*****{FormUserUtama.p.NoTelp.Substring(FormUserUtama.p.NoTelp.Length - 2)}";
                labelEmail.Text = FormUserUtama.p.Email.Substring(0, 2) + "*****" + FormUserUtama.p.Email.Substring(FormUserUtama.p.Email.IndexOf('@'));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ((FormAkun)ParentForm).Resize -= ((FormAkun)ParentForm).FormAkun_Resize;
            this.Dispose();
        }

        private void ButtonNamaLengkap_Click(object sender, EventArgs e)
        {
            FormNamaLengkap namaLengkap = new FormNamaLengkap()
            {
                uCProfil = this
            };
            namaLengkap.ShowDialog();
        }

        private void ButtonNamaPanggil_Click(object sender, EventArgs e)
        {
            FormNamaPanggil namaPanggil = new FormNamaPanggil()
            {
                uCProfil = this
            };
            namaPanggil.ShowDialog();
        }

        private void ButtonTglLahir_Click(object sender, EventArgs e)
        {
            FormTglLahir tglLahir = new FormTglLahir()
            {
                uCProfil = this
            };
            tglLahir.ShowDialog();
        }

        private void ButtonAlamat_Click(object sender, EventArgs e)
        {
            FormAlamat alamat = new FormAlamat();
            alamat.ShowDialog();
        }

        private void ButtonHandphone_Click(object sender, EventArgs e)
        {
            FormHandphone handphone = new FormHandphone()
            {
                uCProfil = this
            };
            handphone.ShowDialog();
        }

        private void ButtonEmail_Click(object sender, EventArgs e)
        {
            FormVerifikasiPass email = new FormVerifikasiPass()
            {
                uCProfil = this,
                parentIsEmail = true
            };           
            email.ShowDialog();
        }

        private void ButtonUbahPass_Click(object sender, EventArgs e)
        {
            FormVerifikasiPass ubahPass = new FormVerifikasiPass()
            {
                parentIsEmail = false
            };
            ubahPass.ShowDialog();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(49, 50, 111);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(31, 32, 71);
        }
    }
}
