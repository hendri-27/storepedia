namespace pbd_5_AplikasiStorepedia
{
    partial class UCItemKeranjang
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
            this.pictureBoxBarang = new System.Windows.Forms.PictureBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelNamaBrg = new System.Windows.Forms.Label();
            this.textBoxJum = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonPlus = new FontAwesome.Sharp.IconButton();
            this.buttonMinus = new FontAwesome.Sharp.IconButton();
            this.buttonUbah = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHapus = new Guna.UI2.WinForms.Guna2Button();
            this.panelBarang = new System.Windows.Forms.Panel();
            this.checkBoxItem = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).BeginInit();
            this.panelBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBarang
            // 
            this.pictureBoxBarang.Location = new System.Drawing.Point(86, 12);
            this.pictureBoxBarang.Name = "pictureBoxBarang";
            this.pictureBoxBarang.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBarang.TabIndex = 0;
            this.pictureBoxBarang.TabStop = false;
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.ForeColor = System.Drawing.Color.DarkRed;
            this.labelHarga.Location = new System.Drawing.Point(258, 68);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(41, 23);
            this.labelHarga.TabIndex = 20;
            this.labelHarga.Text = "Rp0";
            // 
            // labelNamaBrg
            // 
            this.labelNamaBrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNamaBrg.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaBrg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBrg.Location = new System.Drawing.Point(258, 16);
            this.labelNamaBrg.Name = "labelNamaBrg";
            this.labelNamaBrg.Size = new System.Drawing.Size(300, 43);
            this.labelNamaBrg.TabIndex = 19;
            this.labelNamaBrg.Text = "Nama Produk";
            // 
            // textBoxJum
            // 
            this.textBoxJum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxJum.DefaultText = "1";
            this.textBoxJum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxJum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxJum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxJum.DisabledState.Parent = this.textBoxJum;
            this.textBoxJum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxJum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.textBoxJum.FocusedState.Parent = this.textBoxJum;
            this.textBoxJum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxJum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxJum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.textBoxJum.HoverState.Parent = this.textBoxJum;
            this.textBoxJum.Location = new System.Drawing.Point(285, 109);
            this.textBoxJum.MaxLength = 9999;
            this.textBoxJum.Name = "textBoxJum";
            this.textBoxJum.PasswordChar = '\0';
            this.textBoxJum.PlaceholderText = "";
            this.textBoxJum.SelectedText = "";
            this.textBoxJum.SelectionStart = 1;
            this.textBoxJum.ShadowDecoration.Parent = this.textBoxJum;
            this.textBoxJum.Size = new System.Drawing.Size(45, 25);
            this.textBoxJum.TabIndex = 34;
            this.textBoxJum.TabStop = false;
            this.textBoxJum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxJum.Enter += new System.EventHandler(this.TextBoxJum_Enter);
            this.textBoxJum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxJum_KeyPress);
            this.textBoxJum.Leave += new System.EventHandler(this.TextBoxJum_Leave);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.buttonPlus.IconColor = System.Drawing.Color.DimGray;
            this.buttonPlus.IconSize = 16;
            this.buttonPlus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPlus.Location = new System.Drawing.Point(329, 109);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.buttonPlus.Rotation = 0D;
            this.buttonPlus.Size = new System.Drawing.Size(25, 25);
            this.buttonPlus.TabIndex = 33;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPlus_MouseDown);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinus.Enabled = false;
            this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.buttonMinus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.buttonMinus.IconSize = 16;
            this.buttonMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMinus.Location = new System.Drawing.Point(261, 109);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.buttonMinus.Rotation = 0D;
            this.buttonMinus.Size = new System.Drawing.Size(25, 25);
            this.buttonMinus.TabIndex = 32;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMinus_MouseDown);
            // 
            // buttonUbah
            // 
            this.buttonUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUbah.CheckedState.Parent = this.buttonUbah;
            this.buttonUbah.CustomImages.Parent = this.buttonUbah;
            this.buttonUbah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonUbah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.ForeColor = System.Drawing.Color.White;
            this.buttonUbah.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(111)))));
            this.buttonUbah.HoverState.Parent = this.buttonUbah;
            this.buttonUbah.Location = new System.Drawing.Point(612, 13);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.ShadowDecoration.Parent = this.buttonUbah;
            this.buttonUbah.Size = new System.Drawing.Size(88, 35);
            this.buttonUbah.TabIndex = 35;
            this.buttonUbah.TabStop = false;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.Click += new System.EventHandler(this.ButtonUbah_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.CheckedState.Parent = this.buttonHapus;
            this.buttonHapus.CustomImages.Parent = this.buttonHapus;
            this.buttonHapus.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHapus.FillColor = System.Drawing.Color.Firebrick;
            this.buttonHapus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.White;
            this.buttonHapus.HoverState.Parent = this.buttonHapus;
            this.buttonHapus.Location = new System.Drawing.Point(612, 0);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.ShadowDecoration.Parent = this.buttonHapus;
            this.buttonHapus.Size = new System.Drawing.Size(88, 175);
            this.buttonHapus.TabIndex = 36;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.Click += new System.EventHandler(this.ButtonHapus_Click);
            // 
            // panelBarang
            // 
            this.panelBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarang.BackColor = System.Drawing.Color.White;
            this.panelBarang.Controls.Add(this.pictureBoxBarang);
            this.panelBarang.Controls.Add(this.textBoxJum);
            this.panelBarang.Controls.Add(this.buttonPlus);
            this.panelBarang.Controls.Add(this.buttonMinus);
            this.panelBarang.Controls.Add(this.labelNamaBrg);
            this.panelBarang.Controls.Add(this.labelHarga);
            this.panelBarang.Controls.Add(this.checkBoxItem);
            this.panelBarang.Location = new System.Drawing.Point(0, 0);
            this.panelBarang.Margin = new System.Windows.Forms.Padding(0);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Size = new System.Drawing.Size(700, 175);
            this.panelBarang.TabIndex = 37;
            // 
            // checkBoxItem
            // 
            this.checkBoxItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxItem.CheckedState.BorderColor = System.Drawing.Color.HotPink;
            this.checkBoxItem.CheckedState.BorderRadius = 2;
            this.checkBoxItem.CheckedState.BorderThickness = 0;
            this.checkBoxItem.CheckedState.FillColor = System.Drawing.Color.HotPink;
            this.checkBoxItem.CheckedState.Parent = this.checkBoxItem;
            this.checkBoxItem.Location = new System.Drawing.Point(36, 71);
            this.checkBoxItem.Name = "checkBoxItem";
            this.checkBoxItem.ShadowDecoration.Parent = this.checkBoxItem;
            this.checkBoxItem.Size = new System.Drawing.Size(20, 20);
            this.checkBoxItem.TabIndex = 35;
            this.checkBoxItem.TabStop = false;
            this.checkBoxItem.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxItem.UncheckedState.BorderRadius = 2;
            this.checkBoxItem.UncheckedState.BorderThickness = 0;
            this.checkBoxItem.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxItem.UncheckedState.Parent = this.checkBoxItem;
            this.checkBoxItem.Click += new System.EventHandler(this.CheckBoxItem_Click);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 1;
            this.timerAnimation.Tick += new System.EventHandler(this.TimerAnimation_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(0, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 2);
            this.label1.TabIndex = 38;
            // 
            // UCItemKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.panelBarang);
            this.Controls.Add(this.buttonHapus);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCItemKeranjang";
            this.Size = new System.Drawing.Size(700, 175);
            this.Load += new System.EventHandler(this.UCItemKeranjang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).EndInit();
            this.panelBarang.ResumeLayout(false);
            this.panelBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBarang;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelNamaBrg;
        private Guna.UI2.WinForms.Guna2TextBox textBoxJum;
        private FontAwesome.Sharp.IconButton buttonPlus;
        private FontAwesome.Sharp.IconButton buttonMinus;
        private Guna.UI2.WinForms.Guna2Button buttonUbah;
        private Guna.UI2.WinForms.Guna2Button buttonHapus;
        private System.Windows.Forms.Panel panelBarang;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2CustomCheckBox checkBoxItem;
    }
}
