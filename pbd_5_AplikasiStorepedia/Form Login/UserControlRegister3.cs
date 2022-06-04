using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UserControlRegister3 : UserControl
    {
        string email, notlp, username, pass;
        public UserControlRegister3()
        {
            InitializeComponent();

            labelKembali.MouseUp += LabelKembali_MouseLeave;
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxNama_Leave(sender, e);
                TextBoxNamaPanggilan_Leave(sender, e);
                TextBoxAlamat_Leave(sender, e);
                if (labelNama.BackColor == Color.Green && labelNamaPanggilan.BackColor == Color.Green && labelAlamat.BackColor == Color.Green)
                {
                    Pelanggan.TambahData(new Pelanggan(Pelanggan.GenerateKode(), textBoxNama.Text, textBoxNamaPanggilan.Text, dateTimePickerTglLahir.Value, email, textBoxAlamat.Text, notlp, username, pass, 0));

                    MessageBox.Show("Akun berhasil dibuat.", "Sukses");

                    //Menghapus manual user control sebelumnya di dalam list control collection
                    for(int i = 2; i >= 0; i--)
                    {
                        this.Parent.Controls.RemoveAt(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void LabelKembali_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text != "" || textBoxNamaPanggilan.Text != "" || textBoxAlamat.Text != "")
            {
                if (MessageBox.Show("Anda telah mengisi data registrasi.\nApakah Anda yakin meninggalkan halaman ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            this.Parent.Controls.Remove(this);
        }

        private void LabelKembali_MouseDown(object sender, MouseEventArgs e)
        {
            labelKembali.ForeColor = Color.Crimson;
        }

        private void LabelKembali_MouseEnter(object sender, EventArgs e)
        {
            labelKembali.Font = new Font("Arial", 11.25f, FontStyle.Bold | FontStyle.Underline);
        }

        private void LabelKembali_MouseLeave(object sender, EventArgs e)
        {
            labelKembali.Font = new Font("Arial", 11.25f, FontStyle.Bold);
            labelKembali.ForeColor = Color.FromArgb(20, 30, 54);
        }

        private void TextBoxNama_TextChanged(object sender, EventArgs e)
        {
            Regexp(textBoxNama, labelNama, lblNama, "Nama lengkap harus diisi.");
        }

        private void TextBoxNama_Leave(object sender, EventArgs e)
        {
            if (labelNama.BackColor != Color.Green)
                Regexp(textBoxNama, labelNama, lblNama, "Nama lengkap harus diisi.");
        }

        private void TextBoxNamaPanggilan_TextChanged(object sender, EventArgs e)
        {
            Regexp(@"^(\w{1,10})$", textBoxNamaPanggilan, labelNamaPanggilan, lblNamaPanggilan, "Nama panggilan harus terdiri dari 1-10 karakter.");
        }

        private void TextBoxNamaPanggilan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNamaPanggilan.Text) && labelNamaPanggilan.BackColor != Color.Green)
                Regexp(textBoxNamaPanggilan, labelNamaPanggilan, lblNamaPanggilan, "Nama panggilan harus diisi.");
            else if (labelNamaPanggilan.BackColor != Color.Green)
                Regexp(@"^(\w{1,10})$", textBoxNamaPanggilan, labelNamaPanggilan, lblNamaPanggilan, "Nama panggilan harus terdiri dari 1-10 karakter.");
        }

        private void TextBoxAlamat_TextChanged(object sender, EventArgs e)
        {
            Regexp(textBoxAlamat, labelAlamat, lblAlamat, "Alamat harus diisi.");
        }

        private void TextBoxAlamat_Leave(object sender, EventArgs e)
        {
            if (labelAlamat.BackColor != Color.Green)
                Regexp(textBoxAlamat, labelAlamat, lblAlamat, "Alamat harus diisi.");
        }

        private void ButtonRegister_MouseEnter(object sender, EventArgs e)
        {
            buttonRegister.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void ButtonRegister_MouseLeave(object sender, EventArgs e)
        {
            buttonRegister.BackColor = Color.FromArgb(20, 30, 54);
        }

        private void Regexp(TextBox tb, Label lb, Label msg, string error)
        {
            switch (!string.IsNullOrWhiteSpace(tb.Text))
            {
                case true:
                    lb.BackColor = Color.Green;
                    msg.ForeColor = Color.White;
                    errorProviderRegis.Clear();
                    break;
                default:
                    msg.Text = error;
                    lb.BackColor = msg.ForeColor = Color.Red;
                    errorProviderRegis.SetError(tb, error);
                    break;
            }
        }

        private void Regexp(string rg, TextBox tb, Label lb, Label msg, string error)
        {
            switch (new Regex(rg).IsMatch(tb.Text))
            {
                case true:
                    lb.BackColor = Color.Green;
                    msg.ForeColor = Color.White;
                    errorProviderRegis.Clear();
                    break;
                default:
                    lb.BackColor = msg.ForeColor = Color.Red;
                    errorProviderRegis.SetError(tb, error);
                    break;
            }
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (sender == textBoxNamaPanggilan)
            {
                if (e.KeyChar == 32)
                    e.Handled = true;
            }
            if (e.KeyChar == 9 || e.KeyChar == 13)
                e.Handled = true;
        }

        public void GetValue(string pEmail, string pNotlp, string pUsername, string pPass)
        {
            email = pEmail;
            notlp = pNotlp;
            username = pUsername;
            pass = pPass;
        }
    }
}
