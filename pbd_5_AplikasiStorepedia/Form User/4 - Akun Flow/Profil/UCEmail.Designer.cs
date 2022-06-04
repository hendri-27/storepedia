namespace pbd_5_AplikasiStorepedia
{
    partial class UCEmail
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
            this.panelEmail = new System.Windows.Forms.Panel();
            this.buttonSimpan = new FontAwesome.Sharp.IconButton();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.shadowFormEmail = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxVerification = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVerifikasi = new System.Windows.Forms.Label();
            this.buttonSendVerification = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmail
            // 
            this.panelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelEmail.Controls.Add(this.buttonSimpan);
            this.panelEmail.Controls.Add(this.buttonBack);
            this.panelEmail.Controls.Add(this.label1);
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(411, 39);
            this.panelEmail.TabIndex = 68;
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
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubah Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmail.DefaultText = "";
            this.textBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEmail.DisabledState.Parent = this.textBoxEmail;
            this.textBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxEmail.FocusedState.Parent = this.textBoxEmail;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxEmail.HoverState.Parent = this.textBoxEmail;
            this.textBoxEmail.IconLeftSize = new System.Drawing.Size(0, 0);
            this.textBoxEmail.IconRightSize = new System.Drawing.Size(0, 0);
            this.textBoxEmail.Location = new System.Drawing.Point(83, 62);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.PlaceholderText = "storepedia@email.com";
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.ShadowDecoration.Parent = this.textBoxEmail;
            this.textBoxEmail.Size = new System.Drawing.Size(281, 28);
            this.textBoxEmail.TabIndex = 70;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEmail_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 69;
            this.label12.Text = "Email";
            // 
            // shadowFormEmail
            // 
            this.shadowFormEmail.BorderRadius = 20;
            this.shadowFormEmail.ShadowColor = System.Drawing.Color.Gray;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(84, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(135, 15);
            this.lblEmail.TabIndex = 71;
            this.lblEmail.Text = "Format email tidak sah.";
            // 
            // textBoxVerification
            // 
            this.textBoxVerification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVerification.DefaultText = "";
            this.textBoxVerification.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxVerification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxVerification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxVerification.DisabledState.Parent = this.textBoxVerification;
            this.textBoxVerification.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxVerification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxVerification.FocusedState.Parent = this.textBoxVerification;
            this.textBoxVerification.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVerification.ForeColor = System.Drawing.Color.Black;
            this.textBoxVerification.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxVerification.HoverState.Parent = this.textBoxVerification;
            this.textBoxVerification.IconLeftSize = new System.Drawing.Size(0, 0);
            this.textBoxVerification.IconRightSize = new System.Drawing.Size(0, 0);
            this.textBoxVerification.Location = new System.Drawing.Point(83, 122);
            this.textBoxVerification.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxVerification.MaxLength = 6;
            this.textBoxVerification.Name = "textBoxVerification";
            this.textBoxVerification.PasswordChar = '\0';
            this.textBoxVerification.PlaceholderText = "Isi kode kamu disini";
            this.textBoxVerification.SelectedText = "";
            this.textBoxVerification.ShadowDecoration.Parent = this.textBoxVerification;
            this.textBoxVerification.Size = new System.Drawing.Size(136, 26);
            this.textBoxVerification.TabIndex = 92;
            this.textBoxVerification.TabStop = false;
            // 
            // lblVerifikasi
            // 
            this.lblVerifikasi.AutoSize = true;
            this.lblVerifikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifikasi.ForeColor = System.Drawing.Color.White;
            this.lblVerifikasi.Location = new System.Drawing.Point(80, 151);
            this.lblVerifikasi.Name = "lblVerifikasi";
            this.lblVerifikasi.Size = new System.Drawing.Size(119, 15);
            this.lblVerifikasi.TabIndex = 91;
            this.lblVerifikasi.Text = "Kode verifikasi salah";
            // 
            // buttonSendVerification
            // 
            this.buttonSendVerification.CheckedState.Parent = this.buttonSendVerification;
            this.buttonSendVerification.CustomImages.Parent = this.buttonSendVerification;
            this.buttonSendVerification.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonSendVerification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSendVerification.ForeColor = System.Drawing.Color.White;
            this.buttonSendVerification.HoverState.Parent = this.buttonSendVerification;
            this.buttonSendVerification.Location = new System.Drawing.Point(234, 122);
            this.buttonSendVerification.Name = "buttonSendVerification";
            this.buttonSendVerification.ShadowDecoration.Parent = this.buttonSendVerification;
            this.buttonSendVerification.Size = new System.Drawing.Size(130, 26);
            this.buttonSendVerification.TabIndex = 90;
            this.buttonSendVerification.Text = "Kirim Verifikasi";
            this.buttonSendVerification.Click += new System.EventHandler(this.ButtonSendVerification_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 93;
            this.label2.Text = "Kode";
            // 
            // UCEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVerification);
            this.Controls.Add(this.lblVerifikasi);
            this.Controls.Add(this.buttonSendVerification);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblEmail);
            this.Name = "UCEmail";
            this.Size = new System.Drawing.Size(411, 189);
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEmail;
        private FontAwesome.Sharp.IconButton buttonSimpan;
        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxEmail;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowFormEmail;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox textBoxVerification;
        private System.Windows.Forms.Label lblVerifikasi;
        public Guna.UI2.WinForms.Guna2Button buttonSendVerification;
        private System.Windows.Forms.Label label2;
    }
}
