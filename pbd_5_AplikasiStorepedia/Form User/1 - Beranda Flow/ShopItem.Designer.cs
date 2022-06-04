namespace pbd_5_AplikasiStorepedia
{
    partial class ShopItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopItem));
            this.pictureBoxBarang = new System.Windows.Forms.PictureBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelRp = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBarang
            // 
            this.pictureBoxBarang.BackColor = System.Drawing.Color.White;
            this.pictureBoxBarang.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBarang.Image")));
            this.pictureBoxBarang.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxBarang.Name = "pictureBoxBarang";
            this.pictureBoxBarang.Size = new System.Drawing.Size(206, 170);
            this.pictureBoxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBarang.TabIndex = 0;
            this.pictureBoxBarang.TabStop = false;
            this.pictureBoxBarang.Click += new System.EventHandler(this.ShopItem_Click);
            // 
            // labelNama
            // 
            this.labelNama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.ForeColor = System.Drawing.Color.White;
            this.labelNama.Location = new System.Drawing.Point(11, 180);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(190, 45);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "lalalalalalalaala alalalal";
            this.labelNama.Click += new System.EventHandler(this.ShopItem_Click);
            // 
            // labelRp
            // 
            this.labelRp.AutoSize = true;
            this.labelRp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRp.ForeColor = System.Drawing.Color.White;
            this.labelRp.Location = new System.Drawing.Point(14, 235);
            this.labelRp.Name = "labelRp";
            this.labelRp.Size = new System.Drawing.Size(27, 17);
            this.labelRp.TabIndex = 2;
            this.labelRp.Text = "Rp";
            this.labelRp.Click += new System.EventHandler(this.ShopItem_Click);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.ForeColor = System.Drawing.Color.White;
            this.labelHarga.Location = new System.Drawing.Point(36, 235);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(52, 17);
            this.labelHarga.TabIndex = 3;
            this.labelHarga.Text = "21.500";
            this.labelHarga.Click += new System.EventHandler(this.ShopItem_Click);
            // 
            // ShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelRp);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.pictureBoxBarang);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ShopItem";
            this.Size = new System.Drawing.Size(208, 268);
            this.Click += new System.EventHandler(this.ShopItem_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShopItem_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBarang;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelRp;
        private System.Windows.Forms.Label labelHarga;
    }
}
