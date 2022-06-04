using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class_Storepedia;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace pbd_5_AplikasiStorepedia
{
    public partial class FormUserUtama : Form
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
            OnPaint(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
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
            if (currentChildForm is FormBeranda)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(26, 25, 62)), new Rectangle(this.ClientSize.Width - _, 34 + _, _, 87 + _));
                //Fill Right
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(this.ClientSize.Width - _, 90, _, this.ClientSize.Height));
                //bottom
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(220 + _, this.ClientSize.Height - _, this.ClientSize.Width, _));
                //PanelSearch Right
                if (status)
                {
                    //Fill Right
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(31, 32, 71)), new Rectangle(this.ClientSize.Width - _, 90, _, this.ClientSize.Height));
                    //bottom
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(31, 32, 71)), new Rectangle(this.ClientSize.Width - 279 - _, this.ClientSize.Height - _, this.ClientSize.Width, _));
                }
            }
            else if (currentChildForm is FormKeranjang)
            {
                //Fill Right
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(this.ClientSize.Width - _, 90, _, this.ClientSize.Height));
                //bottom
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(220 + _, this.ClientSize.Height - _, this.ClientSize.Width, _));
                if (status)
                {
                    //Fill Right White
                    e.Graphics.FillRectangle(Brushes.White, new Rectangle(this.ClientSize.Width - _, 90, _, this.ClientSize.Height - 69 - _));
                    //Fill Right
                    e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - 69 - _, _, 69+_));
                    //bottom
                    e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(223, this.ClientSize.Height - _, this.ClientSize.Width, _));
                }
            }
            else if (currentChildForm is FormRiwayatTransaksi)
            {
                //Fill Right
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(this.ClientSize.Width - _, 90, _, this.ClientSize.Height));
                //bottom
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(220 + _, this.ClientSize.Height - _, this.ClientSize.Width, _));
                //e.Graphics.FillRectangle(Brushes.White, new Rectangle(this.ClientSize.Width - _, 90, _, this.ClientSize.Height));
                //e.Graphics.FillRectangle(Brushes.White, new Rectangle(223, this.ClientSize.Height - _, this.ClientSize.Width, _));
            }
            else if (currentChildForm is FormAkun)
            {
                //Fill Right
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(this.ClientSize.Width - _, 90, _, this.ClientSize.Height));
                //bottom
                e.Graphics.FillRectangle(Brushes.White, new Rectangle(220 + _, this.ClientSize.Height - _, this.ClientSize.Width, _));
                //e.Graphics.FillRectangle(Brushes.White, new Rectangle(this.ClientSize.Width - _, 90, _, this.ClientSize.Height));
                //e.Graphics.FillRectangle(Brushes.White, new Rectangle(223, this.ClientSize.Height - _, this.ClientSize.Width, _));
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

        private IconButton currentBtn;
        readonly private Panel leftBorderBtn;
        private Form currentChildForm;
        public static Pelanggan p;
        bool status; // true = painting for FilterDialog, false = remove painting
        public static bool buttonFilter;
        public static List<Barang> listBarang = new List<Barang>();
        public static FormUserUtama formUserUtama;
        public int i = 60;
        public UCEmail ucEmail;

        public FormUserUtama()
        {
            InitializeComponent();

            leftBorderBtn = new Panel()
            {
                Size = new Size(7, 50)
            };
            DoubleBuffered = true;
            OnPaint(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
            panelMenu.Controls.Add(leftBorderBtn);
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            formUserUtama = this;

            //SEMENTARA
            //p = Pelanggan.BacaData("Username", "kevinsahara213")[0];
            //
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(249, 88, 155);
            public static Color color2 = Color.FromArgb(253, 138, 114);
            public static Color color3 = Color.FromArgb(24, 161, 251);
            public static Color color4 = Color.FromArgb(172, 126, 241);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                if (senderBtn == buttonBeranda)
                    buttonBeranda.IconChar = IconChar.ToggleOn;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 32, 71);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

                if (currentBtn == buttonBeranda)
                    buttonBeranda.IconChar = IconChar.ToggleOff;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            childForm.SuspendLayout();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            status = false;
            OnPaint(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.ResumeLayout();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            //Manggil Form Beranda
            ButtonBeranda_Click(buttonBeranda, e);
        }

        public void ButtonBeranda_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormBeranda))
            {
                if (sender is UCEmptyCart || sender is UCEmptyWishlist || sender is UCEmptyTransaksi || sender is UCEmptyHistorySaldo)
                    sender = buttonBeranda;
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new FormBeranda());
            }
        }

        private void ButtonKeranjang_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormKeranjang))
            {
                ActivateButton(sender, RGBColors.color2);
                OpenChildForm(new FormKeranjang());
            }
        }



        public void ButtonRiwayat_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormRiwayatTransaksi))
            {
                if (sender is UCRincianPesanan)
                    sender = buttonRiwayat;
                ActivateButton(sender, RGBColors.color3);
                OpenChildForm(new FormRiwayatTransaksi());
            }
        }

        private void ButtonAkun_Click(object sender, EventArgs e)
        {
            if (!(currentChildForm is FormAkun))
            {
                ActivateButton(sender, RGBColors.color4);
                OpenChildForm(new FormAkun());
            }
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread newForm = new Thread(OpenNewForm);
            newForm.SetApartmentState(ApartmentState.STA);
            newForm.Start();
        }

        private void OpenNewForm()
        {
            Application.Run(new FormLogin());
        }

        public void PassingData(object pel)
        {
            try
            {
                p = ((List<Pelanggan>)pel)[0];
                p.BacaPref();
                labelNamaPanggil.Text = p.NamaPanggilan;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pesan Kesalahan : {ex.Message}", "Kesalahan");
            }
        }

        public void Repainting(bool sender)
        {
            //true = open, false = close
            status = sender;
            OnPaint(new PaintEventArgs(CreateGraphics(), ClientRectangle));
        }

        public void FormUserUtama_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (buttonFilter)
            {
                buttonFilter = false;
                foreach (Control c in panelDesktop.Controls)
                {
                    if (c is FormBeranda beranda)
                    {
                        beranda.Display();
                    }
                }
            }
            this.ControlRemoved -= FormUserUtama_ControlRemoved;
        } 
        
        private void TimerRetry_Tick(object sender, EventArgs e)
        {
            i--;

            ucEmail.buttonSendVerification.Text = $"Coba Lagi ({i}s)";

            if (i == 0)
            {
                timerRetry.Stop();
                i = 60;
                ucEmail.buttonSendVerification.Text = "Kirim Verifikasi";
                ucEmail.buttonSendVerification.Enabled = true;
            }
        }
    }
}
