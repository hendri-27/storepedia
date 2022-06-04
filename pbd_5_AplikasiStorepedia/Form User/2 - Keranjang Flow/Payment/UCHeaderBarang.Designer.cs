namespace pbd_5_AplikasiStorepedia
{
    partial class UCHeaderBarang
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
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelJumlah
            // 
            this.labelJumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.ForeColor = System.Drawing.Color.Black;
            this.labelJumlah.Location = new System.Drawing.Point(486, 6);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelJumlah.Size = new System.Drawing.Size(30, 17);
            this.labelJumlah.TabIndex = 5;
            this.labelJumlah.Text = "Qty";
            this.labelJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHarga
            // 
            this.labelHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.ForeColor = System.Drawing.Color.Black;
            this.labelHarga.Location = new System.Drawing.Point(401, 6);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelHarga.Size = new System.Drawing.Size(45, 17);
            this.labelHarga.TabIndex = 7;
            this.labelHarga.Text = "Harga";
            this.labelHarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.Location = new System.Drawing.Point(20, 6);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(91, 17);
            this.labelNamaBarang.TabIndex = 8;
            this.labelNamaBarang.Text = "Nama Barang";
            this.labelNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(697, 2);
            this.label4.TabIndex = 9;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.ForeColor = System.Drawing.Color.Black;
            this.labelSubTotal.Location = new System.Drawing.Point(612, 6);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSubTotal.Size = new System.Drawing.Size(64, 17);
            this.labelSubTotal.TabIndex = 6;
            this.labelSubTotal.Text = "Sub Total";
            this.labelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCHeaderBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelNamaBarang);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCHeaderBarang";
            this.Size = new System.Drawing.Size(700, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSubTotal;
    }
}
