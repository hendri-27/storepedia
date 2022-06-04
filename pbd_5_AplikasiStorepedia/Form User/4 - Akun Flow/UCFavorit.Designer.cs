namespace pbd_5_AplikasiStorepedia
{
    partial class UCFavorit
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
            this.components = new System.ComponentModel.Container();
            this.panelFavorit = new System.Windows.Forms.Panel();
            this.buttonBack = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelFav = new System.Windows.Forms.FlowLayoutPanel();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.panelFavorit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFavorit
            // 
            this.panelFavorit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelFavorit.Controls.Add(this.buttonBack);
            this.panelFavorit.Controls.Add(this.label1);
            this.panelFavorit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFavorit.Location = new System.Drawing.Point(0, 0);
            this.panelFavorit.Name = "panelFavorit";
            this.panelFavorit.Size = new System.Drawing.Size(700, 53);
            this.panelFavorit.TabIndex = 58;
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
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Favorit Saya";
            // 
            // flowLayoutPanelFav
            // 
            this.flowLayoutPanelFav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFav.AutoScroll = true;
            this.flowLayoutPanelFav.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelFav.Location = new System.Drawing.Point(13, 67);
            this.flowLayoutPanelFav.Name = "flowLayoutPanelFav";
            this.flowLayoutPanelFav.Size = new System.Drawing.Size(687, 469);
            this.flowLayoutPanelFav.TabIndex = 59;
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Interval = 10;
            this.timerLoad.Tick += new System.EventHandler(this.TimerLoad_Tick);
            // 
            // UCFavorit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanelFav);
            this.Controls.Add(this.panelFavorit);
            this.Name = "UCFavorit";
            this.Size = new System.Drawing.Size(700, 536);
            this.panelFavorit.ResumeLayout(false);
            this.panelFavorit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFavorit;
        private FontAwesome.Sharp.IconButton buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFav;
        private System.Windows.Forms.Timer timerLoad;
    }
}
