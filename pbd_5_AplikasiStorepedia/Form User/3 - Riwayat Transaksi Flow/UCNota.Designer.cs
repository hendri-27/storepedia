namespace pbd_5_AplikasiStorepedia
{
    partial class UCNota
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelDetil = new System.Windows.Forms.FlowLayoutPanel();
            this.invisiblePanel = new pbd_5_AplikasiStorepedia.InvisiblePanel();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(0, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(700, 2);
            this.label4.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 2);
            this.label1.TabIndex = 25;
            // 
            // flowLayoutPanelDetil
            // 
            this.flowLayoutPanelDetil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelDetil.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelDetil.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelDetil.Location = new System.Drawing.Point(0, 2);
            this.flowLayoutPanelDetil.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelDetil.Name = "flowLayoutPanelDetil";
            this.flowLayoutPanelDetil.Size = new System.Drawing.Size(700, 196);
            this.flowLayoutPanelDetil.TabIndex = 26;
            this.flowLayoutPanelDetil.WrapContents = false;
            // 
            // invisiblePanel
            // 
            this.invisiblePanel.BackColor = System.Drawing.Color.Transparent;
            this.invisiblePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invisiblePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invisiblePanel.Location = new System.Drawing.Point(0, 0);
            this.invisiblePanel.Margin = new System.Windows.Forms.Padding(0);
            this.invisiblePanel.Name = "invisiblePanel";
            this.invisiblePanel.Size = new System.Drawing.Size(700, 200);
            this.invisiblePanel.TabIndex = 0;
            this.invisiblePanel.Click += new System.EventHandler(this.InvisiblePanel_Click);
            // 
            // UCNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.invisiblePanel);
            this.Controls.Add(this.flowLayoutPanelDetil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Name = "UCNota";
            this.Size = new System.Drawing.Size(700, 200);
            this.Load += new System.EventHandler(this.UCNota_Load);
            this.Resize += new System.EventHandler(this.UCNota_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDetil;
        public InvisiblePanel invisiblePanel;
    }
}
