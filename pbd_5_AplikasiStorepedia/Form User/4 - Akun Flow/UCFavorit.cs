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

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCFavorit : UserControl
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

        UserControl uc;
        ShopItem item;
        int i = 0;

        public UCFavorit()
        {
            InitializeComponent();

            try
            {
                Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void Display()
        {
            if (FormUserUtama.p.ListFavorit.Count != 0)
            {
                uc = new PageLoading()
                {
                    Dock = DockStyle.Fill
                };
                this.Controls.Add(uc);
                uc.BringToFront();
                timerLoad.Start();
            }
            else
            {
                UCEmptyWishlist ucEmptyWishlist = new UCEmptyWishlist()
                {
                    Dock = DockStyle.Fill
                };
                this.Controls.Add(ucEmptyWishlist);
                ucEmptyWishlist.BringToFront();
            }
        }

        public void GetData()
        {
            for (int i = FormUserUtama.p.ListFavorit.Count - 1; i >= 0; i--)
            {
                MemoryStream ms = new MemoryStream(FormUserUtama.p.ListFavorit[i].Gambar);
                item = new ShopItem()
                {
                    ItemNama = FormUserUtama.p.ListFavorit[i].NamaBarang,
                    ItemHarga = FormUserUtama.p.ListFavorit[i].Harga.ToString("n0"),
                    ItemImage = Image.FromStream(ms),
                    barang = FormUserUtama.p.ListFavorit[i]
                };
                ms.Dispose();
                flowLayoutPanelFav.Controls.Add(item);
            }
            i = 0;
            this.Controls.Remove(uc);
        }

        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            try
            {
                if (i == 20)
                {
                    timerLoad.Stop();
                    GetData();
                }
                i++;
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
