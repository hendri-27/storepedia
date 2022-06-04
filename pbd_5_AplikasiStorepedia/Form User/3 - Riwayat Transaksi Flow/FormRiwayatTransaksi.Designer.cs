namespace pbd_5_AplikasiStorepedia
{
    partial class FormRiwayatTransaksi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRiwayatTransaksi));
            this.panelRiwayatTransaksi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelRiwayat = new System.Windows.Forms.FlowLayoutPanel();
            this.timerCreate = new System.Windows.Forms.Timer(this.components);
            this.panelRiwayatTransaksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRiwayatTransaksi
            // 
            this.panelRiwayatTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelRiwayatTransaksi.Controls.Add(this.label1);
            this.panelRiwayatTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRiwayatTransaksi.Location = new System.Drawing.Point(0, 0);
            this.panelRiwayatTransaksi.Name = "panelRiwayatTransaksi";
            this.panelRiwayatTransaksi.Size = new System.Drawing.Size(700, 53);
            this.panelRiwayatTransaksi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Riwayat Transaksi";
            // 
            // flowLayoutPanelRiwayat
            // 
            this.flowLayoutPanelRiwayat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRiwayat.AutoScroll = true;
            this.flowLayoutPanelRiwayat.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelRiwayat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRiwayat.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanelRiwayat.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelRiwayat.Name = "flowLayoutPanelRiwayat";
            this.flowLayoutPanelRiwayat.Size = new System.Drawing.Size(700, 483);
            this.flowLayoutPanelRiwayat.TabIndex = 7;
            this.flowLayoutPanelRiwayat.WrapContents = false;
            // 
            // timerCreate
            // 
            this.timerCreate.Interval = 20;
            this.timerCreate.Tick += new System.EventHandler(this.TimerCreate_Tick);
            // 
            // FormRiwayatTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 536);
            this.Controls.Add(this.flowLayoutPanelRiwayat);
            this.Controls.Add(this.panelRiwayatTransaksi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRiwayatTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Riwayat Transaksi";
            this.Load += new System.EventHandler(this.FormRiwayatTransaksi_Load);
            this.Resize += new System.EventHandler(this.FormRiwayatTransaksi_Resize);
            this.panelRiwayatTransaksi.ResumeLayout(false);
            this.panelRiwayatTransaksi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRiwayatTransaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRiwayat;
        private System.Windows.Forms.Timer timerCreate;
    }
}