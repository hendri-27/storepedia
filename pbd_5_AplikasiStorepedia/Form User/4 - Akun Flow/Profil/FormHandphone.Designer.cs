namespace pbd_5_AplikasiStorepedia
{
    partial class FormHandphone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHandphone));
            this.panelNoHandphone = new System.Windows.Forms.Panel();
            this.buttonSimpan = new FontAwesome.Sharp.IconButton();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHandphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.shadowFormHandphone = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblNoTelp = new System.Windows.Forms.Label();
            this.panelNoHandphone.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoHandphone
            // 
            this.panelNoHandphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelNoHandphone.Controls.Add(this.buttonSimpan);
            this.panelNoHandphone.Controls.Add(this.buttonBack);
            this.panelNoHandphone.Controls.Add(this.label1);
            this.panelNoHandphone.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNoHandphone.Location = new System.Drawing.Point(0, 0);
            this.panelNoHandphone.Name = "panelNoHandphone";
            this.panelNoHandphone.Size = new System.Drawing.Size(388, 39);
            this.panelNoHandphone.TabIndex = 64;
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
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubah Nomor Handphone";
            // 
            // textBoxHandphone
            // 
            this.textBoxHandphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxHandphone.DefaultText = "";
            this.textBoxHandphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxHandphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxHandphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxHandphone.DisabledState.Parent = this.textBoxHandphone;
            this.textBoxHandphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxHandphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxHandphone.FocusedState.Parent = this.textBoxHandphone;
            this.textBoxHandphone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxHandphone.ForeColor = System.Drawing.Color.Black;
            this.textBoxHandphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxHandphone.HoverState.Parent = this.textBoxHandphone;
            this.textBoxHandphone.Location = new System.Drawing.Point(125, 61);
            this.textBoxHandphone.Name = "textBoxHandphone";
            this.textBoxHandphone.PasswordChar = '\0';
            this.textBoxHandphone.PlaceholderText = "(+62 / 0) Indonesia";
            this.textBoxHandphone.SelectedText = "";
            this.textBoxHandphone.ShadowDecoration.Parent = this.textBoxHandphone;
            this.textBoxHandphone.Size = new System.Drawing.Size(226, 28);
            this.textBoxHandphone.TabIndex = 66;
            this.textBoxHandphone.TabStop = false;
            this.textBoxHandphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHandphone_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "No. Handphone";
            // 
            // shadowFormHandphone
            // 
            this.shadowFormHandphone.BorderRadius = 20;
            this.shadowFormHandphone.ShadowColor = System.Drawing.Color.Gray;
            this.shadowFormHandphone.TargetForm = this;
            // 
            // lblNoTelp
            // 
            this.lblNoTelp.AutoSize = true;
            this.lblNoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTelp.ForeColor = System.Drawing.Color.White;
            this.lblNoTelp.Location = new System.Drawing.Point(125, 90);
            this.lblNoTelp.Name = "lblNoTelp";
            this.lblNoTelp.Size = new System.Drawing.Size(141, 15);
            this.lblNoTelp.TabIndex = 67;
            this.lblNoTelp.Text = "Nomor telepon tidak sah";
            // 
            // FormHandphone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 125);
            this.Controls.Add(this.lblNoTelp);
            this.Controls.Add(this.panelNoHandphone);
            this.Controls.Add(this.textBoxHandphone);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHandphone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form No Telp";
            this.panelNoHandphone.ResumeLayout(false);
            this.panelNoHandphone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Panel panelNoHandphone;
        private FontAwesome.Sharp.IconButton buttonSimpan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxHandphone;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowFormHandphone;
        private System.Windows.Forms.Label lblNoTelp;
    }
}