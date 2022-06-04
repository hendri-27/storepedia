namespace pbd_5_AplikasiStorepedia
{
    partial class UCHeader
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
            this.labelNoNota = new System.Windows.Forms.Label();
            this.labelTglTransaksi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "No. Nota : ";
            // 
            // labelNoNota
            // 
            this.labelNoNota.AutoSize = true;
            this.labelNoNota.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoNota.ForeColor = System.Drawing.Color.White;
            this.labelNoNota.Location = new System.Drawing.Point(92, 11);
            this.labelNoNota.Margin = new System.Windows.Forms.Padding(0);
            this.labelNoNota.Name = "labelNoNota";
            this.labelNoNota.Size = new System.Drawing.Size(81, 17);
            this.labelNoNota.TabIndex = 24;
            this.labelNoNota.Text = "nomor nota";
            // 
            // labelTglTransaksi
            // 
            this.labelTglTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTglTransaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTglTransaksi.ForeColor = System.Drawing.Color.White;
            this.labelTglTransaksi.Location = new System.Drawing.Point(494, 11);
            this.labelTglTransaksi.Margin = new System.Windows.Forms.Padding(0);
            this.labelTglTransaksi.Name = "labelTglTransaksi";
            this.labelTglTransaksi.Size = new System.Drawing.Size(184, 17);
            this.labelTglTransaksi.TabIndex = 25;
            this.labelTglTransaksi.Text = "Tanggal pembelian";
            this.labelTglTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.labelTglTransaksi);
            this.Controls.Add(this.labelNoNota);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCHeader";
            this.Size = new System.Drawing.Size(700, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNoNota;
        private System.Windows.Forms.Label labelTglTransaksi;
    }
}
