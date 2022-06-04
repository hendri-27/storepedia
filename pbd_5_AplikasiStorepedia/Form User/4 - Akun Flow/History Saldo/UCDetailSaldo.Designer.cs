namespace pbd_5_AplikasiStorepedia
{
    partial class UCDetailSaldo
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
            this.labelNominal = new System.Windows.Forms.Label();
            this.labelTipeTransaksi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNoTransaksi = new System.Windows.Forms.Label();
            this.labelWaktu = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNominal
            // 
            this.labelNominal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNominal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNominal.ForeColor = System.Drawing.Color.Black;
            this.labelNominal.Location = new System.Drawing.Point(490, 21);
            this.labelNominal.Name = "labelNominal";
            this.labelNominal.Size = new System.Drawing.Size(182, 21);
            this.labelNominal.TabIndex = 24;
            this.labelNominal.Text = "+Rp 0";
            this.labelNominal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTipeTransaksi
            // 
            this.labelTipeTransaksi.AutoSize = true;
            this.labelTipeTransaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipeTransaksi.ForeColor = System.Drawing.Color.DimGray;
            this.labelTipeTransaksi.Location = new System.Drawing.Point(29, 11);
            this.labelTipeTransaksi.Name = "labelTipeTransaksi";
            this.labelTipeTransaksi.Size = new System.Drawing.Size(146, 20);
            this.labelTipeTransaksi.TabIndex = 25;
            this.labelTipeTransaksi.Text = "Tipe Transaksi Saldo";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(700, 2);
            this.label4.TabIndex = 23;
            // 
            // labelNoTransaksi
            // 
            this.labelNoTransaksi.AutoSize = true;
            this.labelNoTransaksi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoTransaksi.ForeColor = System.Drawing.Color.DimGray;
            this.labelNoTransaksi.Location = new System.Drawing.Point(29, 39);
            this.labelNoTransaksi.Name = "labelNoTransaksi";
            this.labelNoTransaksi.Size = new System.Drawing.Size(73, 15);
            this.labelNoTransaksi.TabIndex = 22;
            this.labelNoTransaksi.Text = "No Transaksi";
            // 
            // labelWaktu
            // 
            this.labelWaktu.AutoSize = true;
            this.labelWaktu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaktu.ForeColor = System.Drawing.Color.DimGray;
            this.labelWaktu.Location = new System.Drawing.Point(29, 60);
            this.labelWaktu.Name = "labelWaktu";
            this.labelWaktu.Size = new System.Drawing.Size(91, 15);
            this.labelWaktu.TabIndex = 22;
            this.labelWaktu.Text = "Waktu Transaksi";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatus.Location = new System.Drawing.Point(491, 46);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(182, 15);
            this.labelStatus.TabIndex = 24;
            this.labelStatus.Text = "Berhasil";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCDetailSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelNominal);
            this.Controls.Add(this.labelTipeTransaksi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWaktu);
            this.Controls.Add(this.labelNoTransaksi);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCDetailSaldo";
            this.Size = new System.Drawing.Size(700, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNominal;
        private System.Windows.Forms.Label labelTipeTransaksi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNoTransaksi;
        private System.Windows.Forms.Label labelWaktu;
        private System.Windows.Forms.Label labelStatus;
    }
}
