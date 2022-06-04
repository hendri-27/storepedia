namespace pbd_5_AplikasiStorepedia
{
    partial class UCDetailInvoice
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
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNamaBarang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNamaBarang.Location = new System.Drawing.Point(21, 14);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(260, 35);
            this.labelNamaBarang.TabIndex = 4;
            this.labelNamaBarang.Text = "Nama Produk";
            this.labelNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHarga
            // 
            this.labelHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHarga.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHarga.Location = new System.Drawing.Point(308, 24);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelHarga.Size = new System.Drawing.Size(137, 17);
            this.labelHarga.TabIndex = 4;
            this.labelHarga.Text = "Rp 0";
            // 
            // labelJumlah
            // 
            this.labelJumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJumlah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelJumlah.Location = new System.Drawing.Point(460, 24);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelJumlah.Size = new System.Drawing.Size(54, 17);
            this.labelJumlah.TabIndex = 4;
            this.labelJumlah.Text = "x0";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSubTotal.Location = new System.Drawing.Point(529, 24);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSubTotal.Size = new System.Drawing.Size(145, 17);
            this.labelSubTotal.TabIndex = 4;
            this.labelSubTotal.Text = "Rp 0";
            this.labelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(697, 2);
            this.label4.TabIndex = 5;
            // 
            // UCDetailInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelNamaBarang);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCDetailInvoice";
            this.Size = new System.Drawing.Size(700, 68);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelSubTotal;
    }
}
