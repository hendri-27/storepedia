namespace pbd_5_AplikasiStorepedia
{
    partial class UCEmptyCart
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
            this.buttonBelanja = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBelanja
            // 
            this.buttonBelanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBelanja.CheckedState.Parent = this.buttonBelanja;
            this.buttonBelanja.CustomBorderColor = System.Drawing.Color.Maroon;
            this.buttonBelanja.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.buttonBelanja.CustomImages.Parent = this.buttonBelanja;
            this.buttonBelanja.FillColor = System.Drawing.Color.Maroon;
            this.buttonBelanja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBelanja.ForeColor = System.Drawing.Color.White;
            this.buttonBelanja.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBelanja.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBelanja.HoverState.Parent = this.buttonBelanja;
            this.buttonBelanja.Location = new System.Drawing.Point(244, 345);
            this.buttonBelanja.Name = "buttonBelanja";
            this.buttonBelanja.ShadowDecoration.Color = System.Drawing.Color.White;
            this.buttonBelanja.ShadowDecoration.Enabled = true;
            this.buttonBelanja.ShadowDecoration.Parent = this.buttonBelanja;
            this.buttonBelanja.Size = new System.Drawing.Size(180, 45);
            this.buttonBelanja.TabIndex = 6;
            this.buttonBelanja.TabStop = false;
            this.buttonBelanja.Text = "Belanja Sekarang";
            this.buttonBelanja.Click += new System.EventHandler(this.ButtonBelanja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::pbd_5_AplikasiStorepedia.Properties.Resources.empty_cart;
            this.pictureBox1.Location = new System.Drawing.Point(206, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wah.. Keranjang kamu kosong.\r\nYuk Belanja Sekarang!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCEmptyCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBelanja);
            this.Name = "UCEmptyCart";
            this.Size = new System.Drawing.Size(700, 483);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button buttonBelanja;
        private System.Windows.Forms.Label label2;
    }
}
