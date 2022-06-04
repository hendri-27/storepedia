using class_Storepedia;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormMasterUtama : Form
    {
        #region Code Setting Form
        #region Move Form, Max, Min, Close
        [DllImport("User32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        const int WS_MINIMIZEBOX = 0x00020000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void PanelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            else if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                ButtonMax_MouseDown(sender, e);
            }
        }

        private void ButtonMax_MouseDown(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Padding = new Padding(0);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Padding = new Padding(3);
            }
            //OnPaint(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Application.ExitThread();
        }

        private void MouseEntering(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(61, 56, 132);
        }

        private void MouseLeaving(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(22, 20, 52);
        }
        #endregion

        #region resize and painting
        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 3; // you can rename this variable if you like
        protected override void OnPaint(PaintEventArgs e) // you can safely omit this method if you want
        {
            //PanelMenu
            //Left
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(31, 32, 71)), new Rectangle(0, 34 + _, _, this.ClientSize.Height));
            //Bottom
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(31, 32, 71)), new Rectangle(0, this.ClientSize.Height - _, 220 + _, _));

            //PanelDesktop
            if (currentChildForm is FormHome)
            {
                //Fill Right
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(26, 25, 62)), new Rectangle(this.ClientSize.Width - _, 34 + _, _, this.ClientSize.Height));
                //bottom
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(26, 25, 62)), new Rectangle(220 + _, this.ClientSize.Height - _, this.ClientSize.Width, _));
            }
            else if (currentChildForm is FormDriverPengiriman)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(26, 25, 62)), new Rectangle(this.ClientSize.Width - _, 34 + _, _, 40));
                //Fill Right
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(this.ClientSize.Width - _, 74 + _, _, this.ClientSize.Height));
                //bottom
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(220 + _, this.ClientSize.Height - _, this.ClientSize.Width, _));
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(26, 25, 62)), new Rectangle(this.ClientSize.Width - _, 34 + _, _, 40));
                //Fill Right
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(37, 36, 81)), new Rectangle(this.ClientSize.Width - _, 74 + _, _, this.ClientSize.Height));
                //bottom
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(37, 36, 81)), new Rectangle(220 + _, this.ClientSize.Height - _, this.ClientSize.Width, _));
            }
        }
        Rectangle Tops { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Lefts { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottoms { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Rights { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            if (WindowState != FormWindowState.Maximized)
            {
                if (this.Padding != new Padding(3))
                    this.Padding = new Padding(3);
                if (message.Msg == 0x84) // WM_NCHITTEST
                {
                    var cursor = this.PointToClient(Cursor.Position);

                    if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                    else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                    else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                    else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                    else if (Tops.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                    else if (Lefts.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                    else if (Rights.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                    else if (Bottoms.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
                }
            }
        }
        #endregion
        #endregion

        public static Pegawai p;
        Panel mainPanelActive;
        private IconButton mainCurrentBtn;
        private IconButton subCurrentBtn;
        readonly private Panel leftBorderBtn;
        private Form currentChildForm;
        bool work;
        int jumButton = 0;

        public FormMasterUtama()
        {
            InitializeComponent();

            leftBorderBtn = new Panel()
            {
                Size = new Size(7, 50)
            };
            //DoubleBuffered = true;
            //OnPaint(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            //p = Pegawai.BacaData("Username", "miracle")[0];

            //labelNamaPanggil.Text = p.NamaPanggilan;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(196, 240, 191);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                subCurrentBtn = (IconButton)senderBtn;
                subCurrentBtn.BackColor = Color.FromArgb(37, 36, 81);
                subCurrentBtn.ForeColor = color;
                subCurrentBtn.TextAlign = ContentAlignment.MiddleCenter;
                subCurrentBtn.IconColor = color;
                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, subCurrentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void ActivateButton(object senderBtn, object panel)
        {
            if (senderBtn != null)
            {
                if (mainCurrentBtn != null)
                {
                    mainPanelActive.Visible = false;
                    mainCurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                    mainCurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                }
                //Button
                mainPanelActive = (Panel)panel;
                mainPanelActive.Visible = true;
                mainCurrentBtn = (IconButton)senderBtn;
                mainCurrentBtn.BackColor = Color.FromArgb(37, 36, 81);
                mainCurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                mainCurrentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisableButton()
        {
            if (subCurrentBtn != null)
            {
                subCurrentBtn.BackColor = Color.FromArgb(31, 32, 71);
                subCurrentBtn.ForeColor = Color.Gainsboro;
                subCurrentBtn.TextAlign = ContentAlignment.MiddleLeft;
                subCurrentBtn.IconColor = Color.Gainsboro;
                subCurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                subCurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //status = false;
            OnPaint(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            if (mainCurrentBtn != null)
            {
                mainPanelActive.Visible = false;
                mainCurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                mainCurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
            subCurrentBtn = mainCurrentBtn = null;
            work = false;
        }

        private void ButtonHome_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(currentChildForm is FormHome))
            {
                OpenChildForm(new FormHome());
            }

            if (mainCurrentBtn != null && !work)
            {
                work = true;
                if (mainCurrentBtn == buttonMaster)
                {
                    panelSubMaster.Dock = DockStyle.Bottom;
                    panelSubMaster.SendToBack();
                    panelMaster.Height = 50;
                }
                else // buttonTransaksi
                {
                    panelSubTransaksi.Dock = DockStyle.Bottom;
                    panelSubTransaksi.SendToBack();
                    panelTransaksi.Height = 50;
                }
                Reset();
            }
        }

        private void ButtonTransaksi_MouseDown(object sender, MouseEventArgs e)
        {
            if (!work)
            {
                work = true;
                //panelMainMenu.SuspendLayout();
                if (mainCurrentBtn != null)
                {
                    panelSubMaster.Dock = DockStyle.Bottom;
                    panelSubMaster.SendToBack();
                }
                ActivateButton(sender, panelBtnTransaksi);
                panelMaster.Height = 50;
                panelTransaksi.Height = 200;
                panelBtnTransaksi.BringToFront();
                panelBtnTransaksi.Dock = DockStyle.Top;
                panelSubTransaksi.Controls.Add(leftBorderBtn);
                //panelMainMenu.ResumeLayout();
                work = false;
            }
        }

        private void ButtonMaster_MouseDown(object sender, MouseEventArgs e)
        {
            if (!work)
            {
                work = true;
                //panelMainMenu.SuspendLayout();
                if (mainCurrentBtn != null)
                {
                    panelSubTransaksi.Dock = DockStyle.Bottom;
                    panelSubTransaksi.SendToBack();
                }
                ActivateButton(sender, panelBtnMaster);

                panelMaster.Height = 50 + (jumButton * 50) ;
                panelTransaksi.Height = 50;
                panelBtnMaster.BringToFront();
                panelBtnMaster.Dock = DockStyle.Top;
                panelSubMaster.Controls.Add(leftBorderBtn);
                //panelMainMenu.ResumeLayout();
                work = false;
            }
        }

        private void ButtonDriver_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDriverPengiriman) && !work)
            {
                if (mainCurrentBtn == buttonMaster)
                {
                    panelSubMaster.Dock = DockStyle.Bottom;
                    panelSubMaster.SendToBack();
                    panelMaster.Height = 50;
                }
                else // buttonTransaksi
                {
                    panelSubTransaksi.Dock = DockStyle.Bottom;
                    panelSubTransaksi.SendToBack();
                    panelTransaksi.Height = 50;
                }
                OpenChildForm(new FormDriverPengiriman());
                ActivateButton(sender, panelBtnCheck);
            }
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread newForm = new Thread(OpenNewForm);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        private void ButtonKategori_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDaftarKategori))
            {
                OpenChildForm(new FormDaftarKategori());
                ActivateButton(sender, RGBColors.color1);
            }
        }

        private void ButtonBarang_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDaftarBarang))
            {
                OpenChildForm(new FormDaftarBarang());
                ActivateButton(sender, RGBColors.color2);
            }
        }

        private void ButtonJabatan_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDaftarJabatan))
            {
                OpenChildForm(new FormDaftarJabatan());
                ActivateButton(sender, RGBColors.color3);
            }
        }

        private void ButtonPegawai_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDaftarPegawai))
            {
                OpenChildForm(new FormDaftarPegawai());
                ActivateButton(sender, RGBColors.color4);
            }
        }

        private void FormMasterUtama_Load(object sender, EventArgs e)
        {
            foreach (Button b in panelSubMaster.Controls)
            {
                if (b.Visible == true)
                    jumButton++;
            }
            panelSubMaster.Height = jumButton * 50;
            ButtonHome_MouseDown(sender, new MouseEventArgs(MouseButtons,0,0,0,0));
        }

        private void ButtonPelanggan_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDaftarPelanggan))
            {
                OpenChildForm(new FormDaftarPelanggan());
                ActivateButton(sender, RGBColors.color5);
            }
        }

        private void ButtonSupplier_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDaftarSupplier))
            {
                OpenChildForm(new FormDaftarSupplier());
                ActivateButton(sender, RGBColors.color6);
            }
        }

        private void ButtonPengiriman_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDaftarPengiriman))
            {
                OpenChildForm(new FormDaftarPengiriman());
                ActivateButton(sender, RGBColors.color7);
            }
        }

        private void ButtonPenjualan_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDaftarNotaJual))
            {
                OpenChildForm(new FormDaftarNotaJual());
                ActivateButton(sender, RGBColors.color1);
            }
        }

        private void ButtonPembelian_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDaftarNotaBeli))
            {
                OpenChildForm(new FormDaftarNotaBeli());
                ActivateButton(sender, RGBColors.color3);
            }
        }

        private void ButtonHistorySaldo_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormDaftarHistorySaldo))
            {
                OpenChildForm(new FormDaftarHistorySaldo());
                ActivateButton(sender, RGBColors.color7);
            }
        }

        private void OpenNewForm()
        {
            Application.Run(new FormLogin());
        }

        public void PassingData(object peg)
        {
            try
            {
                p = ((List<Pegawai>)peg)[0];
                labelNamaPanggil.Text = p.NamaPanggilan;
                SettingFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        private void SettingFunction()
        {
            try
            {
                if (p.Jabatan.IdJabatan == "01")
                {
                    buttonDriver.Visible =
                    buttonPenjualan.Visible =
                    buttonBukti.Visible = false;
                    foreach (Control c in panelSubMaster.Controls)
                    {
                        if (c is Button b)
                        {
                            if (b != buttonBarang)
                                b.Visible = false;
                        }
                    }
                }
                else if (p.Jabatan.IdJabatan == "02")
                {
                    panelTransaksi.Visible =
                    buttonDriver.Visible = false;
                    foreach (Control c in panelSubMaster.Controls)
                    {
                        if (c is Button b)
                        {
                            if (b != buttonPegawai)
                                b.Visible = false;
                        }
                    }
                }
                else if (p.Jabatan.IdJabatan == "03")
                {
                    panelMaster.Visible =
                    buttonDriver.Visible = false;
                }
                else if (p.Jabatan.IdJabatan == "04")
                {
                    buttonDriver.Visible = false;
                }
                else if (p.Jabatan.IdJabatan == "05")
                {
                    panelMaster.Visible = panelTransaksi.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }
    }
}
