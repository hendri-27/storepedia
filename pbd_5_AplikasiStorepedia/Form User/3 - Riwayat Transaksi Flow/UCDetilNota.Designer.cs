namespace pbd_5_AplikasiStorepedia
{
    partial class UCDetilNota
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
            this.pictureBoxBarang = new System.Windows.Forms.PictureBox();
            this.labelNamaBrg = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBarang
            // 
            this.pictureBoxBarang.Location = new System.Drawing.Point(25, 17);
            this.pictureBoxBarang.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxBarang.Name = "pictureBoxBarang";
            this.pictureBoxBarang.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBarang.TabIndex = 1;
            this.pictureBoxBarang.TabStop = false;
            // 
            // labelNamaBrg
            // 
            this.labelNamaBrg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNamaBrg.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaBrg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBrg.Location = new System.Drawing.Point(111, 17);
            this.labelNamaBrg.Margin = new System.Windows.Forms.Padding(0);
            this.labelNamaBrg.Name = "labelNamaBrg";
            this.labelNamaBrg.Size = new System.Drawing.Size(557, 20);
            this.labelNamaBrg.TabIndex = 20;
            this.labelNamaBrg.Text = "Nama Produk";
            // 
            // labelJumlah
            // 
            this.labelJumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJumlah.BackColor = System.Drawing.Color.Transparent;
            this.labelJumlah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelJumlah.Location = new System.Drawing.Point(617, 46);
            this.labelJumlah.Margin = new System.Windows.Forms.Padding(0);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelJumlah.Size = new System.Drawing.Size(54, 17);
            this.labelJumlah.TabIndex = 21;
            this.labelJumlah.Text = "x0";
            // 
            // labelHarga
            // 
            this.labelHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHarga.BackColor = System.Drawing.Color.Transparent;
            this.labelHarga.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHarga.Location = new System.Drawing.Point(534, 70);
            this.labelHarga.Margin = new System.Windows.Forms.Padding(0);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelHarga.Size = new System.Drawing.Size(137, 17);
            this.labelHarga.TabIndex = 22;
            this.labelHarga.Text = "Rp 0";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(700, 2);
            this.label4.TabIndex = 23;
            // 
            // UCDetilNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelNamaBrg);
            this.Controls.Add(this.pictureBoxBarang);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCDetilNota";
            this.Size = new System.Drawing.Size(700, 108);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBarang;
        private System.Windows.Forms.Label labelNamaBrg;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label label4;
    }
}
