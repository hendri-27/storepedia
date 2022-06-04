namespace pbd_5_AplikasiStorepedia
{
    partial class FormVerifikasiEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerifikasiEmail));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.buttonSimpan = new FontAwesome.Sharp.IconButton();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.panelTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVerification = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVerifikasi = new System.Windows.Forms.Label();
            this.buttonSendVerification = new Guna.UI2.WinForms.Guna2Button();
            this.panelEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Verifikasi Email";
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
            this.buttonSimpan.Text = "Lanjut";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.ButtonSimpan_Click);
            this.buttonSimpan.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonSimpan.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panelEmail
            // 
            this.panelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelEmail.Controls.Add(this.panelTopBar);
            this.panelEmail.Controls.Add(this.buttonSimpan);
            this.panelEmail.Controls.Add(this.buttonBack);
            this.panelEmail.Controls.Add(this.label1);
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(411, 39);
            this.panelEmail.TabIndex = 64;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.Transparent;
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopBar.Location = new System.Drawing.Point(34, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.ShadowDecoration.Parent = this.panelTopBar;
            this.panelTopBar.Size = new System.Drawing.Size(304, 39);
            this.panelTopBar.TabIndex = 90;
            this.panelTopBar.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "Kode";
            // 
            // textBoxVerification
            // 
            this.textBoxVerification.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.textBoxVerification.Location = new System.Drawing.Point(91, 60);
            this.textBoxVerification.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxVerification.MaxLength = 6;
            this.textBoxVerification.Name = "textBoxVerification";
            this.textBoxVerification.PasswordChar = '\0';
            this.textBoxVerification.PlaceholderText = "Isi kode kamu disini";
            this.textBoxVerification.SelectedText = "";
            this.textBoxVerification.ShadowDecoration.Parent = this.textBoxVerification;
            this.textBoxVerification.Size = new System.Drawing.Size(136, 26);
            this.textBoxVerification.TabIndex = 88;
            this.textBoxVerification.TabStop = false;
            // 
            // lblVerifikasi
            // 
            this.lblVerifikasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVerifikasi.AutoSize = true;
            this.lblVerifikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifikasi.ForeColor = System.Drawing.Color.White;
            this.lblVerifikasi.Location = new System.Drawing.Point(88, 89);
            this.lblVerifikasi.Name = "lblVerifikasi";
            this.lblVerifikasi.Size = new System.Drawing.Size(119, 15);
            this.lblVerifikasi.TabIndex = 87;
            this.lblVerifikasi.Text = "Kode verifikasi salah";
            // 
            // buttonSendVerification
            // 
            this.buttonSendVerification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSendVerification.CheckedState.Parent = this.buttonSendVerification;
            this.buttonSendVerification.CustomImages.Parent = this.buttonSendVerification;
            this.buttonSendVerification.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonSendVerification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSendVerification.ForeColor = System.Drawing.Color.White;
            this.buttonSendVerification.HoverState.Parent = this.buttonSendVerification;
            this.buttonSendVerification.Location = new System.Drawing.Point(242, 60);
            this.buttonSendVerification.Name = "buttonSendVerification";
            this.buttonSendVerification.ShadowDecoration.Parent = this.buttonSendVerification;
            this.buttonSendVerification.Size = new System.Drawing.Size(130, 26);
            this.buttonSendVerification.TabIndex = 86;
            this.buttonSendVerification.Text = "Kirim Verifikasi";
            this.buttonSendVerification.Click += new System.EventHandler(this.ButtonSendVerification_Click);
            // 
            // FormVerifikasiEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 125);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVerification);
            this.Controls.Add(this.lblVerifikasi);
            this.Controls.Add(this.buttonSendVerification);
            this.Controls.Add(this.panelEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVerifikasiEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Email";
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
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxVerification;
        private System.Windows.Forms.Label lblVerifikasi;
        public Guna.UI2.WinForms.Guna2Button buttonSendVerification;
        private Guna.UI2.WinForms.Guna2Panel panelTopBar;
    }
}