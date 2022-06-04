namespace pbd_5_AplikasiStorepedia
{
    partial class UCPesanan
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWaktuPesan = new System.Windows.Forms.Label();
            this.labelNomorPesanan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "No. Pesanan";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(700, 2);
            this.label4.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Waktu Pemesanan";
            // 
            // labelWaktuPesan
            // 
            this.labelWaktuPesan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWaktuPesan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaktuPesan.ForeColor = System.Drawing.Color.DimGray;
            this.labelWaktuPesan.Location = new System.Drawing.Point(493, 37);
            this.labelWaktuPesan.Name = "labelWaktuPesan";
            this.labelWaktuPesan.Size = new System.Drawing.Size(179, 15);
            this.labelWaktuPesan.TabIndex = 18;
            this.labelWaktuPesan.Text = "Waktu";
            this.labelWaktuPesan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNomorPesanan
            // 
            this.labelNomorPesanan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNomorPesanan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomorPesanan.ForeColor = System.Drawing.Color.DimGray;
            this.labelNomorPesanan.Location = new System.Drawing.Point(490, 13);
            this.labelNomorPesanan.Name = "labelNomorPesanan";
            this.labelNomorPesanan.Size = new System.Drawing.Size(182, 15);
            this.labelNomorPesanan.TabIndex = 20;
            this.labelNomorPesanan.Text = "Nomor Pesanan";
            this.labelNomorPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelNomorPesanan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWaktuPesan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCPesanan";
            this.Size = new System.Drawing.Size(700, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWaktuPesan;
        private System.Windows.Forms.Label labelNomorPesanan;
    }
}
