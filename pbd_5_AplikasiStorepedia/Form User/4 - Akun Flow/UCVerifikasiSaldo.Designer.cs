namespace pbd_5_AplikasiStorepedia
{
    partial class UCVerifikasiSaldo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.buttonBayar = new Guna.UI2.WinForms.Guna2Button();
            this.panelSaldo = new System.Windows.Forms.Panel();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelTotalBayar = new System.Windows.Forms.Label();
            this.flowLayoutPanelVerifikasi = new System.Windows.Forms.FlowLayoutPanel();
            this.panelVerifikasi = new System.Windows.Forms.Panel();
            this.pictureBoxBukti = new Guna.UI2.WinForms.Guna2PictureBox();
            this.textBoxNamaPemilik = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxDariBank = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxNoRekening = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxKeBank = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonContoh = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNoRekening = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelCabang = new System.Windows.Forms.Label();
            this.labelNamaRekening = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSaldo.SuspendLayout();
            this.flowLayoutPanelVerifikasi.SuspendLayout();
            this.panelVerifikasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBukti)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(398, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 131;
            this.label8.Text = "Total Bayar";
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 10;
            // 
            // buttonBayar
            // 
            this.buttonBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBayar.CheckedState.Parent = this.buttonBayar;
            this.buttonBayar.CustomImages.Parent = this.buttonBayar;
            this.buttonBayar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonBayar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBayar.ForeColor = System.Drawing.Color.White;
            this.buttonBayar.HoverState.Parent = this.buttonBayar;
            this.buttonBayar.Location = new System.Drawing.Point(482, 19);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.ShadowDecoration.Parent = this.buttonBayar;
            this.buttonBayar.Size = new System.Drawing.Size(191, 39);
            this.buttonBayar.TabIndex = 132;
            this.buttonBayar.TabStop = false;
            this.buttonBayar.Text = "Bayar";
            this.buttonBayar.Click += new System.EventHandler(this.ButtonBayar_Click);
            // 
            // panelSaldo
            // 
            this.panelSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelSaldo.Controls.Add(this.buttonBack);
            this.panelSaldo.Controls.Add(this.label1);
            this.panelSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaldo.Location = new System.Drawing.Point(0, 0);
            this.panelSaldo.Name = "panelSaldo";
            this.panelSaldo.Size = new System.Drawing.Size(700, 53);
            this.panelSaldo.TabIndex = 122;
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonBack.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.buttonBack.IconColor = System.Drawing.Color.White;
            this.buttonBack.IconSize = 25;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Rotation = 0D;
            this.buttonBack.Size = new System.Drawing.Size(52, 53);
            this.buttonBack.TabIndex = 55;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = " ";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.ButtonBack_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.ButtonBack_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Verifikasi";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(700, 10);
            this.guna2Separator2.TabIndex = 128;
            // 
            // labelTotalBayar
            // 
            this.labelTotalBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalBayar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBayar.ForeColor = System.Drawing.Color.Maroon;
            this.labelTotalBayar.Location = new System.Drawing.Point(206, 37);
            this.labelTotalBayar.Name = "labelTotalBayar";
            this.labelTotalBayar.Size = new System.Drawing.Size(267, 21);
            this.labelTotalBayar.TabIndex = 134;
            this.labelTotalBayar.Text = "Rp 0";
            this.labelTotalBayar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanelVerifikasi
            // 
            this.flowLayoutPanelVerifikasi.AutoScroll = true;
            this.flowLayoutPanelVerifikasi.Controls.Add(this.panelVerifikasi);
            this.flowLayoutPanelVerifikasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelVerifikasi.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelVerifikasi.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanelVerifikasi.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelVerifikasi.Name = "flowLayoutPanelVerifikasi";
            this.flowLayoutPanelVerifikasi.Size = new System.Drawing.Size(700, 413);
            this.flowLayoutPanelVerifikasi.TabIndex = 139;
            this.flowLayoutPanelVerifikasi.WrapContents = false;
            // 
            // panelVerifikasi
            // 
            this.panelVerifikasi.Controls.Add(this.pictureBoxBukti);
            this.panelVerifikasi.Controls.Add(this.textBoxNamaPemilik);
            this.panelVerifikasi.Controls.Add(this.textBoxDariBank);
            this.panelVerifikasi.Controls.Add(this.textBoxNoRekening);
            this.panelVerifikasi.Controls.Add(this.textBoxKeBank);
            this.panelVerifikasi.Controls.Add(this.label4);
            this.panelVerifikasi.Controls.Add(this.label10);
            this.panelVerifikasi.Controls.Add(this.label16);
            this.panelVerifikasi.Controls.Add(this.label13);
            this.panelVerifikasi.Controls.Add(this.label11);
            this.panelVerifikasi.Controls.Add(this.labelJumlah);
            this.panelVerifikasi.Controls.Add(this.guna2Separator1);
            this.panelVerifikasi.Controls.Add(this.guna2Separator3);
            this.panelVerifikasi.Controls.Add(this.labelUsername);
            this.panelVerifikasi.Controls.Add(this.label12);
            this.panelVerifikasi.Controls.Add(this.label7);
            this.panelVerifikasi.Controls.Add(this.label2);
            this.panelVerifikasi.Controls.Add(this.buttonContoh);
            this.panelVerifikasi.Controls.Add(this.label3);
            this.panelVerifikasi.Controls.Add(this.label6);
            this.panelVerifikasi.Controls.Add(this.label15);
            this.panelVerifikasi.Controls.Add(this.label9);
            this.panelVerifikasi.Controls.Add(this.label5);
            this.panelVerifikasi.Controls.Add(this.labelNoRekening);
            this.panelVerifikasi.Controls.Add(this.label14);
            this.panelVerifikasi.Controls.Add(this.labelCabang);
            this.panelVerifikasi.Controls.Add(this.labelNamaRekening);
            this.panelVerifikasi.Controls.Add(this.labelPath);
            this.panelVerifikasi.Location = new System.Drawing.Point(0, 0);
            this.panelVerifikasi.Margin = new System.Windows.Forms.Padding(0);
            this.panelVerifikasi.Name = "panelVerifikasi";
            this.panelVerifikasi.Size = new System.Drawing.Size(680, 693);
            this.panelVerifikasi.TabIndex = 140;
            // 
            // pictureBoxBukti
            // 
            this.pictureBoxBukti.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBukti.BorderRadius = 1;
            this.pictureBoxBukti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBukti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBukti.Location = new System.Drawing.Point(273, 316);
            this.pictureBoxBukti.Name = "pictureBoxBukti";
            this.pictureBoxBukti.ShadowDecoration.Parent = this.pictureBoxBukti;
            this.pictureBoxBukti.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxBukti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBukti.TabIndex = 149;
            this.pictureBoxBukti.TabStop = false;
            this.pictureBoxBukti.UseTransparentBackground = true;
            this.pictureBoxBukti.Click += new System.EventHandler(this.PictureBoxBukti_Click);
            // 
            // textBoxNamaPemilik
            // 
            this.textBoxNamaPemilik.BorderColor = System.Drawing.Color.Black;
            this.textBoxNamaPemilik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNamaPemilik.DefaultText = "";
            this.textBoxNamaPemilik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNamaPemilik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNamaPemilik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNamaPemilik.DisabledState.Parent = this.textBoxNamaPemilik;
            this.textBoxNamaPemilik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNamaPemilik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNamaPemilik.FocusedState.Parent = this.textBoxNamaPemilik;
            this.textBoxNamaPemilik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaPemilik.ForeColor = System.Drawing.Color.Black;
            this.textBoxNamaPemilik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNamaPemilik.HoverState.Parent = this.textBoxNamaPemilik;
            this.textBoxNamaPemilik.Location = new System.Drawing.Point(269, 514);
            this.textBoxNamaPemilik.MaxLength = 45;
            this.textBoxNamaPemilik.Name = "textBoxNamaPemilik";
            this.textBoxNamaPemilik.PasswordChar = '\0';
            this.textBoxNamaPemilik.PlaceholderText = "";
            this.textBoxNamaPemilik.SelectedText = "";
            this.textBoxNamaPemilik.ShadowDecoration.Parent = this.textBoxNamaPemilik;
            this.textBoxNamaPemilik.Size = new System.Drawing.Size(197, 20);
            this.textBoxNamaPemilik.TabIndex = 148;
            this.textBoxNamaPemilik.Enter += new System.EventHandler(this.EnterTextBox);
            // 
            // textBoxDariBank
            // 
            this.textBoxDariBank.BorderColor = System.Drawing.Color.Black;
            this.textBoxDariBank.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDariBank.DefaultText = "";
            this.textBoxDariBank.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxDariBank.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxDariBank.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDariBank.DisabledState.Parent = this.textBoxDariBank;
            this.textBoxDariBank.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxDariBank.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDariBank.FocusedState.Parent = this.textBoxDariBank;
            this.textBoxDariBank.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDariBank.ForeColor = System.Drawing.Color.Black;
            this.textBoxDariBank.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxDariBank.HoverState.Parent = this.textBoxDariBank;
            this.textBoxDariBank.Location = new System.Drawing.Point(269, 546);
            this.textBoxDariBank.MaxLength = 45;
            this.textBoxDariBank.Name = "textBoxDariBank";
            this.textBoxDariBank.PasswordChar = '\0';
            this.textBoxDariBank.PlaceholderText = "";
            this.textBoxDariBank.SelectedText = "";
            this.textBoxDariBank.ShadowDecoration.Parent = this.textBoxDariBank;
            this.textBoxDariBank.Size = new System.Drawing.Size(197, 20);
            this.textBoxDariBank.TabIndex = 148;
            this.textBoxDariBank.Enter += new System.EventHandler(this.EnterTextBox);
            // 
            // textBoxNoRekening
            // 
            this.textBoxNoRekening.BorderColor = System.Drawing.Color.Black;
            this.textBoxNoRekening.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNoRekening.DefaultText = "";
            this.textBoxNoRekening.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNoRekening.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNoRekening.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNoRekening.DisabledState.Parent = this.textBoxNoRekening;
            this.textBoxNoRekening.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNoRekening.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNoRekening.FocusedState.Parent = this.textBoxNoRekening;
            this.textBoxNoRekening.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoRekening.ForeColor = System.Drawing.Color.Black;
            this.textBoxNoRekening.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNoRekening.HoverState.Parent = this.textBoxNoRekening;
            this.textBoxNoRekening.Location = new System.Drawing.Point(269, 578);
            this.textBoxNoRekening.MaxLength = 45;
            this.textBoxNoRekening.Name = "textBoxNoRekening";
            this.textBoxNoRekening.PasswordChar = '\0';
            this.textBoxNoRekening.PlaceholderText = "";
            this.textBoxNoRekening.SelectedText = "";
            this.textBoxNoRekening.ShadowDecoration.Parent = this.textBoxNoRekening;
            this.textBoxNoRekening.Size = new System.Drawing.Size(197, 20);
            this.textBoxNoRekening.TabIndex = 148;
            this.textBoxNoRekening.Enter += new System.EventHandler(this.EnterTextBox);
            this.textBoxNoRekening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNoRekening_KeyPress);
            // 
            // textBoxKeBank
            // 
            this.textBoxKeBank.BorderColor = System.Drawing.Color.Black;
            this.textBoxKeBank.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxKeBank.DefaultText = "CBA";
            this.textBoxKeBank.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxKeBank.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxKeBank.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxKeBank.DisabledState.Parent = this.textBoxKeBank;
            this.textBoxKeBank.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxKeBank.Enabled = false;
            this.textBoxKeBank.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxKeBank.FocusedState.Parent = this.textBoxKeBank;
            this.textBoxKeBank.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeBank.ForeColor = System.Drawing.Color.Black;
            this.textBoxKeBank.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxKeBank.HoverState.Parent = this.textBoxKeBank;
            this.textBoxKeBank.Location = new System.Drawing.Point(269, 612);
            this.textBoxKeBank.Name = "textBoxKeBank";
            this.textBoxKeBank.PasswordChar = '\0';
            this.textBoxKeBank.PlaceholderText = "";
            this.textBoxKeBank.SelectedText = "";
            this.textBoxKeBank.SelectionStart = 3;
            this.textBoxKeBank.ShadowDecoration.Parent = this.textBoxKeBank;
            this.textBoxKeBank.Size = new System.Drawing.Size(197, 20);
            this.textBoxKeBank.TabIndex = 148;
            this.textBoxKeBank.Enter += new System.EventHandler(this.EnterTextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(105, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 142;
            this.label4.Text = "Nama Pemilik Rekening :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(139, 547);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 143;
            this.label10.Text = "Transfer dari Bank :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(114, 645);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 17);
            this.label16.TabIndex = 144;
            this.label16.Text = "Jumlah Ditransfer (Rp) :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(148, 613);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 17);
            this.label13.TabIndex = 144;
            this.label13.Text = "Transfer ke Bank :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(65, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 17);
            this.label11.TabIndex = 144;
            this.label11.Text = "Masukkan No. Rekening Anda :";
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.ForeColor = System.Drawing.Color.DimGray;
            this.labelJumlah.Location = new System.Drawing.Point(277, 646);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(35, 17);
            this.labelJumlah.TabIndex = 147;
            this.labelJumlah.Text = "Rp 0";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(0, 242);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(679, 10);
            this.guna2Separator1.TabIndex = 141;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.Location = new System.Drawing.Point(0, 50);
            this.guna2Separator3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(679, 10);
            this.guna2Separator3.TabIndex = 141;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DimGray;
            this.labelUsername.Location = new System.Drawing.Point(166, 18);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(69, 17);
            this.labelUsername.TabIndex = 139;
            this.labelUsername.Text = "Username";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(27, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 21);
            this.label12.TabIndex = 123;
            this.label12.Text = "Bukti Pembayaran";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 123;
            this.label7.Text = "Bayar Ke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(83, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 140;
            this.label2.Text = "Username :";
            // 
            // buttonContoh
            // 
            this.buttonContoh.BackColor = System.Drawing.Color.Transparent;
            this.buttonContoh.BorderColor = System.Drawing.Color.Gray;
            this.buttonContoh.BorderRadius = 1;
            this.buttonContoh.BorderThickness = 1;
            this.buttonContoh.CheckedState.Parent = this.buttonContoh;
            this.buttonContoh.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.buttonContoh.CustomImages.Parent = this.buttonContoh;
            this.buttonContoh.FillColor = System.Drawing.Color.LightGray;
            this.buttonContoh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContoh.ForeColor = System.Drawing.Color.Black;
            this.buttonContoh.HoverState.Parent = this.buttonContoh;
            this.buttonContoh.Location = new System.Drawing.Point(273, 472);
            this.buttonContoh.Name = "buttonContoh";
            this.buttonContoh.ShadowDecoration.Parent = this.buttonContoh;
            this.buttonContoh.Size = new System.Drawing.Size(150, 23);
            this.buttonContoh.TabIndex = 137;
            this.buttonContoh.TabStop = false;
            this.buttonContoh.Text = "Contoh Bukti Bayar";
            this.buttonContoh.Click += new System.EventHandler(this.ButtonContoh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(59, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 123;
            this.label3.Text = "No.  Rekening :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(97, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 123;
            this.label6.Text = "Cabang :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(85, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 123;
            this.label15.Text = "Tipe Bank :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(47, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 123;
            this.label9.Text = "Nama Rekening :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(170, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 123;
            this.label5.Text = "Upload Bukti :";
            // 
            // labelNoRekening
            // 
            this.labelNoRekening.AutoSize = true;
            this.labelNoRekening.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoRekening.ForeColor = System.Drawing.Color.DimGray;
            this.labelNoRekening.Location = new System.Drawing.Point(165, 113);
            this.labelNoRekening.Name = "labelNoRekening";
            this.labelNoRekening.Size = new System.Drawing.Size(91, 17);
            this.labelNoRekening.TabIndex = 124;
            this.labelNoRekening.Text = "5612161098321";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(165, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 124;
            this.label14.Text = "CBA";
            // 
            // labelCabang
            // 
            this.labelCabang.AutoSize = true;
            this.labelCabang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCabang.ForeColor = System.Drawing.Color.DimGray;
            this.labelCabang.Location = new System.Drawing.Point(165, 141);
            this.labelCabang.Name = "labelCabang";
            this.labelCabang.Size = new System.Drawing.Size(64, 17);
            this.labelCabang.TabIndex = 124;
            this.labelCabang.Text = "Surabaya";
            // 
            // labelNamaRekening
            // 
            this.labelNamaRekening.AutoSize = true;
            this.labelNamaRekening.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaRekening.ForeColor = System.Drawing.Color.DimGray;
            this.labelNamaRekening.Location = new System.Drawing.Point(165, 169);
            this.labelNamaRekening.Name = "labelNamaRekening";
            this.labelNamaRekening.Size = new System.Drawing.Size(150, 17);
            this.labelNamaRekening.TabIndex = 124;
            this.labelNamaRekening.Text = "Storepedia Corporation";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.ForeColor = System.Drawing.Color.DimGray;
            this.labelPath.Location = new System.Drawing.Point(286, 380);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(125, 17);
            this.labelPath.TabIndex = 124;
            this.labelPath.Text = "No Image Selected.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonBayar);
            this.panel2.Controls.Add(this.labelTotalBayar);
            this.panel2.Controls.Add(this.guna2Separator2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 70);
            this.panel2.TabIndex = 142;
            // 
            // UCVerifikasiSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanelVerifikasi);
            this.Controls.Add(this.panelSaldo);
            this.Controls.Add(this.panel2);
            this.Name = "UCVerifikasiSaldo";
            this.Size = new System.Drawing.Size(700, 536);
            this.Load += new System.EventHandler(this.UCVerifikasiSaldo_Load);
            this.Resize += new System.EventHandler(this.UCVerifikasiSaldo_Resize);
            this.panelSaldo.ResumeLayout(false);
            this.panelSaldo.PerformLayout();
            this.flowLayoutPanelVerifikasi.ResumeLayout(false);
            this.panelVerifikasi.ResumeLayout(false);
            this.panelVerifikasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBukti)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timerAnimation;
        public Guna.UI2.WinForms.Guna2Button buttonBayar;
        private System.Windows.Forms.Panel panelSaldo;
        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label labelTotalBayar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVerifikasi;
        private System.Windows.Forms.Panel panelVerifikasi;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button buttonContoh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNoRekening;
        private System.Windows.Forms.Label labelCabang;
        private System.Windows.Forms.Label labelNamaRekening;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelJumlah;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNamaPemilik;
        private Guna.UI2.WinForms.Guna2TextBox textBoxDariBank;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNoRekening;
        private Guna.UI2.WinForms.Guna2TextBox textBoxKeBank;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxBukti;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}
