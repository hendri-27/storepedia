namespace pbd_5_AplikasiStorepedia
{
    partial class UCGantiPassword
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
            this.panelUbahPass = new System.Windows.Forms.Panel();
            this.buttonSimpan = new FontAwesome.Sharp.IconButton();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pictureBoxShowPass1 = new System.Windows.Forms.PictureBox();
            this.textBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUlangPass = new System.Windows.Forms.Label();
            this.pictureBoxShowPass2 = new System.Windows.Forms.PictureBox();
            this.textBoxUlangPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUbahPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUbahPass
            // 
            this.panelUbahPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelUbahPass.Controls.Add(this.buttonSimpan);
            this.panelUbahPass.Controls.Add(this.buttonBack);
            this.panelUbahPass.Controls.Add(this.label1);
            this.panelUbahPass.Location = new System.Drawing.Point(0, 0);
            this.panelUbahPass.Name = "panelUbahPass";
            this.panelUbahPass.Size = new System.Drawing.Size(411, 39);
            this.panelUbahPass.TabIndex = 82;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSimpan.FlatAppearance.BorderSize = 0;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSimpan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSimpan.IconColor = System.Drawing.Color.White;
            this.buttonSimpan.IconSize = 20;
            this.buttonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSimpan.Location = new System.Drawing.Point(338, 0);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Rotation = 0D;
            this.buttonSimpan.Size = new System.Drawing.Size(73, 39);
            this.buttonSimpan.TabIndex = 57;
            this.buttonSimpan.TabStop = false;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.ButtonSimpan_Click);
            this.buttonSimpan.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonSimpan.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonBack.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.buttonBack.IconColor = System.Drawing.Color.White;
            this.buttonBack.IconSize = 20;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Rotation = 0D;
            this.buttonBack.Size = new System.Drawing.Size(34, 39);
            this.buttonBack.TabIndex = 55;
            this.buttonBack.TabStop = false;
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ganti Password";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(132, 91);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(216, 15);
            this.lblPass.TabIndex = 86;
            this.lblPass.Text = "Password harus terdiri dari 8 - 16 digit.";
            // 
            // pictureBoxShowPass1
            // 
            this.pictureBoxShowPass1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShowPass1.Image = global::pbd_5_AplikasiStorepedia.Properties.Resources.eye_close;
            this.pictureBoxShowPass1.Location = new System.Drawing.Point(366, 62);
            this.pictureBoxShowPass1.Name = "pictureBoxShowPass1";
            this.pictureBoxShowPass1.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxShowPass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShowPass1.TabIndex = 85;
            this.pictureBoxShowPass1.TabStop = false;
            this.pictureBoxShowPass1.Tag = "eyeClose";
            this.pictureBoxShowPass1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LookUp);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPass.DefaultText = "";
            this.textBoxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPass.DisabledState.Parent = this.textBoxPass;
            this.textBoxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPass.FocusedState.Parent = this.textBoxPass;
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPass.HoverState.Parent = this.textBoxPass;
            this.textBoxPass.Location = new System.Drawing.Point(131, 60);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.PlaceholderText = "";
            this.textBoxPass.SelectedText = "";
            this.textBoxPass.ShadowDecoration.Parent = this.textBoxPass;
            this.textBoxPass.Size = new System.Drawing.Size(226, 28);
            this.textBoxPass.TabIndex = 84;
            this.textBoxPass.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 83;
            this.label12.Text = "Password Baru";
            // 
            // lblUlangPass
            // 
            this.lblUlangPass.AutoSize = true;
            this.lblUlangPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUlangPass.ForeColor = System.Drawing.Color.White;
            this.lblUlangPass.Location = new System.Drawing.Point(132, 157);
            this.lblUlangPass.Name = "lblUlangPass";
            this.lblUlangPass.Size = new System.Drawing.Size(256, 15);
            this.lblUlangPass.TabIndex = 90;
            this.lblUlangPass.Text = "Password tidak sama. Coba masukkan ulang.";
            // 
            // pictureBoxShowPass2
            // 
            this.pictureBoxShowPass2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShowPass2.Image = global::pbd_5_AplikasiStorepedia.Properties.Resources.eye_close;
            this.pictureBoxShowPass2.Location = new System.Drawing.Point(366, 129);
            this.pictureBoxShowPass2.Name = "pictureBoxShowPass2";
            this.pictureBoxShowPass2.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxShowPass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShowPass2.TabIndex = 89;
            this.pictureBoxShowPass2.TabStop = false;
            this.pictureBoxShowPass2.Tag = "eyeClose";
            this.pictureBoxShowPass2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LookUp);
            // 
            // textBoxUlangPass
            // 
            this.textBoxUlangPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUlangPass.DefaultText = "";
            this.textBoxUlangPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUlangPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUlangPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUlangPass.DisabledState.Parent = this.textBoxUlangPass;
            this.textBoxUlangPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUlangPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUlangPass.FocusedState.Parent = this.textBoxUlangPass;
            this.textBoxUlangPass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxUlangPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxUlangPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUlangPass.HoverState.Parent = this.textBoxUlangPass;
            this.textBoxUlangPass.Location = new System.Drawing.Point(131, 126);
            this.textBoxUlangPass.Name = "textBoxUlangPass";
            this.textBoxUlangPass.PasswordChar = '*';
            this.textBoxUlangPass.PlaceholderText = "";
            this.textBoxUlangPass.SelectedText = "";
            this.textBoxUlangPass.ShadowDecoration.Parent = this.textBoxUlangPass;
            this.textBoxUlangPass.Size = new System.Drawing.Size(226, 28);
            this.textBoxUlangPass.TabIndex = 88;
            this.textBoxUlangPass.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Ulangi Password";
            // 
            // UCGantiPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblUlangPass);
            this.Controls.Add(this.pictureBoxShowPass2);
            this.Controls.Add(this.textBoxUlangPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.pictureBoxShowPass1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panelUbahPass);
            this.Name = "UCGantiPassword";
            this.Size = new System.Drawing.Size(411, 195);
            this.panelUbahPass.ResumeLayout(false);
            this.panelUbahPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUbahPass;
        private FontAwesome.Sharp.IconButton buttonSimpan;
        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox pictureBoxShowPass1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblUlangPass;
        private System.Windows.Forms.PictureBox pictureBoxShowPass2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUlangPass;
        private System.Windows.Forms.Label label2;
    }
}
