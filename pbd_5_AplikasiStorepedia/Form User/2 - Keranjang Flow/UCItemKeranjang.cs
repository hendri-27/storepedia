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
    public partial class UCItemKeranjang : UserControl
    {
        public UCNotEmptyCart uc;
        public UCItemKeranjang()
        {
            InitializeComponent();
        }
        int idxBrg, history;
        bool ubah;
        bool hapus;
        public Barang brgCart;
        InvisiblePanel invPanel;

        public Image ItemImage
        {
            get
            {
                return pictureBoxBarang.Image;
            }

            set
            {
                pictureBoxBarang.Image = value;
            }
        }

        public string ItemNama
        {
            get
            {
                return labelNamaBrg.Text;
            }

            set
            {
                labelNamaBrg.Text = value;
            }
        }

        public string ItemHarga
        {
            get
            {
                return labelHarga.Text;
            }

            set
            {
                labelHarga.Text = value;
            }
        }

        public int ItemJumlah
        {
            get
            {
                return int.Parse(textBoxJum.Text);
            }

            set
            {
                textBoxJum.Text = value.ToString();
                history = value;
            }
        }

        private void ButtonUbah_Click(object sender, EventArgs e)
        {
            ubah = true;
            buttonUbah.SendToBack();
            timerAnimation.Start();
        }

        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ubah)
                {
                    panelBarang.Location = new Point(panelBarang.Location.X - 8, panelBarang.Location.Y);
                    if (panelBarang.Location == new Point(-88, 0))
                    {
                        invPanel = new InvisiblePanel()
                        {
                            Opacity = 30,
                            BackColor = Color.Gray,
                            Dock = DockStyle.Fill
                        };
                        invPanel.Click += ClosingInvisiblePanel;
                        panelBarang.Controls.Add(invPanel);
                        invPanel.BringToFront();
                        timerAnimation.Stop();
                        ubah = false;
                    }
                }
                else
                {
                    panelBarang.Location = new Point(panelBarang.Location.X + 8, panelBarang.Location.Y);
                    if (panelBarang.Location == new Point(0, 0))
                    {
                        timerAnimation.Stop();
                        if (hapus)
                        {
                            if (checkBoxItem.Checked)
                            {
                                uc.labelTotalHarga.Text = "Rp " + (double.Parse(uc.labelTotalHarga.Text.Substring(3).ToString()) - int.Parse(textBoxJum.Text) * brgCart.Harga).ToString("N0");
                                uc.buttonBeli.Text = "Beli (" + (int.Parse(uc.buttonBeli.Text.Substring(6, uc.buttonBeli.Text.Length - 7)) - int.Parse(textBoxJum.Text)) + ")";
                                UCNotEmptyCart.listCheckOut.Remove(brgCart);
                            }
                            FormUserUtama.p.HapusCart(brgCart);
                            this.Dispose();
                        }
                        buttonUbah.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonHapus_Click(object sender, EventArgs e)
        {
            hapus = true;
            timerAnimation.Start();
        }

        private void ButtonPlus_MouseDown(object sender, MouseEventArgs e)
        {
            int temp = int.Parse(textBoxJum.Text) + 1;
            textBoxJum.Text = temp.ToString();
        }

        private void ButtonMinus_MouseDown(object sender, MouseEventArgs e)
        {
            int temp = int.Parse(textBoxJum.Text) - 1;
            textBoxJum.Text = temp.ToString();
        }
        

        private void TextBoxJum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxJum.Text == "")
                {
                    buttonMinus.Enabled = false;
                    buttonMinus.IconColor = Color.FromArgb(213, 218, 223);
                }
                else
                {
                    if (int.Parse(textBoxJum.Text) <= 0 || int.Parse(textBoxJum.Text) > FormUserUtama.listBarang[idxBrg].Stok)
                    {
                        textBoxJum.Text = textBoxJum.Text.Remove(textBoxJum.Text.Length - 1);
                        textBoxJum.Select(textBoxJum.TextLength, 1);
                    }
                    else if (textBoxJum.Text == "1")
                    {
                        buttonMinus.Enabled = false;
                        buttonMinus.IconColor = Color.FromArgb(213, 218, 223);
                        buttonPlus.Enabled = true;
                        buttonPlus.IconColor = Color.DimGray;
                    }
                    else if (textBoxJum.Text == FormUserUtama.listBarang[idxBrg].Stok.ToString())
                    {
                        buttonPlus.Enabled = false;
                        buttonPlus.IconColor = Color.FromArgb(213, 218, 223);
                        buttonMinus.Enabled = true;
                        buttonMinus.IconColor = Color.DimGray;
                    }
                    else
                    {
                        buttonPlus.Enabled = buttonMinus.Enabled = true;
                        buttonMinus.IconColor = buttonPlus.IconColor = Color.DimGray;
                    }

                    if (checkBoxItem.Checked && textBoxJum.Text != "")
                    {
                        if (int.Parse(textBoxJum.Text) > 0 || int.Parse(textBoxJum.Text) > FormUserUtama.listBarang[idxBrg].Stok)
                        {
                            uc.labelTotalHarga.Text = "Rp " + (double.Parse(uc.labelTotalHarga.Text.Substring(3).ToString()) + (int.Parse(textBoxJum.Text) - history) * brgCart.Harga).ToString("N0");
                            uc.buttonBeli.Text = "Beli (" + (int.Parse(uc.buttonBeli.Text.Substring(6, uc.buttonBeli.Text.Length - 7)) + int.Parse(textBoxJum.Text) - history) + ")";
                        }
                    }

                    if (textBoxJum.Text != "")
                        UpdateCart(int.Parse(textBoxJum.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void UpdateCart(int jumlah)
        {
            try
            {
                //int idxCart = FormUserUtama.listCart.IndexOf(brgCart);
                history = jumlah;
                FormUserUtama.p.UpdateJumlahCart(brgCart, jumlah);
                //FormUserUtama.listCart[idxCart].Stok = jumlah;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void UCItemKeranjang_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < FormUserUtama.listBarang.Count; i++)
                {
                    if (FormUserUtama.listBarang[i].IdBarang == brgCart.IdBarang)
                    {
                        idxBrg = i;
                        break;
                    }
                }
                textBoxJum.TextChanged += TextBoxJum_TextChanged;
                TextBoxJum_TextChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ClosingInvisiblePanel(object sender, EventArgs e)
        {
            timerAnimation.Start();
            panelBarang.Controls.Remove(invPanel);
        }

        public void CheckAll(object sender, EventArgs e)
        {
            try
            {
                if (uc.checkBoxSemua.Checked)
                    checkBoxItem.Checked = true;
                else
                    checkBoxItem.Checked = false;

                CheckBoxItem_Click(sender, e);

                if ((uc.checkBoxSemua.Checked && UCNotEmptyCart.listCheckOut.Count == FormUserUtama.p.ListCart.Count) || (!uc.checkBoxSemua.Checked && UCNotEmptyCart.listCheckOut.Count == 0))
                    uc.CheckedChange(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxJum_Leave(object sender, EventArgs e)
        {
            if (textBoxJum.Text == "")
            {
                textBoxJum.Text = history.ToString();
            }
        }

        private void CheckBoxItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = UCNotEmptyCart.listCheckOut.IndexOf(brgCart);

                if (checkBoxItem.Checked && idx == -1)
                {
                    UCNotEmptyCart.listCheckOut.Add(brgCart);
                    //MessageBox.Show("Tambah " + brgCart.NamaBarang);
                }
                else if (!checkBoxItem.Checked)
                {
                    UCNotEmptyCart.listCheckOut.Remove(brgCart);
                    //MessageBox.Show("Hapus " + brgCart.NamaBarang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxJum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TextBoxJum_Enter(object sender, EventArgs e)
        {
            textBoxJum.Select(textBoxJum.Text.Length, 0);
        }
    }
}
