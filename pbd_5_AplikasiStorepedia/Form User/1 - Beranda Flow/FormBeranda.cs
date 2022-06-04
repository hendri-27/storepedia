using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_Storepedia;


namespace pbd_5_AplikasiStorepedia
{
    public partial class FormBeranda : Form
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
        FilterDialog filterDialog;
        InvisiblePanel invisiblePan;
        ShopItem item;
        int i = 0;
        int time = 5;
        string kriteria = "";
        object active;

        public static string max, min, kategori, merek;

        public FormBeranda()
        {
            InitializeComponent();
            Display();
        }

        public void GetData()
        {
            try
            {
                List<Barang> listFilter = new List<Barang>();
                flowLayoutPanelSearch.Controls.Clear();
                if (active == buttonFilter)
                {
                    foreach (Barang b in FormUserUtama.listBarang)
                    {
                        if (kategori != "" && merek != "")
                        {
                            if (max == "")
                            {
                                if (kategori == b.Kategori.Nama && merek == b.Supplier.Nama && int.Parse(min) <= b.Harga)
                                {
                                    listFilter.Add(b);
                                }
                            }
                            else
                            {
                                if (kategori == b.Kategori.Nama && merek == b.Supplier.Nama && int.Parse(min) <= b.Harga && int.Parse(max) >= b.Harga)
                                {
                                    listFilter.Add(b);
                                }
                            }
                        }
                        else if (kategori != "")
                        {
                            if (max == "")
                            {
                                if (kategori == b.Kategori.Nama && int.Parse(min) <= b.Harga)
                                {
                                    listFilter.Add(b);
                                }
                            }
                            else
                            {
                                if (kategori == b.Kategori.Nama && int.Parse(min) <= b.Harga && int.Parse(max) >= b.Harga)
                                {
                                    listFilter.Add(b);
                                }
                            }
                        }
                        else if (merek != "")
                        {
                            if (max == "")
                            {
                                if (merek == b.Supplier.Nama && int.Parse(min) <= b.Harga)
                                {
                                    listFilter.Add(b);
                                }
                            }
                            else
                            {
                                if (merek == b.Supplier.Nama && int.Parse(min) <= b.Harga && int.Parse(max) >= b.Harga)
                                {
                                    listFilter.Add(b);
                                }
                            }
                        }
                        else if (min != "")
                        {
                            if (max == "")
                            {
                                if (int.Parse(min) <= b.Harga)
                                {
                                    listFilter.Add(b);
                                }
                            }
                            else
                            {
                                if (int.Parse(min) <= b.Harga && int.Parse(max) >= b.Harga)
                                {
                                    listFilter.Add(b);
                                }
                            }
                        }

                    }
                }
                else if (active == buttonSearch)
                {
                    listFilter = Barang.BacaData(kriteria, textBoxSearch.Text);
                }
                else if (active == buttonRefresh)
                {
                    listFilter = FormUserUtama.listBarang;
                }    
                else
                    FormUserUtama.listBarang = listFilter = Barang.BacaData("", "");

                if (listFilter.Count != 0)
                {
                    foreach (Barang b in listFilter)
                    {
                        MemoryStream ms = new MemoryStream(b.Gambar);
                        item = new ShopItem()
                        {
                            TabStop = false,
                            ItemNama = b.NamaBarang,
                            ItemHarga = b.Harga.ToString("n0"),
                            ItemImage = Image.FromStream(ms),
                            barang = b
                        };
                        ms.Dispose();
                        flowLayoutPanelSearch.Controls.Add(item);
                    }
                }
                else
                {
                    labelNotFound.Visible = true;
                }
                active = this;
                i = 0;
                this.Controls.Remove(uc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch.Text != "")
                {
                    buttonSearch.Visible = true;
                    textBoxSearch.IconRight = Properties.Resources.times;
                }
                else
                {
                    buttonSearch.Visible = false;
                    textBoxSearch.IconRight = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxSearch_IconRightClick(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            textBoxSearch.IconRight = null;
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            buttonRefresh.Enabled = false;
            buttonRefresh.IconColor = Color.Gray;
            kriteria = "";
            active = sender;
            timerRefresh.Start();
            labelCounter.Visible = true;
            Display();
        }

        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            if (i == 20)
            {
                timerLoad.Stop();
                GetData();
            }
            i++;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                kriteria = "b.NamaBarang";
                active = sender;
                Display();
            }
        }

        public void Display()
        {
            try
            {
                if (labelNotFound.Visible == true)
                    labelNotFound.Visible = false;
                uc = new PageLoading()
                {
                    Dock = DockStyle.Fill
                };
                this.Controls.Add(uc);
                uc.BringToFront();
                timerLoad.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                ButtonSearch_Click(buttonSearch, e);
            }
        }

        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            time--;
            labelCounter.Text = time + " s";
            if (time == 0)
            {
                time = 5;
                labelCounter.Visible = false;
                labelCounter.Text = "5 s";
                timerRefresh.Stop();
                buttonRefresh.Enabled = true;
                buttonRefresh.IconColor = Color.White;
            }
        }

        public void ButtonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                active = sender;
                flowLayoutPanelSearch.Focus();
                invisiblePan = new InvisiblePanel()
                {
                    Dock = DockStyle.Fill
                };
                invisiblePan.Click += CustomClosing;
                ((FormUserUtama)ParentForm).Controls.Add(invisiblePan);
                invisiblePan.BringToFront();

                filterDialog = new FilterDialog()
                {
                    Dock = DockStyle.Right
                };
                ((FormUserUtama)ParentForm).ControlRemoved += ((FormUserUtama)ParentForm).FormUserUtama_ControlRemoved;
                ((FormUserUtama)ParentForm).Controls.Add(filterDialog);
                filterDialog.BringToFront();
                ((FormUserUtama)ParentForm).Repainting(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void CustomClosing(object sender, EventArgs e)
        {
            try
            {
                ((FormUserUtama)ParentForm).Controls.Remove(invisiblePan);
                ((FormUserUtama)ParentForm).Repainting(false);
                ((FormUserUtama)ParentForm).Controls.Remove(filterDialog);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}