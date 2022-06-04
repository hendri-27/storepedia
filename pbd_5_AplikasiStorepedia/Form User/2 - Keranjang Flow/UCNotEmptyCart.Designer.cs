namespace pbd_5_AplikasiStorepedia
{
    partial class UCNotEmptyCart
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
            this.flowLayoutPanelKeranjang = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCheckOut = new System.Windows.Forms.Panel();
            this.checkBoxSemua = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBeli = new Guna.UI2.WinForms.Guna2Button();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.panelCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelKeranjang
            // 
            this.flowLayoutPanelKeranjang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelKeranjang.AutoScroll = true;
            this.flowLayoutPanelKeranjang.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelKeranjang.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelKeranjang.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelKeranjang.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelKeranjang.Name = "flowLayoutPanelKeranjang";
            this.flowLayoutPanelKeranjang.Size = new System.Drawing.Size(700, 414);
            this.flowLayoutPanelKeranjang.TabIndex = 6;
            this.flowLayoutPanelKeranjang.WrapContents = false;
            this.flowLayoutPanelKeranjang.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.UCNotEmptyCart_ControlRemoved);
            // 
            // panelCheckOut
            // 
            this.panelCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCheckOut.BackColor = System.Drawing.Color.LightGray;
            this.panelCheckOut.Controls.Add(this.checkBoxSemua);
            this.panelCheckOut.Controls.Add(this.label2);
            this.panelCheckOut.Controls.Add(this.label1);
            this.panelCheckOut.Controls.Add(this.buttonBeli);
            this.panelCheckOut.Controls.Add(this.labelTotalHarga);
            this.panelCheckOut.Location = new System.Drawing.Point(0, 414);
            this.panelCheckOut.Name = "panelCheckOut";
            this.panelCheckOut.Size = new System.Drawing.Size(700, 69);
            this.panelCheckOut.TabIndex = 5;
            // 
            // checkBoxSemua
            // 
            this.checkBoxSemua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSemua.CheckedState.BorderColor = System.Drawing.Color.HotPink;
            this.checkBoxSemua.CheckedState.BorderRadius = 2;
            this.checkBoxSemua.CheckedState.BorderThickness = 0;
            this.checkBoxSemua.CheckedState.FillColor = System.Drawing.Color.HotPink;
            this.checkBoxSemua.CheckedState.Parent = this.checkBoxSemua;
            this.checkBoxSemua.Location = new System.Drawing.Point(32, 26);
            this.checkBoxSemua.Name = "checkBoxSemua";
            this.checkBoxSemua.ShadowDecoration.Parent = this.checkBoxSemua;
            this.checkBoxSemua.Size = new System.Drawing.Size(20, 20);
            this.checkBoxSemua.TabIndex = 3;
            this.checkBoxSemua.TabStop = false;
            this.checkBoxSemua.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxSemua.UncheckedState.BorderRadius = 2;
            this.checkBoxSemua.UncheckedState.BorderThickness = 0;
            this.checkBoxSemua.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxSemua.UncheckedState.Parent = this.checkBoxSemua;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pilih Semua Barang";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(419, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sub Total";
            // 
            // buttonBeli
            // 
            this.buttonBeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeli.CheckedState.Parent = this.buttonBeli;
            this.buttonBeli.CustomImages.Parent = this.buttonBeli;
            this.buttonBeli.Enabled = false;
            this.buttonBeli.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonBeli.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeli.ForeColor = System.Drawing.Color.White;
            this.buttonBeli.HoverState.Parent = this.buttonBeli;
            this.buttonBeli.Location = new System.Drawing.Point(496, 16);
            this.buttonBeli.Name = "buttonBeli";
            this.buttonBeli.ShadowDecoration.Parent = this.buttonBeli;
            this.buttonBeli.Size = new System.Drawing.Size(191, 39);
            this.buttonBeli.TabIndex = 1;
            this.buttonBeli.TabStop = false;
            this.buttonBeli.Text = "Beli";
            this.buttonBeli.Click += new System.EventHandler(this.ButtonBeli_Click);
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalHarga.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHarga.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTotalHarga.Location = new System.Drawing.Point(254, 29);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(231, 29);
            this.labelTotalHarga.TabIndex = 2;
            this.labelTotalHarga.Text = "Rp 0";
            this.labelTotalHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 10;
            this.timerLoad.Tick += new System.EventHandler(this.TimerLoad_Tick);
            // 
            // UCNotEmptyCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelKeranjang);
            this.Controls.Add(this.panelCheckOut);
            this.MinimumSize = new System.Drawing.Size(700, 483);
            this.Name = "UCNotEmptyCart";
            this.Size = new System.Drawing.Size(700, 483);
            this.panelCheckOut.ResumeLayout(false);
            this.panelCheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCheckOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKeranjang;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2CustomCheckBox checkBoxSemua;
        public System.Windows.Forms.Label labelTotalHarga;
        public Guna.UI2.WinForms.Guna2Button buttonBeli;
    }
}
