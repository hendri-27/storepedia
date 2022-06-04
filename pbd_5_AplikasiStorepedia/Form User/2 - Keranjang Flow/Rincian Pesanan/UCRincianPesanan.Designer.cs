namespace pbd_5_AplikasiStorepedia
{
    partial class UCRincianPesanan
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
            this.panelRincian = new System.Windows.Forms.Panel();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutRincian = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRincian.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRincian
            // 
            this.panelRincian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelRincian.Controls.Add(this.buttonBack);
            this.panelRincian.Controls.Add(this.label1);
            this.panelRincian.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRincian.Location = new System.Drawing.Point(0, 0);
            this.panelRincian.Name = "panelRincian";
            this.panelRincian.Size = new System.Drawing.Size(700, 53);
            this.panelRincian.TabIndex = 59;
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
            this.buttonBack.TabIndex = 55;
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
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rincian Pesanan";
            // 
            // flowLayoutRincian
            // 
            this.flowLayoutRincian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutRincian.AutoScroll = true;
            this.flowLayoutRincian.BackColor = System.Drawing.Color.White;
            this.flowLayoutRincian.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutRincian.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutRincian.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutRincian.Name = "flowLayoutRincian";
            this.flowLayoutRincian.Size = new System.Drawing.Size(700, 483);
            this.flowLayoutRincian.TabIndex = 60;
            this.flowLayoutRincian.WrapContents = false;
            // 
            // UCRincianPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutRincian);
            this.Controls.Add(this.panelRincian);
            this.Name = "UCRincianPesanan";
            this.Size = new System.Drawing.Size(700, 536);
            this.Load += new System.EventHandler(this.UCRincianPesanan_Load);
            this.Resize += new System.EventHandler(this.UCRincianPesanan_Resize);
            this.panelRincian.ResumeLayout(false);
            this.panelRincian.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRincian;
        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutRincian;
    }
}
