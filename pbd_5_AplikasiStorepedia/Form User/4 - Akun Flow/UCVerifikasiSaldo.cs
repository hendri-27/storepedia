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
using System.IO;
using Guna.UI2.WinForms.Suite;
using Guna.UI2.WinForms;
using System.Transactions;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCVerifikasiSaldo : UserControl
    {
        public long nominal;
        string pathBukti;
        InvisiblePanel invisiblePan;
        UCContohGambar contoh;

        public UCVerifikasiSaldo()
        {
            InitializeComponent();
            this.flowLayoutPanelVerifikasi.AutoScroll = true;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ((UCTambahSaldo)Parent).Resize -= ((UCTambahSaldo)Parent).UCTambahSaldo_Resize;
            this.Dispose();
        }

        private void UCVerifikasiSaldo_Load(object sender, EventArgs e)
        {
            try
            {
                labelUsername.Text = FormUserUtama.p.Nama;
                labelJumlah.Text = labelTotalBayar.Text = $"Rp {nominal:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void PictureBoxBukti_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog() { Filter = "JPEG files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png" })
            {
                try
                {
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        pathBukti = file.FileName;
                        pictureBoxBukti.Image = Image.FromFile(file.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
                }
            }
        }

        private void ButtonBayar_Click(object sender, EventArgs e)
        {
            using (TransactionScope transScope = new TransactionScope())
            {
                try
                {
                    if (pathBukti != null)
                    {
                        if (!Check())
                        {
                            byte[] foto = File.ReadAllBytes(@pathBukti);
                            BuktiTransaksi bukti = new BuktiTransaksi(BuktiTransaksi.GenerateKode(), textBoxNamaPemilik.Text, textBoxNoRekening.Text, textBoxDariBank.Text, textBoxKeBank.Text,foto);
                            BuktiTransaksi.TambahData(bukti);
                            FormUserUtama.p.TambahSaldo(nominal, bukti);

                            this.Dispose();
                            FormAkun.akun.FormAkun_Load(sender, e);
                            FormAkun.ucActive.Dispose();
                            FormAkun.ucActive = null;

                            FormMessageBox.ShowBox("Isi Saldo Berhasil");
                            transScope.Complete();
                        }
                    }
                    else if (pathBukti == null)
                        FormMessageBox.ShowBox("Foto Bukti Belum Terupload");
                }
                catch (Exception ex)
                {
                    transScope.Dispose();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool Check()
        {
            bool status = false;
            foreach (Control c in panelVerifikasi.Controls)
            {
                if (c is Guna2TextBox tb)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        tb.BorderColor = Color.Red;
                        status = true;
                        FormMessageBox.ShowBox("Semua Data harus diisi");
                        break;
                    }
                }
            }
            return status;
        }

        private void EnterTextBox (object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (tb.BorderColor == Color.Red)
                tb.BorderColor = Color.Black;
        }

        private void UCVerifikasiSaldo_Resize(object sender, EventArgs e)
        {
            panelVerifikasi.Width = flowLayoutPanelVerifikasi.ClientSize.Width;
            if (contoh != null)
            {
                contoh.Location = new Point((FormUserUtama.formUserUtama.Width - 526) / 2, (FormUserUtama.formUserUtama.Height - 409) / 2);
            }
        }

        private void ButtonContoh_Click(object sender, EventArgs e)
        {
            contoh = new UCContohGambar()
            {
                Location = new Point((FormUserUtama.formUserUtama.Width- 526) /2, (FormUserUtama.formUserUtama.Height - 409) / 2)
            };
            FormUserUtama.formUserUtama.Controls.Add(contoh);
            contoh.BringToFront();

            invisiblePan = new InvisiblePanel()
            {
                Dock = DockStyle.Fill
            };
            invisiblePan.Click += CustomClosing;
            FormUserUtama.formUserUtama.Controls.Add(invisiblePan);
            invisiblePan.BringToFront();
        }

        public void CustomClosing(object sender, EventArgs e)
        {
            try
            {
                FormUserUtama.formUserUtama.Controls.Remove(invisiblePan);
                FormUserUtama.formUserUtama.Controls.Remove(contoh);
                contoh = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(49, 50, 111);
        }

        private void ButtonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.FromArgb(31, 32, 71);
        }

        private void TextBoxNoRekening_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
