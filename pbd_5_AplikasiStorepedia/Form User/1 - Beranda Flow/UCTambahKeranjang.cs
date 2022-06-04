using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class TambahKeranjang : UserControl
    {
        public TambahKeranjang()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        #region Creating Round UserControl
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public static Region GetRoundedRegion(int controlWidth, int controlHeight)
        {
            return Region.FromHrgn(CreateRoundRectRgn(0, 0, controlWidth - 5, controlHeight - 5, 20, 20));
        }
        #endregion

        private void ButtonPlus_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxJum.Text == "")
            {
                textBoxJum.Text = "1";
                return;
            }
            textBoxJum.Text = (int.Parse(textBoxJum.Text) + 1).ToString();
        }

        private void ButtonMinus_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxJum.Text = (int.Parse(textBoxJum.Text) - 1).ToString();
        }

        private void TextBoxJum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxJum.Text == "")
                {
                    buttonMasukKeranjang.Enabled = buttonMinus.Enabled = false;
                    buttonMinus.IconColor = Color.FromArgb(213, 218, 223);
                }
                else
                {
                    buttonMasukKeranjang.Enabled = true;
                    if (int.Parse(textBoxJum.Text) <= 0 || int.Parse(textBoxJum.Text) > ((FormDetailBarang)ParentForm).brg.Stok)
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
                    else if (textBoxJum.Text == ((FormDetailBarang)ParentForm).brg.Stok.ToString())
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonMasukKeranjang_Click(object sender, EventArgs e)
        {
            try
            {
                ((FormDetailBarang)ParentForm).AddToCart(int.Parse(textBoxJum.Text));
                ((FormDetailBarang)ParentForm).ClosingControl(e, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void textBoxJum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
