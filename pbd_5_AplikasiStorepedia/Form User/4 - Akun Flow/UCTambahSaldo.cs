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
using Guna.UI2.WinForms.Suite;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCTambahSaldo : UserControl
    {
        bool status; //status false = panelDropDownPilihNom terbuka true = panelDropDownPilihNom tertutup
        int kec = 10;
        Guna2Button prevButton;
        UCVerifikasiSaldo uCVerifikasiSaldo;

        public UCTambahSaldo()
        {
            InitializeComponent();
        }

        private void ButtonClick (object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            btn.Checked = true;
            labelNominal.Text = $"Rp {int.Parse(btn.Tag.ToString()):N0}";
            if (prevButton != null)
                prevButton.Checked = false;
            prevButton = btn;
        }

        private void FlowLayoutPanelPilihan_Resize(object sender, EventArgs e)
        {
            if (!status)
            {
                panelPilihNom.Height = panelDropDownPilihNom.Height + flowLayoutPanelPilihan.Height;
            }

            kec = (flowLayoutPanelPilihan.Height == 140) ? 10 : 5;
        }

        private void ButtonPilihNom_Click(object sender, EventArgs e)
        {
            if (status)
            {
                if (!string.IsNullOrEmpty(textBoxNominalLain.Text))
                {
                    textBoxNominalLain.Text = "";
                    labelNominal.Text = "Rp 0";
                }
                status = false;
                iconNominalLain.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
                panelTextNomLain.Dock = DockStyle.Bottom;
                panelTextNomLain.SendToBack();
                iconPilihNominal.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
                timerAnimation.Start();
            }
        }

        private void ButtonNomLain_Click(object sender, EventArgs e)
        {
            if (!status)
            {
                if (prevButton != null)
                {
                    prevButton.Checked = false;
                    prevButton = null;
                    labelNominal.Text = "Rp 0";
                }
                status = true;
                iconPilihNominal.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
                flowLayoutPanelPilihan.Dock = DockStyle.Bottom;
                flowLayoutPanelPilihan.SendToBack();
                iconNominalLain.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
                timerAnimation.Start();
            }
        }

        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            if (status)
            {
                if (panelPilihNom.Height > 40)
                    panelPilihNom.Height -= kec; // until 40

                if (panelNomLain.Height < 100)
                    panelNomLain.Height += 3; // until 100

                if (panelPilihNom.Height == 40 && panelNomLain.Height == 100)
                {
                    timerAnimation.Stop();
                    panelTextNomLain.BringToFront();
                    panelTextNomLain.Dock = DockStyle.Top;
                    textBoxNominalLain.Focus();
                }
            }
            else
            {
                if (panelNomLain.Height > 40)
                    panelNomLain.Height -= 3; // until 40

                if (panelPilihNom.Height < (flowLayoutPanelPilihan.Height + panelDropDownPilihNom.Height))
                    panelPilihNom.Height += kec; // until 170

                if (panelPilihNom.Height == (flowLayoutPanelPilihan.Height + panelDropDownPilihNom.Height) && panelNomLain.Height == 40)
                {
                    timerAnimation.Stop();
                    flowLayoutPanelPilihan.BringToFront();
                    flowLayoutPanelPilihan.Dock = DockStyle.Top;
                }
            }
        }

        public void UCTambahSaldo_Resize(object sender, EventArgs e)
        {
            uCVerifikasiSaldo.Width = ClientSize.Width;
            uCVerifikasiSaldo.Height = ClientSize.Height;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ((FormAkun)ParentForm).Resize -= ((FormAkun)ParentForm).FormAkun_Resize;
            this.Dispose();
        }

        private void UCTambahSaldo_Load(object sender, EventArgs e)
        {
            try
            {
                labelUsername.Text = FormUserUtama.p.Nama;
                labelSaldo.Text = FormUserUtama.p.Saldo.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonLanjut_Click(object sender, EventArgs e)
        {
            try
            {
                uCVerifikasiSaldo = new UCVerifikasiSaldo
                {
                    nominal = !status ? long.Parse(prevButton.Tag.ToString()) : long.Parse(textBoxNominalLain.Text)
                };
                this.Controls.Add(uCVerifikasiSaldo);
                this.Resize += UCTambahSaldo_Resize;
                uCVerifikasiSaldo.BringToFront();
                UCTambahSaldo_Resize(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxNominalLain_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelNominal.Text = "Rp " + (!string.IsNullOrEmpty(textBoxNominalLain.Text) ? $"{long.Parse(textBoxNominalLain.Text):N0}" : "0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxNominalLain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void LabelNominal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                buttonLanjut.Enabled = labelNominal.Text != "Rp 0";
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
    }
}
