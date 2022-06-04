using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using class_Storepedia;

namespace pbd_5_AplikasiStorepedia
{
    public partial class UCNotEmptyCart : UserControl
    {
        int i = 0;
        readonly PageLoading uc;
        public static List<Barang> listCheckOut;
        public FormUserUtama formUserUtama;
        public static long subTotal;

        public UCNotEmptyCart()
        {
            InitializeComponent();

            listCheckOut = new List<Barang>();
            uc = new PageLoading()
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(uc);
            uc.BringToFront();
            timerLoad.Start();
        }

        private void Display()
        {
            for (int i = FormUserUtama.p.ListCart.Count - 1; i >= 0; i--)
            {
                MemoryStream ms = new MemoryStream(FormUserUtama.p.ListCart[i].Gambar);
                UCItemKeranjang ucItemKeranjang = new UCItemKeranjang()
                {
                    uc = this,
                    brgCart = FormUserUtama.p.ListCart[i],
                    ItemNama = FormUserUtama.p.ListCart[i].NamaBarang,
                    ItemHarga = FormUserUtama.p.ListCart[i].Harga.ToString("n0"),
                    ItemImage = Image.FromStream(ms),
                    ItemJumlah = FormUserUtama.p.ListCart[i].Stok
                };
                ms.Dispose();
                checkBoxSemua.Click += ucItemKeranjang.CheckAll;
                ucItemKeranjang.checkBoxItem.Click += CheckedChange;
                flowLayoutPanelKeranjang.Controls.Add(ucItemKeranjang);
            }
            uc.Dispose();
            this.Resize += UCNotEmptyCart_Resize;
        }

        private void UCNotEmptyCart_ControlRemoved(object sender, ControlEventArgs e)
        {
            try
            {
                if (FormUserUtama.p.ListCart.Count == 0)
                {
                    ((FormKeranjang)ParentForm).FormKeranjang_Load(e, e);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void UCNotEmptyCart_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelKeranjang.SuspendLayout();
            foreach (Control ctrl in flowLayoutPanelKeranjang.Controls)
            {
                ctrl.Width = flowLayoutPanelKeranjang.ClientSize.Width;
            }
            flowLayoutPanelKeranjang.ResumeLayout();
            formUserUtama.Repainting(true);
        }

        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            try
            {
                if (i == 20)
                {
                    timerLoad.Stop();
                    Display();
                    UCNotEmptyCart_Resize(sender, e);
                }
                i++;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void CheckedChange(object sender, EventArgs e)
        {
            try
            {
                if (listCheckOut.Count > 0)
                {
                    if (listCheckOut.Count == FormUserUtama.p.ListCart.Count)
                        checkBoxSemua.Checked = true;
                    else
                        checkBoxSemua.Checked = false;

                    buttonBeli.Enabled = true;

                    int total = 0,
                        jum = 0;
                    foreach (Barang b in listCheckOut)
                    {
                        total += b.Harga * b.Stok;
                        jum += b.Stok;

                    }
                    labelTotalHarga.Text = $"Rp {total:N0}";
                    buttonBeli.Text = $"Beli ({jum})";
                }
                else
                {
                    checkBoxSemua.Checked = false;
                    buttonBeli.Enabled = false;
                    buttonBeli.Text = "Beli";
                    labelTotalHarga.Text = "Rp 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void ButtonBeli_Click(object sender, EventArgs e)
        {
            subTotal = (long)double.Parse(labelTotalHarga.Text.Substring(3));
            ((FormKeranjang)ParentForm).CreatePayment();
        }
    }
}
