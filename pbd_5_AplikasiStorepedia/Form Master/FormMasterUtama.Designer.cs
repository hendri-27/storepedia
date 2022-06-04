namespace pbd_5_AplikasiStorepedia
{
    partial class FormMasterUtama
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
            FontAwesome.Sharp.IconButton buttonLogOut;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasterUtama));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelPengiriman = new System.Windows.Forms.Panel();
            this.panelBtnCheck = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonDriver = new FontAwesome.Sharp.IconButton();
            this.panelTransaksi = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBtnTransaksi = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonTransaksi = new FontAwesome.Sharp.IconButton();
            this.panelSubTransaksi = new System.Windows.Forms.Panel();
            this.buttonBukti = new FontAwesome.Sharp.IconButton();
            this.buttonPembelian = new FontAwesome.Sharp.IconButton();
            this.buttonPenjualan = new FontAwesome.Sharp.IconButton();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBtnMaster = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonMaster = new FontAwesome.Sharp.IconButton();
            this.panelSubMaster = new System.Windows.Forms.Panel();
            this.buttonPengiriman = new FontAwesome.Sharp.IconButton();
            this.buttonSupplier = new FontAwesome.Sharp.IconButton();
            this.buttonPelanggan = new FontAwesome.Sharp.IconButton();
            this.buttonPegawai = new FontAwesome.Sharp.IconButton();
            this.buttonJabatan = new FontAwesome.Sharp.IconButton();
            this.buttonBarang = new FontAwesome.Sharp.IconButton();
            this.buttonKategori = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonHome = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNamaPanggil = new System.Windows.Forms.Label();
            this.buttonMin = new FontAwesome.Sharp.IconButton();
            this.buttonMax = new FontAwesome.Sharp.IconButton();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            buttonLogOut = new FontAwesome.Sharp.IconButton();
            this.panelForm.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.panelPengiriman.SuspendLayout();
            this.panelTransaksi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSubTransaksi.SuspendLayout();
            this.panelMaster.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSubMaster.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTopBar.SuspendLayout();
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
            buttonLogOut.Location = new System.Drawing.Point(0, 481);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Rotation = 0D;
            buttonLogOut.Size = new System.Drawing.Size(220, 60);
            buttonLogOut.TabIndex = 23;
            buttonLogOut.Text = "   Log out";
            buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelDesktop);
            this.panelForm.Controls.Add(this.panelMenu);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(3, 37);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(950, 541);
            this.panelForm.TabIndex = 4;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(730, 541);
            this.panelDesktop.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.panelMenu.Controls.Add(this.panelMainMenu);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(buttonLogOut);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 541);
            this.panelMenu.TabIndex = 0;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.AutoScroll = true;
            this.panelMainMenu.Controls.Add(this.panelPengiriman);
            this.panelMainMenu.Controls.Add(this.panelTransaksi);
            this.panelMainMenu.Controls.Add(this.panelMaster);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 121);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(220, 360);
            this.panelMainMenu.TabIndex = 8;
            // 
            // panelPengiriman
            // 
            this.panelPengiriman.Controls.Add(this.panelBtnCheck);
            this.panelPengiriman.Controls.Add(this.buttonDriver);
            this.panelPengiriman.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPengiriman.Location = new System.Drawing.Point(0, 100);
            this.panelPengiriman.Name = "panelPengiriman";
            this.panelPengiriman.Size = new System.Drawing.Size(220, 50);
            this.panelPengiriman.TabIndex = 4;
            // 
            // panelBtnCheck
            // 
            this.panelBtnCheck.BackColor = System.Drawing.Color.Transparent;
            this.panelBtnCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnCheck.Location = new System.Drawing.Point(0, 0);
            this.panelBtnCheck.Name = "panelBtnCheck";
            this.panelBtnCheck.ShadowDecoration.Parent = this.panelBtnCheck;
            this.panelBtnCheck.Size = new System.Drawing.Size(220, 50);
            this.panelBtnCheck.TabIndex = 21;
            this.panelBtnCheck.UseTransparentBackground = true;
            this.panelBtnCheck.Visible = false;
            // 
            // buttonDriver
            // 
            this.buttonDriver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDriver.FlatAppearance.BorderSize = 0;
            this.buttonDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDriver.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonDriver.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDriver.ForeColor = System.Drawing.Color.White;
            this.buttonDriver.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.buttonDriver.IconColor = System.Drawing.Color.DarkGray;
            this.buttonDriver.IconSize = 30;
            this.buttonDriver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDriver.Location = new System.Drawing.Point(0, 0);
            this.buttonDriver.Name = "buttonDriver";
            this.buttonDriver.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonDriver.Rotation = 0D;
            this.buttonDriver.Size = new System.Drawing.Size(220, 50);
            this.buttonDriver.TabIndex = 3;
            this.buttonDriver.Text = "    Paket";
            this.buttonDriver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDriver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDriver.UseVisualStyleBackColor = true;
            this.buttonDriver.Click += new System.EventHandler(this.ButtonDriver_Click);
            // 
            // panelTransaksi
            // 
            this.panelTransaksi.Controls.Add(this.panel1);
            this.panelTransaksi.Controls.Add(this.panelSubTransaksi);
            this.panelTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransaksi.Location = new System.Drawing.Point(0, 50);
            this.panelTransaksi.Name = "panelTransaksi";
            this.panelTransaksi.Size = new System.Drawing.Size(220, 50);
            this.panelTransaksi.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelBtnTransaksi);
            this.panel1.Controls.Add(this.buttonTransaksi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 50);
            this.panel1.TabIndex = 6;
            // 
            // panelBtnTransaksi
            // 
            this.panelBtnTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.panelBtnTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnTransaksi.Location = new System.Drawing.Point(0, 0);
            this.panelBtnTransaksi.Name = "panelBtnTransaksi";
            this.panelBtnTransaksi.ShadowDecoration.Parent = this.panelBtnTransaksi;
            this.panelBtnTransaksi.Size = new System.Drawing.Size(220, 50);
            this.panelBtnTransaksi.TabIndex = 20;
            this.panelBtnTransaksi.UseTransparentBackground = true;
            this.panelBtnTransaksi.Visible = false;
            // 
            // buttonTransaksi
            // 
            this.buttonTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransaksi.FlatAppearance.BorderSize = 0;
            this.buttonTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransaksi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonTransaksi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonTransaksi.ForeColor = System.Drawing.Color.White;
            this.buttonTransaksi.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.buttonTransaksi.IconColor = System.Drawing.Color.DarkGray;
            this.buttonTransaksi.IconSize = 30;
            this.buttonTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransaksi.Location = new System.Drawing.Point(0, 0);
            this.buttonTransaksi.Name = "buttonTransaksi";
            this.buttonTransaksi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonTransaksi.Rotation = 0D;
            this.buttonTransaksi.Size = new System.Drawing.Size(220, 50);
            this.buttonTransaksi.TabIndex = 1;
            this.buttonTransaksi.Text = "    Transaksi";
            this.buttonTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTransaksi.UseVisualStyleBackColor = true;
            this.buttonTransaksi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonTransaksi_MouseDown);
            // 
            // panelSubTransaksi
            // 
            this.panelSubTransaksi.Controls.Add(this.buttonBukti);
            this.panelSubTransaksi.Controls.Add(this.buttonPembelian);
            this.panelSubTransaksi.Controls.Add(this.buttonPenjualan);
            this.panelSubTransaksi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSubTransaksi.Location = new System.Drawing.Point(0, -100);
            this.panelSubTransaksi.Name = "panelSubTransaksi";
            this.panelSubTransaksi.Size = new System.Drawing.Size(220, 150);
            this.panelSubTransaksi.TabIndex = 5;
            // 
            // buttonBukti
            // 
            this.buttonBukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBukti.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBukti.FlatAppearance.BorderSize = 0;
            this.buttonBukti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBukti.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonBukti.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBukti.ForeColor = System.Drawing.Color.White;
            this.buttonBukti.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonBukti.IconColor = System.Drawing.Color.DarkGray;
            this.buttonBukti.IconSize = 30;
            this.buttonBukti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBukti.Location = new System.Drawing.Point(0, 100);
            this.buttonBukti.Name = "buttonBukti";
            this.buttonBukti.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonBukti.Rotation = 0D;
            this.buttonBukti.Size = new System.Drawing.Size(220, 50);
            this.buttonBukti.TabIndex = 7;
            this.buttonBukti.Text = "       History Saldo";
            this.buttonBukti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBukti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBukti.UseVisualStyleBackColor = true;
            this.buttonBukti.Click += new System.EventHandler(this.ButtonHistorySaldo_Click);
            // 
            // buttonPembelian
            // 
            this.buttonPembelian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPembelian.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPembelian.FlatAppearance.BorderSize = 0;
            this.buttonPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPembelian.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonPembelian.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPembelian.ForeColor = System.Drawing.Color.White;
            this.buttonPembelian.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonPembelian.IconColor = System.Drawing.Color.DarkGray;
            this.buttonPembelian.IconSize = 30;
            this.buttonPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPembelian.Location = new System.Drawing.Point(0, 50);
            this.buttonPembelian.Name = "buttonPembelian";
            this.buttonPembelian.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonPembelian.Rotation = 0D;
            this.buttonPembelian.Size = new System.Drawing.Size(220, 50);
            this.buttonPembelian.TabIndex = 6;
            this.buttonPembelian.Text = "       Pembelian";
            this.buttonPembelian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPembelian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPembelian.UseVisualStyleBackColor = true;
            this.buttonPembelian.Click += new System.EventHandler(this.ButtonPembelian_Click);
            // 
            // buttonPenjualan
            // 
            this.buttonPenjualan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPenjualan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPenjualan.FlatAppearance.BorderSize = 0;
            this.buttonPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPenjualan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonPenjualan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPenjualan.ForeColor = System.Drawing.Color.White;
            this.buttonPenjualan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonPenjualan.IconColor = System.Drawing.Color.DarkGray;
            this.buttonPenjualan.IconSize = 30;
            this.buttonPenjualan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPenjualan.Location = new System.Drawing.Point(0, 0);
            this.buttonPenjualan.Name = "buttonPenjualan";
            this.buttonPenjualan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonPenjualan.Rotation = 0D;
            this.buttonPenjualan.Size = new System.Drawing.Size(220, 50);
            this.buttonPenjualan.TabIndex = 5;
            this.buttonPenjualan.Text = "       Penjualan";
            this.buttonPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPenjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPenjualan.UseVisualStyleBackColor = true;
            this.buttonPenjualan.Click += new System.EventHandler(this.ButtonPenjualan_Click);
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.panel2);
            this.panelMaster.Controls.Add(this.panelSubMaster);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaster.Location = new System.Drawing.Point(0, 0);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(220, 50);
            this.panelMaster.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelBtnMaster);
            this.panel2.Controls.Add(this.buttonMaster);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 50);
            this.panel2.TabIndex = 6;
            // 
            // panelBtnMaster
            // 
            this.panelBtnMaster.BackColor = System.Drawing.Color.Transparent;
            this.panelBtnMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtnMaster.Location = new System.Drawing.Point(0, 0);
            this.panelBtnMaster.Name = "panelBtnMaster";
            this.panelBtnMaster.ShadowDecoration.Parent = this.panelBtnMaster;
            this.panelBtnMaster.Size = new System.Drawing.Size(220, 50);
            this.panelBtnMaster.TabIndex = 4;
            this.panelBtnMaster.UseTransparentBackground = true;
            this.panelBtnMaster.Visible = false;
            // 
            // buttonMaster
            // 
            this.buttonMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaster.FlatAppearance.BorderSize = 0;
            this.buttonMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaster.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMaster.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaster.ForeColor = System.Drawing.Color.White;
            this.buttonMaster.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.buttonMaster.IconColor = System.Drawing.Color.DarkGray;
            this.buttonMaster.IconSize = 30;
            this.buttonMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaster.Location = new System.Drawing.Point(0, 0);
            this.buttonMaster.Name = "buttonMaster";
            this.buttonMaster.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonMaster.Rotation = 0D;
            this.buttonMaster.Size = new System.Drawing.Size(220, 50);
            this.buttonMaster.TabIndex = 1;
            this.buttonMaster.Text = "    Master";
            this.buttonMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMaster.UseVisualStyleBackColor = true;
            this.buttonMaster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMaster_MouseDown);
            // 
            // panelSubMaster
            // 
            this.panelSubMaster.Controls.Add(this.buttonPengiriman);
            this.panelSubMaster.Controls.Add(this.buttonSupplier);
            this.panelSubMaster.Controls.Add(this.buttonPelanggan);
            this.panelSubMaster.Controls.Add(this.buttonPegawai);
            this.panelSubMaster.Controls.Add(this.buttonJabatan);
            this.panelSubMaster.Controls.Add(this.buttonBarang);
            this.panelSubMaster.Controls.Add(this.buttonKategori);
            this.panelSubMaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSubMaster.Location = new System.Drawing.Point(0, -300);
            this.panelSubMaster.Name = "panelSubMaster";
            this.panelSubMaster.Size = new System.Drawing.Size(220, 350);
            this.panelSubMaster.TabIndex = 5;
            // 
            // buttonPengiriman
            // 
            this.buttonPengiriman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPengiriman.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengiriman.FlatAppearance.BorderSize = 0;
            this.buttonPengiriman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengiriman.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonPengiriman.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPengiriman.ForeColor = System.Drawing.Color.White;
            this.buttonPengiriman.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonPengiriman.IconColor = System.Drawing.Color.DarkGray;
            this.buttonPengiriman.IconSize = 30;
            this.buttonPengiriman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengiriman.Location = new System.Drawing.Point(0, 300);
            this.buttonPengiriman.Name = "buttonPengiriman";
            this.buttonPengiriman.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonPengiriman.Rotation = 0D;
            this.buttonPengiriman.Size = new System.Drawing.Size(220, 50);
            this.buttonPengiriman.TabIndex = 14;
            this.buttonPengiriman.Text = "       Pengiriman";
            this.buttonPengiriman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengiriman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPengiriman.UseVisualStyleBackColor = true;
            this.buttonPengiriman.Click += new System.EventHandler(this.ButtonPengiriman_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSupplier.FlatAppearance.BorderSize = 0;
            this.buttonSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupplier.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplier.ForeColor = System.Drawing.Color.White;
            this.buttonSupplier.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSupplier.IconColor = System.Drawing.Color.DarkGray;
            this.buttonSupplier.IconSize = 30;
            this.buttonSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupplier.Location = new System.Drawing.Point(0, 250);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonSupplier.Rotation = 0D;
            this.buttonSupplier.Size = new System.Drawing.Size(220, 50);
            this.buttonSupplier.TabIndex = 13;
            this.buttonSupplier.Text = "       Supplier";
            this.buttonSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.ButtonSupplier_Click);
            // 
            // buttonPelanggan
            // 
            this.buttonPelanggan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPelanggan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPelanggan.FlatAppearance.BorderSize = 0;
            this.buttonPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPelanggan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonPelanggan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPelanggan.ForeColor = System.Drawing.Color.White;
            this.buttonPelanggan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonPelanggan.IconColor = System.Drawing.Color.DarkGray;
            this.buttonPelanggan.IconSize = 30;
            this.buttonPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPelanggan.Location = new System.Drawing.Point(0, 200);
            this.buttonPelanggan.Name = "buttonPelanggan";
            this.buttonPelanggan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonPelanggan.Rotation = 0D;
            this.buttonPelanggan.Size = new System.Drawing.Size(220, 50);
            this.buttonPelanggan.TabIndex = 12;
            this.buttonPelanggan.Text = "       Pelanggan";
            this.buttonPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPelanggan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPelanggan.UseVisualStyleBackColor = true;
            this.buttonPelanggan.Click += new System.EventHandler(this.ButtonPelanggan_Click);
            // 
            // buttonPegawai
            // 
            this.buttonPegawai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPegawai.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPegawai.FlatAppearance.BorderSize = 0;
            this.buttonPegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPegawai.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonPegawai.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPegawai.ForeColor = System.Drawing.Color.White;
            this.buttonPegawai.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonPegawai.IconColor = System.Drawing.Color.DarkGray;
            this.buttonPegawai.IconSize = 30;
            this.buttonPegawai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPegawai.Location = new System.Drawing.Point(0, 150);
            this.buttonPegawai.Name = "buttonPegawai";
            this.buttonPegawai.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonPegawai.Rotation = 0D;
            this.buttonPegawai.Size = new System.Drawing.Size(220, 50);
            this.buttonPegawai.TabIndex = 11;
            this.buttonPegawai.Text = "       Pegawai";
            this.buttonPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPegawai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPegawai.UseVisualStyleBackColor = true;
            this.buttonPegawai.Click += new System.EventHandler(this.ButtonPegawai_Click);
            // 
            // buttonJabatan
            // 
            this.buttonJabatan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJabatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonJabatan.FlatAppearance.BorderSize = 0;
            this.buttonJabatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJabatan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonJabatan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJabatan.ForeColor = System.Drawing.Color.White;
            this.buttonJabatan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonJabatan.IconColor = System.Drawing.Color.DarkGray;
            this.buttonJabatan.IconSize = 30;
            this.buttonJabatan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonJabatan.Location = new System.Drawing.Point(0, 100);
            this.buttonJabatan.Name = "buttonJabatan";
            this.buttonJabatan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonJabatan.Rotation = 0D;
            this.buttonJabatan.Size = new System.Drawing.Size(220, 50);
            this.buttonJabatan.TabIndex = 10;
            this.buttonJabatan.Text = "       Jabatan";
            this.buttonJabatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonJabatan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonJabatan.UseVisualStyleBackColor = true;
            this.buttonJabatan.Click += new System.EventHandler(this.ButtonJabatan_Click);
            // 
            // buttonBarang
            // 
            this.buttonBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBarang.FlatAppearance.BorderSize = 0;
            this.buttonBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonBarang.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBarang.ForeColor = System.Drawing.Color.White;
            this.buttonBarang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonBarang.IconColor = System.Drawing.Color.DarkGray;
            this.buttonBarang.IconSize = 30;
            this.buttonBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBarang.Location = new System.Drawing.Point(0, 50);
            this.buttonBarang.Name = "buttonBarang";
            this.buttonBarang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonBarang.Rotation = 0D;
            this.buttonBarang.Size = new System.Drawing.Size(220, 50);
            this.buttonBarang.TabIndex = 9;
            this.buttonBarang.Text = "       Barang";
            this.buttonBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBarang.UseVisualStyleBackColor = true;
            this.buttonBarang.Click += new System.EventHandler(this.ButtonBarang_Click);
            // 
            // buttonKategori
            // 
            this.buttonKategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKategori.FlatAppearance.BorderSize = 0;
            this.buttonKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKategori.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonKategori.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKategori.ForeColor = System.Drawing.Color.White;
            this.buttonKategori.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonKategori.IconColor = System.Drawing.Color.DarkGray;
            this.buttonKategori.IconSize = 30;
            this.buttonKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKategori.Location = new System.Drawing.Point(0, 0);
            this.buttonKategori.Name = "buttonKategori";
            this.buttonKategori.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonKategori.Rotation = 0D;
            this.buttonKategori.Size = new System.Drawing.Size(220, 50);
            this.buttonKategori.TabIndex = 8;
            this.buttonKategori.Text = "       Kategori";
            this.buttonKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKategori.UseVisualStyleBackColor = true;
            this.buttonKategori.Click += new System.EventHandler(this.ButtonKategori_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.buttonHome);
            this.panelLogo.Controls.Add(this.guna2Separator1);
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.labelNamaPanggil);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 121);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.ShadowDecoration.Parent = this.buttonHome;
            this.buttonHome.Size = new System.Drawing.Size(220, 121);
            this.buttonHome.TabIndex = 17;
            this.buttonHome.UseTransparentBackground = true;
            this.buttonHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHome_MouseDown);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 113);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(220, 10);
            this.guna2Separator1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.HotPink;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "STOREPEDIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 64);
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
            this.labelNamaPanggil.Location = new System.Drawing.Point(9, 90);
            this.labelNamaPanggil.Name = "labelNamaPanggil";
            this.labelNamaPanggil.Size = new System.Drawing.Size(39, 20);
            this.labelNamaPanggil.TabIndex = 5;
            this.labelNamaPanggil.Text = "user";
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
            this.buttonMin.Location = new System.Drawing.Point(800, 0);
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
            this.buttonMax.Location = new System.Drawing.Point(848, 0);
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
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.panelTopBar.Controls.Add(this.buttonMin);
            this.panelTopBar.Controls.Add(this.buttonMax);
            this.panelTopBar.Controls.Add(this.buttonClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(3, 3);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(950, 34);
            this.panelTopBar.TabIndex = 3;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTopBar_MouseDown);
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
            this.buttonClose.Location = new System.Drawing.Point(899, 0);
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
            // FormMasterUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(956, 581);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(944, 581);
            this.Name = "FormMasterUtama";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storepedia";
            this.Load += new System.EventHandler(this.FormMasterUtama_Load);
            this.panelForm.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.panelPengiriman.ResumeLayout(false);
            this.panelTransaksi.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelSubTransaksi.ResumeLayout(false);
            this.panelMaster.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelSubMaster.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelNamaPanggil;
        private FontAwesome.Sharp.IconButton buttonMin;
        private FontAwesome.Sharp.IconButton buttonMax;
        private System.Windows.Forms.Panel panelTopBar;
        private FontAwesome.Sharp.IconButton buttonClose;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Panel panelTransaksi;
        private System.Windows.Forms.Panel panelSubTransaksi;
        private FontAwesome.Sharp.IconButton buttonBukti;
        private FontAwesome.Sharp.IconButton buttonPembelian;
        private FontAwesome.Sharp.IconButton buttonPenjualan;
        private Guna.UI2.WinForms.Guna2Panel panelBtnMaster;
        private Guna.UI2.WinForms.Guna2Panel buttonHome;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panelSubMaster;
        private FontAwesome.Sharp.IconButton buttonPengiriman;
        private FontAwesome.Sharp.IconButton buttonSupplier;
        private FontAwesome.Sharp.IconButton buttonPelanggan;
        private FontAwesome.Sharp.IconButton buttonPegawai;
        private FontAwesome.Sharp.IconButton buttonJabatan;
        private FontAwesome.Sharp.IconButton buttonBarang;
        private FontAwesome.Sharp.IconButton buttonKategori;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel panelBtnTransaksi;
        private FontAwesome.Sharp.IconButton buttonTransaksi;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton buttonMaster;
        private System.Windows.Forms.Panel panelPengiriman;
        private Guna.UI2.WinForms.Guna2Panel panelBtnCheck;
        private FontAwesome.Sharp.IconButton buttonDriver;
    }
}