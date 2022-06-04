namespace pbd_5_AplikasiStorepedia
{
    partial class PageLoading
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bgLoading = new Guna.UI2.WinForms.Guna2Panel();
            this.loading = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.bgLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please wait!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading . . .";
            // 
            // elipse
            // 
            this.elipse.BorderRadius = 20;
            this.elipse.TargetControl = this.bgLoading;
            // 
            // bgLoading
            // 
            this.bgLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bgLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.bgLoading.Controls.Add(this.loading);
            this.bgLoading.Location = new System.Drawing.Point(276, 186);
            this.bgLoading.Name = "bgLoading";
            this.bgLoading.ShadowDecoration.Parent = this.bgLoading;
            this.bgLoading.Size = new System.Drawing.Size(106, 105);
            this.bgLoading.TabIndex = 4;
            // 
            // loading
            // 
            this.loading.AnimationSpeed = 65;
            this.loading.AutoStart = true;
            this.loading.CircleSize = 0.5F;
            this.loading.Location = new System.Drawing.Point(29, 29);
            this.loading.Name = "loading";
            this.loading.NumberOfCircles = 7;
            this.loading.ProgressColor = System.Drawing.Color.White;
            this.loading.Size = new System.Drawing.Size(44, 44);
            this.loading.TabIndex = 2;
            // 
            // PageLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bgLoading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PageLoading";
            this.Size = new System.Drawing.Size(683, 489);
            this.bgLoading.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse elipse;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator loading;
        private Guna.UI2.WinForms.Guna2Panel bgLoading;
    }
}
