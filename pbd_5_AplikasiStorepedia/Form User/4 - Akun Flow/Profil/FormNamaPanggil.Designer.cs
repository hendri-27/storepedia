namespace pbd_5_AplikasiStorepedia
{
    partial class FormNamaPanggil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNamaPanggil));
            this.panelNamaPanggilan = new System.Windows.Forms.Panel();
            this.buttonSimpan = new FontAwesome.Sharp.IconButton();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNamaPanggil = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.shadowFormNamaPanggil = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblNamaPanggilan = new System.Windows.Forms.Label();
            this.panelNamaPanggilan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNamaPanggilan
            // 
            this.panelNamaPanggilan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelNamaPanggilan.Controls.Add(this.buttonSimpan);
            this.panelNamaPanggilan.Controls.Add(this.buttonBack);
            this.panelNamaPanggilan.Controls.Add(this.label1);
            this.panelNamaPanggilan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNamaPanggilan.Location = new System.Drawing.Point(0, 0);
            this.panelNamaPanggilan.Name = "panelNamaPanggilan";
            this.panelNamaPanggilan.Size = new System.Drawing.Size(388, 39);
            this.panelNamaPanggilan.TabIndex = 64;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.FlatAppearance.BorderSize = 0;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSimpan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSimpan.IconColor = System.Drawing.Color.White;
            this.buttonSimpan.IconSize = 20;
            this.buttonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSimpan.Location = new System.Drawing.Point(315, 0);
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
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubah Nama Panggil";
            // 
            // textBoxNamaPanggil
            // 
            this.textBoxNamaPanggil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNamaPanggil.DefaultText = "";
            this.textBoxNamaPanggil.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNamaPanggil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNamaPanggil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNamaPanggil.DisabledState.Parent = this.textBoxNamaPanggil;
            this.textBoxNamaPanggil.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNamaPanggil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNamaPanggil.FocusedState.Parent = this.textBoxNamaPanggil;
            this.textBoxNamaPanggil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxNamaPanggil.ForeColor = System.Drawing.Color.Black;
            this.textBoxNamaPanggil.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNamaPanggil.HoverState.Parent = this.textBoxNamaPanggil;
            this.textBoxNamaPanggil.Location = new System.Drawing.Point(125, 61);
            this.textBoxNamaPanggil.Name = "textBoxNamaPanggil";
            this.textBoxNamaPanggil.PasswordChar = '\0';
            this.textBoxNamaPanggil.PlaceholderText = "";
            this.textBoxNamaPanggil.SelectedText = "";
            this.textBoxNamaPanggil.ShadowDecoration.Parent = this.textBoxNamaPanggil;
            this.textBoxNamaPanggil.Size = new System.Drawing.Size(226, 28);
            this.textBoxNamaPanggil.TabIndex = 66;
            this.textBoxNamaPanggil.TabStop = false;
            this.textBoxNamaPanggil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNamaPanggilan_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "Nama Panggil";
            // 
            // shadowFormNamaPanggil
            // 
            this.shadowFormNamaPanggil.BorderRadius = 20;
            this.shadowFormNamaPanggil.ShadowColor = System.Drawing.Color.Gray;
            this.shadowFormNamaPanggil.TargetForm = this;
            // 
            // lblNamaPanggilan
            // 
            this.lblNamaPanggilan.AutoSize = true;
            this.lblNamaPanggilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPanggilan.ForeColor = System.Drawing.Color.White;
            this.lblNamaPanggilan.Location = new System.Drawing.Point(126, 90);
            this.lblNamaPanggilan.Name = "lblNamaPanggilan";
            this.lblNamaPanggilan.Size = new System.Drawing.Size(161, 15);
            this.lblNamaPanggilan.TabIndex = 68;
            this.lblNamaPanggilan.Text = "Nama panggilan harus diisi.";
            // 
            // FormNamaPanggil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 125);
            this.Controls.Add(this.lblNamaPanggilan);
            this.Controls.Add(this.panelNamaPanggilan);
            this.Controls.Add(this.textBoxNamaPanggil);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNamaPanggil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Nama Panggil";
            this.panelNamaPanggilan.ResumeLayout(false);
            this.panelNamaPanggilan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Panel panelNamaPanggilan;
        private FontAwesome.Sharp.IconButton buttonSimpan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxNamaPanggil;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowFormNamaPanggil;
        private System.Windows.Forms.Label lblNamaPanggilan;
    }
}