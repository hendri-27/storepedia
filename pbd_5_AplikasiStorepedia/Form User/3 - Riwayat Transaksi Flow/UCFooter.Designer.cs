namespace pbd_5_AplikasiStorepedia
{
    partial class UCFooter
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
            this.labelTotalPembayaran = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotalPembayaran
            // 
            this.labelTotalPembayaran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalPembayaran.AutoSize = false;
            this.labelTotalPembayaran.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPembayaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPembayaran.Location = new System.Drawing.Point(237, 0);
            this.labelTotalPembayaran.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalPembayaran.Name = "labelTotalPembayaran";
            this.labelTotalPembayaran.Size = new System.Drawing.Size(431, 48);
            this.labelTotalPembayaran.TabIndex = 5;
            this.labelTotalPembayaran.Text = "Total Pembayaran Rp 0";
            this.labelTotalPembayaran.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalPembayaran.UseGdiPlusTextRendering = true;
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelJumlah.Location = new System.Drawing.Point(22, 15);
            this.labelJumlah.Margin = new System.Windows.Forms.Padding(0);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(63, 17);
            this.labelJumlah.TabIndex = 22;
            this.labelJumlah.Text = "0 produk";
            // 
            // UCFooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelTotalPembayaran);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCFooter";
            this.Size = new System.Drawing.Size(700, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTotalPembayaran;
        private System.Windows.Forms.Label labelJumlah;
    }
}
