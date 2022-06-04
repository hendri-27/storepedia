namespace pbd_5_AplikasiStorepedia
{
    partial class FormMetodeBayar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMetodeBayar));
            this.panelKeranjang = new System.Windows.Forms.Panel();
            this.panelSimpan = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSimpan = new FontAwesome.Sharp.IconButton();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.shadowFormUbahPass = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.radioButtonStorepediaPay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelKeranjang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKeranjang
            // 
            this.panelKeranjang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelKeranjang.Controls.Add(this.panelSimpan);
            this.panelKeranjang.Controls.Add(this.buttonSimpan);
            this.panelKeranjang.Controls.Add(this.buttonBack);
            this.panelKeranjang.Controls.Add(this.label1);
            this.panelKeranjang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKeranjang.Location = new System.Drawing.Point(0, 0);
            this.panelKeranjang.Name = "panelKeranjang";
            this.panelKeranjang.Size = new System.Drawing.Size(303, 39);
            this.panelKeranjang.TabIndex = 64;
            // 
            // panelSimpan
            // 
            this.panelSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSimpan.BackColor = System.Drawing.Color.Transparent;
            this.panelSimpan.Location = new System.Drawing.Point(230, 0);
            this.panelSimpan.Name = "panelSimpan";
            this.panelSimpan.ShadowDecoration.Parent = this.panelSimpan;
            this.panelSimpan.Size = new System.Drawing.Size(73, 39);
            this.panelSimpan.TabIndex = 69;
            this.panelSimpan.UseTransparentBackground = true;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSimpan.FlatAppearance.BorderSize = 0;
            this.buttonSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSimpan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSimpan.IconColor = System.Drawing.Color.White;
            this.buttonSimpan.IconSize = 20;
            this.buttonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSimpan.Location = new System.Drawing.Point(230, 0);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Rotation = 0D;
            this.buttonSimpan.Size = new System.Drawing.Size(73, 39);
            this.buttonSimpan.TabIndex = 57;
            this.buttonSimpan.TabStop = false;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.ButtonSimpan_Click);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilih Metode Bayar";
            // 
            // shadowFormUbahPass
            // 
            this.shadowFormUbahPass.BorderRadius = 20;
            this.shadowFormUbahPass.ShadowColor = System.Drawing.Color.Gray;
            this.shadowFormUbahPass.TargetForm = this;
            // 
            // radioButtonStorepediaPay
            // 
            this.radioButtonStorepediaPay.AutoCheck = false;
            this.radioButtonStorepediaPay.AutoSize = true;
            this.radioButtonStorepediaPay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.radioButtonStorepediaPay.CheckedState.BorderThickness = 0;
            this.radioButtonStorepediaPay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.radioButtonStorepediaPay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonStorepediaPay.CheckedState.InnerOffset = -4;
            this.radioButtonStorepediaPay.Font = new System.Drawing.Font("Arial", 9.75F);
            this.radioButtonStorepediaPay.Location = new System.Drawing.Point(34, 57);
            this.radioButtonStorepediaPay.Name = "radioButtonStorepediaPay";
            this.radioButtonStorepediaPay.Size = new System.Drawing.Size(111, 20);
            this.radioButtonStorepediaPay.TabIndex = 66;
            this.radioButtonStorepediaPay.Tag = "";
            this.radioButtonStorepediaPay.Text = "StorepediaPay";
            this.radioButtonStorepediaPay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonStorepediaPay.UncheckedState.BorderThickness = 2;
            this.radioButtonStorepediaPay.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonStorepediaPay.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioButtonStorepediaPay.CheckedChanged += new System.EventHandler(this.RadioChecked);
            // 
            // FormMetodeBayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 97);
            this.Controls.Add(this.radioButtonStorepediaPay);
            this.Controls.Add(this.panelKeranjang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMetodeBayar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Metode Bayar";
            this.panelKeranjang.ResumeLayout(false);
            this.panelKeranjang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Panel panelKeranjang;
        private FontAwesome.Sharp.IconButton buttonSimpan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowFormUbahPass;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonStorepediaPay;
        private Guna.UI2.WinForms.Guna2Panel panelSimpan;
    }
}