namespace pbd_5_AplikasiStorepedia
{
    partial class FormBeranda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeranda));
            this.flowLayoutPanelSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.labelCounter = new System.Windows.Forms.Label();
            this.buttonRefresh = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonSearch = new FontAwesome.Sharp.IconPictureBox();
            this.buttonFilter = new FontAwesome.Sharp.IconButton();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.labelNotFound = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelSearch
            // 
            this.flowLayoutPanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelSearch.AutoScroll = true;
            this.flowLayoutPanelSearch.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelSearch.Location = new System.Drawing.Point(13, 67);
            this.flowLayoutPanelSearch.Name = "flowLayoutPanelSearch";
            this.flowLayoutPanelSearch.Size = new System.Drawing.Size(687, 468);
            this.flowLayoutPanelSearch.TabIndex = 7;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelSearch.Controls.Add(this.labelCounter);
            this.panelSearch.Controls.Add(this.buttonRefresh);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.buttonFilter);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(700, 53);
            this.panelSearch.TabIndex = 6;
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelCounter.ForeColor = System.Drawing.Color.Yellow;
            this.labelCounter.Location = new System.Drawing.Point(46, 30);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(21, 13);
            this.labelCounter.TabIndex = 9;
            this.labelCounter.Text = "5 s";
            this.labelCounter.Visible = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.buttonRefresh.IconColor = System.Drawing.Color.White;
            this.buttonRefresh.IconSize = 30;
            this.buttonRefresh.Location = new System.Drawing.Point(21, 11);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(30, 30);
            this.buttonRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.TabStop = false;
            this.buttonRefresh.UseGdi = true;
            this.buttonRefresh.UseIconCache = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Animated = true;
            this.textBoxSearch.BorderRadius = 8;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.Parent = this.textBoxSearch;
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.FocusedState.Parent = this.textBoxSearch;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.HoverState.Parent = this.textBoxSearch;
            this.textBoxSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxSearch.IconRightSize = new System.Drawing.Size(15, 15);
            this.textBoxSearch.Location = new System.Drawing.Point(77, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Cari barang disini . . .";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.ShadowDecoration.Parent = this.textBoxSearch;
            this.textBoxSearch.Size = new System.Drawing.Size(480, 28);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            this.textBoxSearch.IconRightClick += new System.EventHandler(this.TextBoxSearch_IconRightClick);
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearch_KeyPress);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearch.IconColor = System.Drawing.Color.White;
            this.buttonSearch.IconSize = 30;
            this.buttonSearch.Location = new System.Drawing.Point(565, 11);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(30, 30);
            this.buttonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.UseGdi = true;
            this.buttonSearch.UseIconCache = true;
            this.buttonSearch.Visible = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.FlatAppearance.BorderSize = 0;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.ForeColor = System.Drawing.Color.White;
            this.buttonFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.buttonFilter.IconColor = System.Drawing.Color.White;
            this.buttonFilter.IconSize = 20;
            this.buttonFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilter.Location = new System.Drawing.Point(607, 11);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.buttonFilter.Rotation = 0D;
            this.buttonFilter.Size = new System.Drawing.Size(74, 30);
            this.buttonFilter.TabIndex = 3;
            this.buttonFilter.TabStop = false;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFilter.UseCompatibleTextRendering = true;
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Interval = 10;
            this.timerLoad.Tick += new System.EventHandler(this.TimerLoad_Tick);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // labelNotFound
            // 
            this.labelNotFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNotFound.AutoSize = true;
            this.labelNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelNotFound.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelNotFound.Location = new System.Drawing.Point(196, 241);
            this.labelNotFound.Name = "labelNotFound";
            this.labelNotFound.Size = new System.Drawing.Size(309, 58);
            this.labelNotFound.TabIndex = 8;
            this.labelNotFound.Text = "Produk tidak ditemukan.\r\nMohon coba mencari ulang.";
            this.labelNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNotFound.Visible = false;
            // 
            // FormBeranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 536);
            this.Controls.Add(this.labelNotFound);
            this.Controls.Add(this.flowLayoutPanelSearch);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBeranda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Beranda";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSearch;
        private System.Windows.Forms.Panel panelSearch;
        private FontAwesome.Sharp.IconPictureBox buttonSearch;
        private FontAwesome.Sharp.IconButton buttonFilter;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private System.Windows.Forms.Timer timerLoad;
        private FontAwesome.Sharp.IconPictureBox buttonRefresh;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label labelNotFound;
    }
}