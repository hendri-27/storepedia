namespace pbd_5_AplikasiStorepedia
{
    partial class TambahKeranjang
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
            this.buttonMasukKeranjang = new Guna.UI2.WinForms.Guna2Button();
            this.labelRatingStar = new System.Windows.Forms.Label();
            this.buttonMinus = new FontAwesome.Sharp.IconButton();
            this.buttonPlus = new FontAwesome.Sharp.IconButton();
            this.textBoxJum = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // buttonMasukKeranjang
            // 
            this.buttonMasukKeranjang.CheckedState.Parent = this.buttonMasukKeranjang;
            this.buttonMasukKeranjang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMasukKeranjang.CustomImages.Parent = this.buttonMasukKeranjang;
            this.buttonMasukKeranjang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.buttonMasukKeranjang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasukKeranjang.ForeColor = System.Drawing.Color.White;
            this.buttonMasukKeranjang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(111)))));
            this.buttonMasukKeranjang.HoverState.Parent = this.buttonMasukKeranjang;
            this.buttonMasukKeranjang.Location = new System.Drawing.Point(35, 74);
            this.buttonMasukKeranjang.Name = "buttonMasukKeranjang";
            this.buttonMasukKeranjang.PressedColor = System.Drawing.Color.White;
            this.buttonMasukKeranjang.ShadowDecoration.BorderRadius = 10;
            this.buttonMasukKeranjang.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(155)))), ((int)(((byte)(211)))));
            this.buttonMasukKeranjang.ShadowDecoration.Enabled = true;
            this.buttonMasukKeranjang.ShadowDecoration.Parent = this.buttonMasukKeranjang;
            this.buttonMasukKeranjang.Size = new System.Drawing.Size(216, 34);
            this.buttonMasukKeranjang.TabIndex = 26;
            this.buttonMasukKeranjang.TabStop = false;
            this.buttonMasukKeranjang.Text = "Masukkan Keranjang";
            this.buttonMasukKeranjang.Click += new System.EventHandler(this.ButtonMasukKeranjang_Click);
            // 
            // labelRatingStar
            // 
            this.labelRatingStar.AutoSize = true;
            this.labelRatingStar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRatingStar.Location = new System.Drawing.Point(28, 26);
            this.labelRatingStar.Name = "labelRatingStar";
            this.labelRatingStar.Size = new System.Drawing.Size(60, 20);
            this.labelRatingStar.TabIndex = 27;
            this.labelRatingStar.Text = "Jumlah";
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
            this.buttonMinus.Location = new System.Drawing.Point(165, 24);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.buttonMinus.Rotation = 0D;
            this.buttonMinus.Size = new System.Drawing.Size(25, 25);
            this.buttonMinus.TabIndex = 29;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMinus_MouseDown);
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
            this.buttonPlus.Location = new System.Drawing.Point(233, 24);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.buttonPlus.Rotation = 0D;
            this.buttonPlus.Size = new System.Drawing.Size(25, 25);
            this.buttonPlus.TabIndex = 30;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPlus_MouseDown);
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
            this.textBoxJum.Location = new System.Drawing.Point(189, 24);
            this.textBoxJum.MaxLength = 9999;
            this.textBoxJum.Name = "textBoxJum";
            this.textBoxJum.PasswordChar = '\0';
            this.textBoxJum.PlaceholderText = "";
            this.textBoxJum.SelectedText = "";
            this.textBoxJum.SelectionStart = 1;
            this.textBoxJum.ShadowDecoration.Parent = this.textBoxJum;
            this.textBoxJum.Size = new System.Drawing.Size(45, 25);
            this.textBoxJum.TabIndex = 31;
            this.textBoxJum.TabStop = false;
            this.textBoxJum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxJum.TextChanged += new System.EventHandler(this.TextBoxJum_TextChanged);
            this.textBoxJum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJum_KeyPress);
            // 
            // TambahKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBoxJum);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.labelRatingStar);
            this.Controls.Add(this.buttonMasukKeranjang);
            this.Name = "TambahKeranjang";
            this.Size = new System.Drawing.Size(290, 132);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonMasukKeranjang;
        private System.Windows.Forms.Label labelRatingStar;
        private FontAwesome.Sharp.IconButton buttonMinus;
        private FontAwesome.Sharp.IconButton buttonPlus;
        private Guna.UI2.WinForms.Guna2TextBox textBoxJum;
    }
}
