namespace pbd_5_AplikasiStorepedia
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDaftar = new System.Windows.Forms.Label();
            this.panelLayout = new System.Windows.Forms.Panel();
            this.labelLupaPass = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelCredits = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pictureBoxShowPass = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.buttonMin = new FontAwesome.Sharp.IconButton();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.dragFormLogin = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timerRetry = new System.Windows.Forms.Timer(this.components);
            this.panelLayout.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(87, 133);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(173, 20);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TabStop = false;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.TextBoxUsername_TextChanged);
            this.textBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsername_KeyPress);
            this.textBoxUsername.Leave += new System.EventHandler(this.TextBoxUsername_Leave);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonLogin.FlatAppearance.BorderSize = 3;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(125, 303);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(114, 36);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.ButtonLogin_MouseLeave);
            this.buttonLogin.MouseHover += new System.EventHandler(this.ButtonLogin_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tidak punya akun?";
            // 
            // labelDaftar
            // 
            this.labelDaftar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDaftar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDaftar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelDaftar.Location = new System.Drawing.Point(213, 357);
            this.labelDaftar.Name = "labelDaftar";
            this.labelDaftar.Size = new System.Drawing.Size(66, 29);
            this.labelDaftar.TabIndex = 3;
            this.labelDaftar.Text = "Daftar";
            this.labelDaftar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDaftar.Click += new System.EventHandler(this.LabelDaftar_Click);
            this.labelDaftar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelDaftar_MouseDown);
            this.labelDaftar.MouseEnter += new System.EventHandler(this.LabelDaftar_MouseEnter);
            this.labelDaftar.MouseLeave += new System.EventHandler(this.LabelDaftar_MouseLeave);
            // 
            // panelLayout
            // 
            this.panelLayout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelLayout.BackColor = System.Drawing.Color.White;
            this.panelLayout.Controls.Add(this.labelLupaPass);
            this.panelLayout.Controls.Add(this.guna2Panel1);
            this.panelLayout.Controls.Add(this.pictureBox2);
            this.panelLayout.Controls.Add(this.labelCredits);
            this.panelLayout.Controls.Add(this.lblUsername);
            this.panelLayout.Controls.Add(this.lblPass);
            this.panelLayout.Controls.Add(this.label3);
            this.panelLayout.Controls.Add(this.pictureBoxShowPass);
            this.panelLayout.Controls.Add(this.label1);
            this.panelLayout.Controls.Add(this.labelPass);
            this.panelLayout.Controls.Add(this.textBoxPass);
            this.panelLayout.Controls.Add(this.labelUsername);
            this.panelLayout.Controls.Add(this.label4);
            this.panelLayout.Controls.Add(this.label2);
            this.panelLayout.Controls.Add(this.labelDaftar);
            this.panelLayout.Controls.Add(this.buttonLogin);
            this.panelLayout.Controls.Add(this.textBoxUsername);
            this.panelLayout.Location = new System.Drawing.Point(34, 62);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(371, 506);
            this.panelLayout.TabIndex = 0;
            // 
            // labelLupaPass
            // 
            this.labelLupaPass.AutoSize = true;
            this.labelLupaPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLupaPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLupaPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLupaPass.Location = new System.Drawing.Point(204, 248);
            this.labelLupaPass.Name = "labelLupaPass";
            this.labelLupaPass.Size = new System.Drawing.Size(102, 15);
            this.labelLupaPass.TabIndex = 73;
            this.labelLupaPass.Text = "Lupa password?";
            this.labelLupaPass.Click += new System.EventHandler(this.LabelLupaPass_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Location = new System.Drawing.Point(146, 51);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(106, 23);
            this.guna2Panel1.TabIndex = 55;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.HotPink;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "TOREPEDIA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pbd_5_AplikasiStorepedia.Properties.Resources.Storepedia_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(115, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCredits.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelCredits.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCredits.Location = new System.Drawing.Point(164, 471);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(51, 16);
            this.labelCredits.TabIndex = 2;
            this.labelCredits.Text = "Credits";
            this.labelCredits.Click += new System.EventHandler(this.LabelCredits_Click);
            this.labelCredits.MouseEnter += new System.EventHandler(this.LabelCredits_MouseEnter);
            this.labelCredits.MouseLeave += new System.EventHandler(this.LabelCredits_MouseLeave);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(86, 158);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(127, 15);
            this.lblUsername.TabIndex = 53;
            this.lblUsername.Text = "Username harus diisi.";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(86, 228);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(123, 15);
            this.lblPass.TabIndex = 52;
            this.lblPass.Text = "Password harus diisi.";
            // 
            // pictureBoxShowPass
            // 
            this.pictureBoxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShowPass.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShowPass.Image")));
            this.pictureBoxShowPass.Location = new System.Drawing.Point(284, 201);
            this.pictureBoxShowPass.Name = "pictureBoxShowPass";
            this.pictureBoxShowPass.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShowPass.TabIndex = 50;
            this.pictureBoxShowPass.TabStop = false;
            this.pictureBoxShowPass.Tag = "eyeClose";
            this.pictureBoxShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxShowPass_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(131, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "© 2020 Storepedia";
            // 
            // labelPass
            // 
            this.labelPass.BackColor = System.Drawing.Color.Black;
            this.labelPass.Location = new System.Drawing.Point(86, 224);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(176, 1);
            this.labelPass.TabIndex = 12;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxPass.Location = new System.Drawing.Point(87, 201);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(174, 20);
            this.textBoxPass.TabIndex = 1;
            this.textBoxPass.TabStop = false;
            this.textBoxPass.TextChanged += new System.EventHandler(this.TextBoxPass_TextChanged);
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPass_KeyPress);
            this.textBoxPass.Leave += new System.EventHandler(this.TextBoxPass_Leave);
            // 
            // labelUsername
            // 
            this.labelUsername.BackColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(86, 156);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(175, 1);
            this.labelUsername.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(84, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(83, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.BlinkRate = 0;
            this.errorProviderLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLogin.ContainerControl = this;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.panelTopBar.Controls.Add(this.buttonMin);
            this.panelTopBar.Controls.Add(this.buttonClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(435, 34);
            this.panelTopBar.TabIndex = 1;
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
            this.buttonMin.Location = new System.Drawing.Point(336, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Rotation = 0D;
            this.buttonMin.Size = new System.Drawing.Size(48, 34);
            this.buttonMin.TabIndex = 7;
            this.buttonMin.TabStop = false;
            this.buttonMin.Text = "⎯";
            this.buttonMin.UseCompatibleTextRendering = true;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            this.buttonMin.MouseEnter += new System.EventHandler(this.MouseEntering);
            this.buttonMin.MouseLeave += new System.EventHandler(this.MouseLeaving);
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
            this.buttonClose.Location = new System.Drawing.Point(384, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Rotation = 0D;
            this.buttonClose.Size = new System.Drawing.Size(51, 34);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.MouseEntering);
            this.buttonClose.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // dragFormLogin
            // 
            this.dragFormLogin.ContainerControl = this;
            this.dragFormLogin.TargetControl = this.panelTopBar;
            // 
            // timerRetry
            // 
            this.timerRetry.Interval = 1000;
            this.timerRetry.Tick += new System.EventHandler(this.TimerRetry_Tick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(435, 599);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelLayout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storepedia";
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDaftar;
        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxShowPass;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Panel panelTopBar;
        private FontAwesome.Sharp.IconButton buttonMin;
        private FontAwesome.Sharp.IconButton buttonClose;
        private Guna.UI2.WinForms.Guna2DragControl dragFormLogin;
        private System.Windows.Forms.Label labelCredits;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Timer timerRetry;
        private System.Windows.Forms.Label labelLupaPass;
    }
}

