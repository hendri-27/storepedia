namespace pbd_5_AplikasiStorepedia
{
    partial class FormCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCredit));
            this.label1 = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.labelGuna = new System.Windows.Forms.Label();
            this.labelFontAwesome = new System.Windows.Forms.Label();
            this.DragFormCredit = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credits";
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.panelTopBar.Controls.Add(this.buttonClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(284, 34);
            this.panelTopBar.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonClose.IconColor = System.Drawing.Color.Black;
            this.buttonClose.IconSize = 16;
            this.buttonClose.Location = new System.Drawing.Point(233, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Rotation = 0D;
            this.buttonClose.Size = new System.Drawing.Size(51, 34);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.MouseEntering);
            this.buttonClose.MouseLeave += new System.EventHandler(this.MouseLeaving);
            // 
            // labelGuna
            // 
            this.labelGuna.AutoSize = true;
            this.labelGuna.BackColor = System.Drawing.Color.Transparent;
            this.labelGuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGuna.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelGuna.ForeColor = System.Drawing.Color.Transparent;
            this.labelGuna.Location = new System.Drawing.Point(59, 101);
            this.labelGuna.Name = "labelGuna";
            this.labelGuna.Size = new System.Drawing.Size(156, 20);
            this.labelGuna.TabIndex = 11;
            this.labelGuna.Text = "Guna UI Framework";
            this.labelGuna.Click += new System.EventHandler(this.labelGuna_Click);
            this.labelGuna.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            this.labelGuna.MouseLeave += new System.EventHandler(this.MouseLeaveEvent);
            // 
            // labelFontAwesome
            // 
            this.labelFontAwesome.AutoSize = true;
            this.labelFontAwesome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFontAwesome.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelFontAwesome.ForeColor = System.Drawing.Color.White;
            this.labelFontAwesome.Location = new System.Drawing.Point(78, 147);
            this.labelFontAwesome.Name = "labelFontAwesome";
            this.labelFontAwesome.Size = new System.Drawing.Size(118, 20);
            this.labelFontAwesome.TabIndex = 12;
            this.labelFontAwesome.Text = "Font Awesome";
            this.labelFontAwesome.Click += new System.EventHandler(this.labelFontAwesome_Click);
            this.labelFontAwesome.MouseEnter += new System.EventHandler(this.MouseEnterEvent);
            this.labelFontAwesome.MouseLeave += new System.EventHandler(this.MouseLeaveEvent);
            // 
            // DragFormCredit
            // 
            this.DragFormCredit.ContainerControl = this;
            this.DragFormCredit.TargetControl = this.panelTopBar;
            // 
            // FormCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.labelFontAwesome);
            this.Controls.Add(this.labelGuna);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Credit";
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTopBar;
        private FontAwesome.Sharp.IconButton buttonClose;
        private System.Windows.Forms.Label labelGuna;
        private System.Windows.Forms.Label labelFontAwesome;
        private Guna.UI2.WinForms.Guna2DragControl DragFormCredit;
    }
}