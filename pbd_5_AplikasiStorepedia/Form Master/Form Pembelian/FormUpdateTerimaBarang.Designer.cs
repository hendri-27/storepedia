namespace pbd_5_AplikasiStorepedia
{
    partial class FormUpdateTerimaBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateTerimaBarang));
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.dateTimePickerTanggalPesan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelNotaBeli = new System.Windows.Forms.Panel();
            this.comboBoxNoNota = new System.Windows.Forms.ComboBox();
            this.labelPegawai = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewNotaBeli = new System.Windows.Forms.DataGridView();
            this.dateTimePickerTanggalTerima = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNamaSupplier = new System.Windows.Forms.TextBox();
            this.textBoxNamaKurir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelNotaBeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotaBeli)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonKeluar.FlatAppearance.BorderSize = 0;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(671, 585);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(103, 32);
            this.buttonKeluar.TabIndex = 20;
            this.buttonKeluar.TabStop = false;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.ButtonKeluar_Click);
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKosongi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonKosongi.FlatAppearance.BorderSize = 0;
            this.buttonKosongi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKosongi.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.White;
            this.buttonKosongi.Location = new System.Drawing.Point(521, 585);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(103, 32);
            this.buttonKosongi.TabIndex = 19;
            this.buttonKosongi.TabStop = false;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.ButtonKosongi_Click);
            // 
            // dateTimePickerTanggalPesan
            // 
            this.dateTimePickerTanggalPesan.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dateTimePickerTanggalPesan.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dateTimePickerTanggalPesan.CustomFormat = "dd / MM / yyyy";
            this.dateTimePickerTanggalPesan.Enabled = false;
            this.dateTimePickerTanggalPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTanggalPesan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTanggalPesan.Location = new System.Drawing.Point(169, 54);
            this.dateTimePickerTanggalPesan.Name = "dateTimePickerTanggalPesan";
            this.dateTimePickerTanggalPesan.Size = new System.Drawing.Size(134, 24);
            this.dateTimePickerTanggalPesan.TabIndex = 3;
            this.dateTimePickerTanggalPesan.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tanggal Pesan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "No Nota :";
            // 
            // panelNotaBeli
            // 
            this.panelNotaBeli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNotaBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.panelNotaBeli.Controls.Add(this.comboBoxNoNota);
            this.panelNotaBeli.Controls.Add(this.labelPegawai);
            this.panelNotaBeli.Controls.Add(this.label15);
            this.panelNotaBeli.Controls.Add(this.textBoxAlamat);
            this.panelNotaBeli.Controls.Add(this.label6);
            this.panelNotaBeli.Controls.Add(this.label7);
            this.panelNotaBeli.Controls.Add(this.labelGrandTotal);
            this.panelNotaBeli.Controls.Add(this.label12);
            this.panelNotaBeli.Controls.Add(this.dataGridViewNotaBeli);
            this.panelNotaBeli.Controls.Add(this.dateTimePickerTanggalTerima);
            this.panelNotaBeli.Controls.Add(this.label2);
            this.panelNotaBeli.Controls.Add(this.dateTimePickerTanggalPesan);
            this.panelNotaBeli.Controls.Add(this.label5);
            this.panelNotaBeli.Controls.Add(this.textBoxNamaSupplier);
            this.panelNotaBeli.Controls.Add(this.textBoxNamaKurir);
            this.panelNotaBeli.Controls.Add(this.label4);
            this.panelNotaBeli.Controls.Add(this.label3);
            this.panelNotaBeli.Location = new System.Drawing.Point(14, 52);
            this.panelNotaBeli.Name = "panelNotaBeli";
            this.panelNotaBeli.Size = new System.Drawing.Size(768, 523);
            this.panelNotaBeli.TabIndex = 17;
            // 
            // comboBoxNoNota
            // 
            this.comboBoxNoNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNoNota.BackColor = System.Drawing.Color.White;
            this.comboBoxNoNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNoNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNoNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNoNota.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNoNota.FormattingEnabled = true;
            this.comboBoxNoNota.Location = new System.Drawing.Point(169, 18);
            this.comboBoxNoNota.Name = "comboBoxNoNota";
            this.comboBoxNoNota.Size = new System.Drawing.Size(134, 26);
            this.comboBoxNoNota.TabIndex = 70;
            this.comboBoxNoNota.TabStop = false;
            // 
            // labelPegawai
            // 
            this.labelPegawai.AutoSize = true;
            this.labelPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPegawai.ForeColor = System.Drawing.Color.White;
            this.labelPegawai.Location = new System.Drawing.Point(497, 127);
            this.labelPegawai.Name = "labelPegawai";
            this.labelPegawai.Size = new System.Drawing.Size(162, 16);
            this.labelPegawai.TabIndex = 69;
            this.labelPegawai.Text = "Kode - Nama Pegawai";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(411, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 18);
            this.label15.TabIndex = 68;
            this.label15.Text = "Pegawai :";
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlamat.BackColor = System.Drawing.Color.White;
            this.textBoxAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAlamat.Enabled = false;
            this.textBoxAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamat.ForeColor = System.Drawing.Color.Black;
            this.textBoxAlamat.Location = new System.Drawing.Point(498, 55);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlamat.Size = new System.Drawing.Size(246, 53);
            this.textBoxAlamat.TabIndex = 65;
            this.textBoxAlamat.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(423, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 67;
            this.label6.Text = "Alamat :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(365, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Nama Supplier :";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelGrandTotal.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.ForeColor = System.Drawing.Color.White;
            this.labelGrandTotal.Location = new System.Drawing.Point(26, 192);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(717, 68);
            this.labelGrandTotal.TabIndex = 63;
            this.labelGrandTotal.Text = "Rp0";
            this.labelGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(35, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 62;
            this.label12.Text = "TOTAL HARGA";
            // 
            // dataGridViewNotaBeli
            // 
            this.dataGridViewNotaBeli.AllowUserToAddRows = false;
            this.dataGridViewNotaBeli.AllowUserToDeleteRows = false;
            this.dataGridViewNotaBeli.AllowUserToResizeColumns = false;
            this.dataGridViewNotaBeli.AllowUserToResizeRows = false;
            this.dataGridViewNotaBeli.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridViewNotaBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotaBeli.Location = new System.Drawing.Point(26, 280);
            this.dataGridViewNotaBeli.Name = "dataGridViewNotaBeli";
            this.dataGridViewNotaBeli.ReadOnly = true;
            this.dataGridViewNotaBeli.Size = new System.Drawing.Size(717, 221);
            this.dataGridViewNotaBeli.TabIndex = 61;
            this.dataGridViewNotaBeli.TabStop = false;
            // 
            // dateTimePickerTanggalTerima
            // 
            this.dateTimePickerTanggalTerima.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dateTimePickerTanggalTerima.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dateTimePickerTanggalTerima.CustomFormat = "dd / MM / yyyy";
            this.dateTimePickerTanggalTerima.Enabled = false;
            this.dateTimePickerTanggalTerima.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTanggalTerima.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTanggalTerima.Location = new System.Drawing.Point(169, 89);
            this.dateTimePickerTanggalTerima.Name = "dateTimePickerTanggalTerima";
            this.dateTimePickerTanggalTerima.Size = new System.Drawing.Size(134, 24);
            this.dateTimePickerTanggalTerima.TabIndex = 3;
            this.dateTimePickerTanggalTerima.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tanggal Terima:";
            // 
            // textBoxNamaSupplier
            // 
            this.textBoxNamaSupplier.BackColor = System.Drawing.Color.White;
            this.textBoxNamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNamaSupplier.Enabled = false;
            this.textBoxNamaSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaSupplier.ForeColor = System.Drawing.Color.Black;
            this.textBoxNamaSupplier.Location = new System.Drawing.Point(498, 21);
            this.textBoxNamaSupplier.Name = "textBoxNamaSupplier";
            this.textBoxNamaSupplier.Size = new System.Drawing.Size(245, 24);
            this.textBoxNamaSupplier.TabIndex = 0;
            this.textBoxNamaSupplier.TabStop = false;
            // 
            // textBoxNamaKurir
            // 
            this.textBoxNamaKurir.BackColor = System.Drawing.Color.White;
            this.textBoxNamaKurir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNamaKurir.Enabled = false;
            this.textBoxNamaKurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaKurir.ForeColor = System.Drawing.Color.Black;
            this.textBoxNamaKurir.Location = new System.Drawing.Point(169, 123);
            this.textBoxNamaKurir.Name = "textBoxNamaKurir";
            this.textBoxNamaKurir.Size = new System.Drawing.Size(134, 24);
            this.textBoxNamaKurir.TabIndex = 0;
            this.textBoxNamaKurir.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama Kurir :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "UPDATE TERIMA BARANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(399, 585);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(103, 32);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // FormUpdateTerimaBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(795, 627);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.panelNotaBeli);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpdateTerimaBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Terima Barang";
            this.Load += new System.EventHandler(this.FormUpdateTerimaBarang_Load);
            this.panelNotaBeli.ResumeLayout(false);
            this.panelNotaBeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotaBeli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalPesan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelNotaBeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridViewNotaBeli;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalTerima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNamaKurir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNamaSupplier;
        private System.Windows.Forms.Label labelPegawai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxNoNota;
    }
}