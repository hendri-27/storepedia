namespace pbd_5_AplikasiStorepedia
{
    partial class UCPayment
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
            this.panelPembayaran = new System.Windows.Forms.Panel();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCheckOut = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuatPesanan = new Guna.UI2.WinForms.Guna2Button();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.panelPembayaran.SuspendLayout();
            this.panelCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPembayaran
            // 
            this.panelPembayaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelPembayaran.Controls.Add(this.buttonBack);
            this.panelPembayaran.Controls.Add(this.label1);
            this.panelPembayaran.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPembayaran.Location = new System.Drawing.Point(0, 0);
            this.panelPembayaran.Name = "panelPembayaran";
            this.panelPembayaran.Size = new System.Drawing.Size(700, 53);
            this.panelPembayaran.TabIndex = 4;
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonBack.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.buttonBack.IconColor = System.Drawing.Color.White;
            this.buttonBack.IconSize = 25;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Rotation = 0D;
            this.buttonBack.Size = new System.Drawing.Size(52, 53);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = " ";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.ButtonBack_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.ButtonBack_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pembayaran";
            // 
            // flowLayoutPanelDetail
            // 
            this.flowLayoutPanelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelDetail.AutoScroll = true;
            this.flowLayoutPanelDetail.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelDetail.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanelDetail.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelDetail.Name = "flowLayoutPanelDetail";
            this.flowLayoutPanelDetail.Size = new System.Drawing.Size(700, 414);
            this.flowLayoutPanelDetail.TabIndex = 7;
            this.flowLayoutPanelDetail.WrapContents = false;
            // 
            // panelCheckOut
            // 
            this.panelCheckOut.BackColor = System.Drawing.Color.LightGray;
            this.panelCheckOut.Controls.Add(this.label3);
            this.panelCheckOut.Controls.Add(this.buttonBuatPesanan);
            this.panelCheckOut.Controls.Add(this.labelTotalHarga);
            this.panelCheckOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCheckOut.Location = new System.Drawing.Point(0, 467);
            this.panelCheckOut.Name = "panelCheckOut";
            this.panelCheckOut.Size = new System.Drawing.Size(700, 69);
            this.panelCheckOut.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Pembayaran";
            // 
            // buttonBuatPesanan
            // 
            this.buttonBuatPesanan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuatPesanan.CheckedState.Parent = this.buttonBuatPesanan;
            this.buttonBuatPesanan.CustomImages.Parent = this.buttonBuatPesanan;
            this.buttonBuatPesanan.Enabled = false;
            this.buttonBuatPesanan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonBuatPesanan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuatPesanan.ForeColor = System.Drawing.Color.White;
            this.buttonBuatPesanan.HoverState.Parent = this.buttonBuatPesanan;
            this.buttonBuatPesanan.Location = new System.Drawing.Point(496, 15);
            this.buttonBuatPesanan.Name = "buttonBuatPesanan";
            this.buttonBuatPesanan.ShadowDecoration.Parent = this.buttonBuatPesanan;
            this.buttonBuatPesanan.Size = new System.Drawing.Size(191, 39);
            this.buttonBuatPesanan.TabIndex = 1;
            this.buttonBuatPesanan.TabStop = false;
            this.buttonBuatPesanan.Text = "Buat Pesanan";
            this.buttonBuatPesanan.Click += new System.EventHandler(this.ButtonBuatPesanan_Click);
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
            // UCPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanelDetail);
            this.Controls.Add(this.panelCheckOut);
            this.Controls.Add(this.panelPembayaran);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCPayment";
            this.Size = new System.Drawing.Size(700, 536);
            this.Load += new System.EventHandler(this.UCPayment_Load);
            this.Resize += new System.EventHandler(this.UCPayment_Resize);
            this.panelPembayaran.ResumeLayout(false);
            this.panelPembayaran.PerformLayout();
            this.panelCheckOut.ResumeLayout(false);
            this.panelCheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPembayaran;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Panel panelCheckOut;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2Button buttonBuatPesanan;
        public System.Windows.Forms.Label labelTotalHarga;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDetail;
    }
}
