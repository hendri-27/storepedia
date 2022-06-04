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
    public partial class ShopItem : UserControl
    {
        public ShopItem()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

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
                return labelNama.Text;
            }

            set
            {
                labelNama.Text = value;
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

        public Barang barang;

        private void ShopItem_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(Pens.Gray, this.ClientRectangle);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void ShopItem_Click(object sender, EventArgs e)
        {
            FormDetailBarang formDetailBarang = new FormDetailBarang()
            {
                brg = barang
            };
            formDetailBarang.ShowDialog();
        }
    }
}