namespace pbd_5_AplikasiStorepedia
{
    partial class UCHistorySaldo
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
            this.panelSaldo = new System.Windows.Forms.Panel();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSaldo
            // 
            this.panelSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelSaldo.Controls.Add(this.buttonBack);
            this.panelSaldo.Controls.Add(this.label1);
            this.panelSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaldo.Location = new System.Drawing.Point(0, 0);
            this.panelSaldo.Name = "panelSaldo";
            this.panelSaldo.Size = new System.Drawing.Size(700, 53);
            this.panelSaldo.TabIndex = 134;
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
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "History Saldo";
            // 
            // flowLayoutPanelHistory
            // 
            this.flowLayoutPanelHistory.AutoScroll = true;
            this.flowLayoutPanelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelHistory.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanelHistory.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelHistory.Name = "flowLayoutPanelHistory";
            this.flowLayoutPanelHistory.Size = new System.Drawing.Size(700, 483);
            this.flowLayoutPanelHistory.TabIndex = 135;
            // 
            // UCHistorySaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelHistory);
            this.Controls.Add(this.panelSaldo);
            this.Name = "UCHistorySaldo";
            this.Size = new System.Drawing.Size(700, 536);
            this.Load += new System.EventHandler(this.UCHistorySaldo_Load);
            this.Resize += new System.EventHandler(this.UCHistorySaldo_Resize);
            this.panelSaldo.ResumeLayout(false);
            this.panelSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSaldo;
        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHistory;
    }
}
