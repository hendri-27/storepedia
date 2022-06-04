namespace pbd_5_AplikasiStorepedia
{
    partial class FormUserUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            FontAwesome.Sharp.IconButton buttonLogOut;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserUtama));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAkun = new FontAwesome.Sharp.IconButton();
            this.buttonRiwayat = new FontAwesome.Sharp.IconButton();
            this.buttonKeranjang = new FontAwesome.Sharp.IconButton();
            this.buttonBeranda = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNamaPanggil = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.buttonMin = new FontAwesome.Sharp.IconButton();
            this.buttonMax = new FontAwesome.Sharp.IconButton();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.timerRetry = new System.Windows.Forms.Timer(this.components);
            buttonLogOut = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTopBar.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            buttonLogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            buttonLogOut.ForeColor = System.Drawing.Color.White;
            buttonLogOut.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            buttonLogOut.IconColor = System.Drawing.Color.DarkGray;
            buttonLogOut.IconSize = 35;
            buttonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new System.Drawing.Point(0, 476);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Rotation = 0D;
            buttonLogOut.Size = new System.Drawing.Size(220, 60);
            buttonLogOut.TabIndex = 7;
            buttonLogOut.TabStop = false;
            buttonLogOut.Text = "   Log out";
            buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.panelMenu.Controls.Add(buttonLogOut);
            this.panelMenu.Controls.Add(this.buttonAkun);
            this.panelMenu.Controls.Add(this.buttonRiwayat);
            this.panelMenu.Controls.Add(this.buttonKeranjang);
            this.panelMenu.Controls.Add(this.buttonBeranda);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 536);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonAkun
            // 
            this.buttonAkun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAkun.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAkun.FlatAppearance.BorderSize = 0;
            this.buttonAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAkun.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAkun.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonAkun.ForeColor = System.Drawing.Color.White;
            this.buttonAkun.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.buttonAkun.IconColor = System.Drawing.Color.DarkGray;
            this.buttonAkun.IconSize = 30;
            this.buttonAkun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAkun.Location = new System.Drawing.Point(0, 319);
            this.buttonAkun.Name = "buttonAkun";
            this.buttonAkun.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonAkun.Rotation = 0D;
            this.buttonAkun.Size = new System.Drawing.Size(220, 50);
            this.buttonAkun.TabIndex = 4;
            this.buttonAkun.TabStop = false;
            this.buttonAkun.Text = "    Akun";
            this.buttonAkun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAkun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAkun.UseVisualStyleBackColor = true;
            this.buttonAkun.Click += new System.EventHandler(this.ButtonAkun_Click);
            // 
            // buttonRiwayat
            // 
            this.buttonRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRiwayat.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRiwayat.FlatAppearance.BorderSize = 0;
            this.buttonRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRiwayat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonRiwayat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonRiwayat.ForeColor = System.Drawing.Color.White;
            this.buttonRiwayat.IconChar = FontAwesome.Sharp.IconChar.History;
            this.buttonRiwayat.IconColor = System.Drawing.Color.DarkGray;
            this.buttonRiwayat.IconSize = 30;
            this.buttonRiwayat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRiwayat.Location = new System.Drawing.Point(0, 269);
            this.buttonRiwayat.Name = "buttonRiwayat";
            this.buttonRiwayat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonRiwayat.Rotation = 0D;
            this.buttonRiwayat.Size = new System.Drawing.Size(220, 50);
            this.buttonRiwayat.TabIndex = 3;
            this.buttonRiwayat.TabStop = false;
            this.buttonRiwayat.Text = "    Riwayat transaksi";
            this.buttonRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRiwayat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRiwayat.UseVisualStyleBackColor = true;
            this.buttonRiwayat.Click += new System.EventHandler(this.ButtonRiwayat_Click);
            // 
            // buttonKeranjang
            // 
            this.buttonKeranjang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKeranjang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKeranjang.FlatAppearance.BorderSize = 0;
            this.buttonKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeranjang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonKeranjang.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonKeranjang.ForeColor = System.Drawing.Color.White;
            this.buttonKeranjang.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.buttonKeranjang.IconColor = System.Drawing.Color.DarkGray;
            this.buttonKeranjang.IconSize = 30;
            this.buttonKeranjang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKeranjang.Location = new System.Drawing.Point(0, 219);
            this.buttonKeranjang.Name = "buttonKeranjang";
            this.buttonKeranjang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonKeranjang.Rotation = 0D;
            this.buttonKeranjang.Size = new System.Drawing.Size(220, 50);
            this.buttonKeranjang.TabIndex = 2;
            this.buttonKeranjang.TabStop = false;
            this.buttonKeranjang.Text = "    Keranjang";
            this.buttonKeranjang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKeranjang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKeranjang.UseVisualStyleBackColor = true;
            this.buttonKeranjang.Click += new System.EventHandler(this.ButtonKeranjang_Click);
            // 
            // buttonBeranda
            // 
            this.buttonBeranda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBeranda.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBeranda.FlatAppearance.BorderSize = 0;
            this.buttonBeranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBeranda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonBeranda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeranda.ForeColor = System.Drawing.Color.White;
            this.buttonBeranda.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.buttonBeranda.IconColor = System.Drawing.Color.DarkGray;
            this.buttonBeranda.IconSize = 30;
            this.buttonBeranda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBeranda.Location = new System.Drawing.Point(0, 169);
            this.buttonBeranda.Name = "buttonBeranda";
            this.buttonBeranda.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonBeranda.Rotation = 0D;
            this.buttonBeranda.Size = new System.Drawing.Size(220, 50);
            this.buttonBeranda.TabIndex = 1;
            this.buttonBeranda.TabStop = false;
            this.buttonBeranda.Text = "    Beranda";
            this.buttonBeranda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBeranda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBeranda.UseVisualStyleBackColor = true;
            this.buttonBeranda.Click += new System.EventHandler(this.ButtonBeranda_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.guna2Panel1);
            this.panelLogo.Controls.Add(this.label7);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.label4);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.labelNamaPanggil);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 169);
            this.panelLogo.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(78, 46);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(106, 22);
            this.guna2Panel1.TabIndex = 26;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "TOREPEDIA";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(92, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 2);
            this.label7.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::pbd_5_AplikasiStorepedia.Properties.Resources.Storepedia_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(43, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 2);
            this.label4.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome,";
            // 
            // labelNamaPanggil
            // 
            this.labelNamaPanggil.AutoSize = true;
            this.labelNamaPanggil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPanggil.ForeColor = System.Drawing.Color.White;
            this.labelNamaPanggil.Location = new System.Drawing.Point(9, 131);
            this.labelNamaPanggil.Name = "labelNamaPanggil";
            this.labelNamaPanggil.Size = new System.Drawing.Size(39, 20);
            this.labelNamaPanggil.TabIndex = 5;
            this.labelNamaPanggil.Text = "user";
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.panelTopBar.Controls.Add(this.buttonMin);
            this.panelTopBar.Controls.Add(this.buttonMax);
            this.panelTopBar.Controls.Add(this.buttonClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(3, 3);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(920, 34);
            this.panelTopBar.TabIndex = 1;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTopBar_MouseDown);
            // 
            // buttonMin
            // 
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonMin.IconColor = System.Drawing.Color.Black;
            this.buttonMin.IconSize = 16;
            this.buttonMin.Location = new System.Drawing.Point(770, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Rotation = 0D;
            this.buttonMin.Size = new System.Drawing.Size(48, 34);
            this.buttonMin.TabIndex = 4;
            this.buttonMin.TabStop = false;
            this.buttonMin.Text = "⎯";
            this.buttonMin.UseCompatibleTextRendering = true;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            this.buttonMin.MouseEnter += new System.EventHandler(this.MouseEntering);
            this.buttonMin.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // buttonMax
            // 
            this.buttonMax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMax.FlatAppearance.BorderSize = 0;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.buttonMax.IconColor = System.Drawing.Color.White;
            this.buttonMax.IconSize = 16;
            this.buttonMax.Location = new System.Drawing.Point(818, 0);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Rotation = 0D;
            this.buttonMax.Size = new System.Drawing.Size(51, 34);
            this.buttonMax.TabIndex = 3;
            this.buttonMax.TabStop = false;
            this.buttonMax.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMax_MouseDown);
            this.buttonMax.MouseEnter += new System.EventHandler(this.MouseEntering);
            this.buttonMax.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonClose.IconColor = System.Drawing.Color.Black;
            this.buttonClose.IconSize = 16;
            this.buttonClose.Location = new System.Drawing.Point(869, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Rotation = 0D;
            this.buttonClose.Size = new System.Drawing.Size(51, 34);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.MouseEntering);
            this.buttonClose.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelDesktop);
            this.panelForm.Controls.Add(this.panelMenu);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(3, 37);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(920, 536);
            this.panelForm.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(700, 536);
            this.panelDesktop.TabIndex = 1;
            // 
            // timerRetry
            // 
            this.timerRetry.Interval = 1000;
            this.timerRetry.Tick += new System.EventHandler(this.TimerRetry_Tick);
            // 
            // FormUserUtama
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(926, 576);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTopBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(926, 576);
            this.Name = "FormUserUtama";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storepedia";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTopBar.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton buttonBeranda;
        private FontAwesome.Sharp.IconButton buttonAkun;
        private FontAwesome.Sharp.IconButton buttonRiwayat;
        private FontAwesome.Sharp.IconButton buttonKeranjang;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTopBar;
        private FontAwesome.Sharp.IconButton buttonClose;
        private FontAwesome.Sharp.IconButton buttonMin;
        private FontAwesome.Sharp.IconButton buttonMax;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelDesktop;
        public System.Windows.Forms.Label labelNamaPanggil;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Timer timerRetry;
    }
}