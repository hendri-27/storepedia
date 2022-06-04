namespace pbd_5_AplikasiStorepedia
{
    partial class FormVerifikasiPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerifikasiPass));
            this.textBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.shadowFormVerifikasiPass = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelUbahPass = new System.Windows.Forms.Panel();
            this.buttonSimpan = new FontAwesome.Sharp.IconButton();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.pictureBoxShowPass1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.panelUbahPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass1)).BeginInit();
            this.SuspendLayout();
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
            this.textBoxPass.Location = new System.Drawing.Point(23, 60);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.PlaceholderText = "Password Saat Ini";
            this.textBoxPass.SelectedText = "";
            this.textBoxPass.ShadowDecoration.Parent = this.textBoxPass;
            this.textBoxPass.Size = new System.Drawing.Size(334, 28);
            this.textBoxPass.TabIndex = 66;
            this.textBoxPass.TabStop = false;
            this.textBoxPass.TextChanged += new System.EventHandler(this.TextBoxPass_Validation);
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.textBoxPass.Leave += new System.EventHandler(this.TextBoxPass_Validation);
            // 
            // shadowFormVerifikasiPass
            // 
            this.shadowFormVerifikasiPass.BorderRadius = 20;
            this.shadowFormVerifikasiPass.ShadowColor = System.Drawing.Color.Gray;
            this.shadowFormVerifikasiPass.TargetForm = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masukkan Password";
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
            this.panelUbahPass.TabIndex = 64;
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
            // 
            // pictureBoxShowPass1
            // 
            this.pictureBoxShowPass1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShowPass1.Image = global::pbd_5_AplikasiStorepedia.Properties.Resources.eye_close;
            this.pictureBoxShowPass1.Location = new System.Drawing.Point(366, 62);
            this.pictureBoxShowPass1.Name = "pictureBoxShowPass1";
            this.pictureBoxShowPass1.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxShowPass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShowPass1.TabIndex = 69;
            this.pictureBoxShowPass1.TabStop = false;
            this.pictureBoxShowPass1.Tag = "eyeClose";
            this.pictureBoxShowPass1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LookUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(21, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Lupa password?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(21, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "Silahkan log out dari akunmu dan pilih \"Lupa Password\"";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(21, 91);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(216, 15);
            this.lblPass.TabIndex = 87;
            this.lblPass.Text = "Password harus terdiri dari 8 - 16 digit.";
            // 
            // FormVerifikasiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 189);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxShowPass1);
            this.Controls.Add(this.panelUbahPass);
            this.Controls.Add(this.textBoxPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVerifikasiPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Ubah Pass";
            this.panelUbahPass.ResumeLayout(false);
            this.panelUbahPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPass1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox textBoxPass;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowFormVerifikasiPass;
        private System.Windows.Forms.PictureBox pictureBoxShowPass1;
        private System.Windows.Forms.Panel panelUbahPass;
        private FontAwesome.Sharp.IconButton buttonSimpan;
        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPass;
    }
}