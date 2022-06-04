namespace pbd_5_AplikasiStorepedia
{
    partial class UCAlamat
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAlamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.labelProfil = new System.Windows.Forms.Label();
            this.labelUbah = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alamat Pengiriman";
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlamat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAlamat.DefaultText = "";
            this.textBoxAlamat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAlamat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAlamat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAlamat.DisabledState.Parent = this.textBoxAlamat;
            this.textBoxAlamat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAlamat.Enabled = false;
            this.textBoxAlamat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAlamat.FocusedState.Parent = this.textBoxAlamat;
            this.textBoxAlamat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamat.ForeColor = System.Drawing.Color.Black;
            this.textBoxAlamat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAlamat.HoverState.Parent = this.textBoxAlamat;
            this.textBoxAlamat.Location = new System.Drawing.Point(21, 67);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.PasswordChar = '\0';
            this.textBoxAlamat.PlaceholderForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxAlamat.PlaceholderText = "Atur alamat";
            this.textBoxAlamat.SelectedText = "";
            this.textBoxAlamat.ShadowDecoration.Parent = this.textBoxAlamat;
            this.textBoxAlamat.Size = new System.Drawing.Size(660, 60);
            this.textBoxAlamat.TabIndex = 1;
            this.textBoxAlamat.TabStop = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(20, 32);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(661, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // labelProfil
            // 
            this.labelProfil.AutoSize = true;
            this.labelProfil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfil.Location = new System.Drawing.Point(28, 45);
            this.labelProfil.Name = "labelProfil";
            this.labelProfil.Size = new System.Drawing.Size(156, 17);
            this.labelProfil.TabIndex = 3;
            this.labelProfil.Text = "Nama Lengkap (No.Telp)";
            // 
            // labelUbah
            // 
            this.labelUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUbah.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbah.Location = new System.Drawing.Point(631, 11);
            this.labelUbah.Name = "labelUbah";
            this.labelUbah.Size = new System.Drawing.Size(50, 21);
            this.labelUbah.TabIndex = 5;
            this.labelUbah.Text = "Ubah";
            this.labelUbah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUbah.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelUbah_MouseDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(3, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(697, 2);
            this.label4.TabIndex = 6;
            // 
            // UCAlamat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUbah);
            this.Controls.Add(this.labelProfil);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCAlamat";
            this.Size = new System.Drawing.Size(700, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxAlamat;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label labelProfil;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelUbah;
    }
}
