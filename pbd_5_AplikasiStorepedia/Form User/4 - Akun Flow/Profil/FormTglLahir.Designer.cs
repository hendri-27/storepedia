namespace pbd_5_AplikasiStorepedia
{
    partial class FormTglLahir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTglLahir));
            this.panelTglLahir = new System.Windows.Forms.Panel();
            this.panelSimpan = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSimpan = new FontAwesome.Sharp.IconButton();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.shadowFormTanggalLahir = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.dateTimePickerTglLahir = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelTglLahir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTglLahir
            // 
            this.panelTglLahir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTglLahir.Controls.Add(this.panelSimpan);
            this.panelTglLahir.Controls.Add(this.buttonSimpan);
            this.panelTglLahir.Controls.Add(this.buttonBack);
            this.panelTglLahir.Controls.Add(this.label1);
            this.panelTglLahir.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTglLahir.Location = new System.Drawing.Point(0, 0);
            this.panelTglLahir.Name = "panelTglLahir";
            this.panelTglLahir.Size = new System.Drawing.Size(388, 39);
            this.panelTglLahir.TabIndex = 64;
            // 
            // panelSimpan
            // 
            this.panelSimpan.BackColor = System.Drawing.Color.Transparent;
            this.panelSimpan.Location = new System.Drawing.Point(315, 0);
            this.panelSimpan.Name = "panelSimpan";
            this.panelSimpan.ShadowDecoration.Parent = this.panelSimpan;
            this.panelSimpan.Size = new System.Drawing.Size(73, 39);
            this.panelSimpan.TabIndex = 68;
            this.panelSimpan.UseTransparentBackground = true;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.FlatAppearance.BorderSize = 0;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSimpan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSimpan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSimpan.IconColor = System.Drawing.Color.LightGray;
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
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubah Tanggal Lahir";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "Tanggal Lahir";
            // 
            // shadowFormTanggalLahir
            // 
            this.shadowFormTanggalLahir.BorderRadius = 20;
            this.shadowFormTanggalLahir.ShadowColor = System.Drawing.Color.Gray;
            this.shadowFormTanggalLahir.TargetForm = this;
            // 
            // dateTimePickerTglLahir
            // 
            this.dateTimePickerTglLahir.Animated = true;
            this.dateTimePickerTglLahir.BorderRadius = 1;
            this.dateTimePickerTglLahir.BorderThickness = 1;
            this.dateTimePickerTglLahir.CheckedState.Parent = this.dateTimePickerTglLahir;
            this.dateTimePickerTglLahir.FillColor = System.Drawing.Color.White;
            this.dateTimePickerTglLahir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerTglLahir.HoverState.Parent = this.dateTimePickerTglLahir;
            this.dateTimePickerTglLahir.Location = new System.Drawing.Point(125, 65);
            this.dateTimePickerTglLahir.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerTglLahir.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTglLahir.Name = "dateTimePickerTglLahir";
            this.dateTimePickerTglLahir.ShadowDecoration.Parent = this.dateTimePickerTglLahir;
            this.dateTimePickerTglLahir.Size = new System.Drawing.Size(226, 28);
            this.dateTimePickerTglLahir.TabIndex = 67;
            this.dateTimePickerTglLahir.TabStop = false;
            this.dateTimePickerTglLahir.Value = new System.DateTime(2020, 10, 26, 22, 41, 53, 878);
            this.dateTimePickerTglLahir.ValueChanged += new System.EventHandler(this.DateTimePickerTglLahir_ValueChanged);
            // 
            // FormTglLahir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 125);
            this.Controls.Add(this.dateTimePickerTglLahir);
            this.Controls.Add(this.panelTglLahir);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTglLahir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tgl Lahir";
            this.Load += new System.EventHandler(this.FormTglLahir_Load);
            this.panelTglLahir.ResumeLayout(false);
            this.panelTglLahir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Panel panelTglLahir;
        private FontAwesome.Sharp.IconButton buttonSimpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowFormTanggalLahir;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerTglLahir;
        private Guna.UI2.WinForms.Guna2Panel panelSimpan;
    }
}