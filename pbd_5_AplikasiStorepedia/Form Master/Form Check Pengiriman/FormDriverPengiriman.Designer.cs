namespace pbd_5_AplikasiStorepedia
{
    partial class FormDriverPengiriman
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDriverPengiriman));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPengiriman = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 40);
            this.label1.TabIndex = 34;
            this.label1.Text = "DAFTAR PENGIRIMAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelPengiriman
            // 
            this.flowLayoutPanelPengiriman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPengiriman.AutoScroll = true;
            this.flowLayoutPanelPengiriman.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelPengiriman.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelPengiriman.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanelPengiriman.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelPengiriman.Name = "flowLayoutPanelPengiriman";
            this.flowLayoutPanelPengiriman.Size = new System.Drawing.Size(730, 501);
            this.flowLayoutPanelPengiriman.TabIndex = 35;
            this.flowLayoutPanelPengiriman.WrapContents = false;
            // 
            // FormDriverPengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(730, 541);
            this.Controls.Add(this.flowLayoutPanelPengiriman);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDriverPengiriman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver Pengiriman";
            this.Load += new System.EventHandler(this.FormDriverPengiriman_Load);
            this.Resize += new System.EventHandler(this.FormDriverPengiriman_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPengiriman;
    }
}