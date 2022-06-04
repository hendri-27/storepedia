namespace pbd_5_AplikasiStorepedia
{
    partial class FormUbahBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUbahBarang));
            this.labelGambar = new System.Windows.Forms.Label();
            this.buttonGambar = new System.Windows.Forms.Button();
            this.comboBoxMerek = new System.Windows.Forms.ComboBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBarang = new System.Windows.Forms.Panel();
            this.labelJum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDeskripsi = new System.Windows.Forms.TextBox();
            this.textBoxHargaJual = new System.Windows.Forms.TextBox();
            this.panelBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGambar
            // 
            this.labelGambar.AutoSize = true;
            this.labelGambar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGambar.ForeColor = System.Drawing.Color.White;
            this.labelGambar.Location = new System.Drawing.Point(273, 159);
            this.labelGambar.Name = "labelGambar";
            this.labelGambar.Size = new System.Drawing.Size(101, 15);
            this.labelGambar.TabIndex = 26;
            this.labelGambar.Text = "No File Choosen.";
            this.labelGambar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonGambar
            // 
            this.buttonGambar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGambar.Location = new System.Drawing.Point(196, 155);
            this.buttonGambar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGambar.Name = "buttonGambar";
            this.buttonGambar.Size = new System.Drawing.Size(72, 24);
            this.buttonGambar.TabIndex = 25;
            this.buttonGambar.Text = "Browse";
            this.buttonGambar.UseVisualStyleBackColor = true;
            this.buttonGambar.Click += new System.EventHandler(this.ButtonGambar_Click);
            // 
            // comboBoxMerek
            // 
            this.comboBoxMerek.BackColor = System.Drawing.Color.White;
            this.comboBoxMerek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMerek.Enabled = false;
            this.comboBoxMerek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMerek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMerek.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMerek.FormattingEnabled = true;
            this.comboBoxMerek.Location = new System.Drawing.Point(196, 227);
            this.comboBoxMerek.Name = "comboBoxMerek";
            this.comboBoxMerek.Size = new System.Drawing.Size(199, 26);
            this.comboBoxMerek.TabIndex = 7;
            // 
            // textBoxNama
            // 
            this.textBoxNama.BackColor = System.Drawing.Color.White;
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNama.Enabled = false;
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.ForeColor = System.Drawing.Color.Black;
            this.textBoxNama.Location = new System.Drawing.Point(196, 55);
            this.textBoxNama.MaxLength = 45;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(203, 24);
            this.textBoxNama.TabIndex = 1;
            // 
            // textBoxKode
            // 
            this.textBoxKode.BackColor = System.Drawing.Color.White;
            this.textBoxKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKode.ForeColor = System.Drawing.Color.Black;
            this.textBoxKode.Location = new System.Drawing.Point(196, 23);
            this.textBoxKode.MaxLength = 3;
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(57, 24);
            this.textBoxKode.TabIndex = 0;
            this.textBoxKode.TextChanged += new System.EventHandler(this.TextBoxKode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id Barang :";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonKeluar.FlatAppearance.BorderSize = 0;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(558, 539);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(103, 32);
            this.buttonKeluar.TabIndex = 14;
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
            this.buttonKosongi.Location = new System.Drawing.Point(408, 539);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(103, 32);
            this.buttonKosongi.TabIndex = 13;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.ButtonKosongi_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "UBAH BARANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(81, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Harga Jual :";
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BackColor = System.Drawing.Color.White;
            this.textBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBarcode.Enabled = false;
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.ForeColor = System.Drawing.Color.Black;
            this.textBoxBarcode.Location = new System.Drawing.Point(196, 88);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(203, 24);
            this.textBoxBarcode.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Barcode :";
            // 
            // buttonUbah
            // 
            this.buttonUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonUbah.FlatAppearance.BorderSize = 0;
            this.buttonUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUbah.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.ForeColor = System.Drawing.Color.White;
            this.buttonUbah.Location = new System.Drawing.Point(299, 539);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(103, 32);
            this.buttonUbah.TabIndex = 12;
            this.buttonUbah.Text = "UBAH";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.ButtonUbah_Click);
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.BackColor = System.Drawing.Color.White;
            this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategori.Enabled = false;
            this.comboBoxKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKategori.ForeColor = System.Drawing.Color.Black;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(196, 191);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(199, 26);
            this.comboBoxKategori.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(97, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Kategori :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(103, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gambar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(114, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Merek :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang :";
            // 
            // panelBarang
            // 
            this.panelBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(52)))));
            this.panelBarang.Controls.Add(this.labelJum);
            this.panelBarang.Controls.Add(this.label9);
            this.panelBarang.Controls.Add(this.label6);
            this.panelBarang.Controls.Add(this.textBoxDeskripsi);
            this.panelBarang.Controls.Add(this.textBoxHargaJual);
            this.panelBarang.Controls.Add(this.labelGambar);
            this.panelBarang.Controls.Add(this.buttonGambar);
            this.panelBarang.Controls.Add(this.comboBoxMerek);
            this.panelBarang.Controls.Add(this.comboBoxKategori);
            this.panelBarang.Controls.Add(this.label12);
            this.panelBarang.Controls.Add(this.label5);
            this.panelBarang.Controls.Add(this.label8);
            this.panelBarang.Controls.Add(this.label7);
            this.panelBarang.Controls.Add(this.textBoxBarcode);
            this.panelBarang.Controls.Add(this.label4);
            this.panelBarang.Controls.Add(this.textBoxNama);
            this.panelBarang.Controls.Add(this.textBoxKode);
            this.panelBarang.Controls.Add(this.label2);
            this.panelBarang.Controls.Add(this.label3);
            this.panelBarang.Location = new System.Drawing.Point(19, 54);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Size = new System.Drawing.Size(642, 475);
            this.panelBarang.TabIndex = 11;
            // 
            // labelJum
            // 
            this.labelJum.ForeColor = System.Drawing.Color.White;
            this.labelJum.Location = new System.Drawing.Point(491, 455);
            this.labelJum.Name = "labelJum";
            this.labelJum.Size = new System.Drawing.Size(73, 13);
            this.labelJum.TabIndex = 31;
            this.labelJum.Text = "0";
            this.labelJum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(562, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "/ 1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(91, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Deskripsi :";
            // 
            // textBoxDeskripsi
            // 
            this.textBoxDeskripsi.AcceptsTab = true;
            this.textBoxDeskripsi.BackColor = System.Drawing.Color.White;
            this.textBoxDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDeskripsi.Enabled = false;
            this.textBoxDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.textBoxDeskripsi.Location = new System.Drawing.Point(196, 262);
            this.textBoxDeskripsi.MaxLength = 1000;
            this.textBoxDeskripsi.Multiline = true;
            this.textBoxDeskripsi.Name = "textBoxDeskripsi";
            this.textBoxDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDeskripsi.Size = new System.Drawing.Size(422, 189);
            this.textBoxDeskripsi.TabIndex = 28;
            this.textBoxDeskripsi.TextChanged += new System.EventHandler(this.TextBoxDeskripsi_TextChanged);
            // 
            // textBoxHargaJual
            // 
            this.textBoxHargaJual.BackColor = System.Drawing.Color.White;
            this.textBoxHargaJual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHargaJual.Enabled = false;
            this.textBoxHargaJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHargaJual.ForeColor = System.Drawing.Color.Black;
            this.textBoxHargaJual.Location = new System.Drawing.Point(196, 122);
            this.textBoxHargaJual.Name = "textBoxHargaJual";
            this.textBoxHargaJual.Size = new System.Drawing.Size(115, 24);
            this.textBoxHargaJual.TabIndex = 27;
            this.textBoxHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormUbahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(675, 583);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.panelBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUbahBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ubah Barang";
            this.Load += new System.EventHandler(this.FormUbahBarang_Load);
            this.panelBarang.ResumeLayout(false);
            this.panelBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelGambar;
        private System.Windows.Forms.Button buttonGambar;
        private System.Windows.Forms.ComboBox comboBoxMerek;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBarang;
        private System.Windows.Forms.TextBox textBoxHargaJual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDeskripsi;
        private System.Windows.Forms.Label labelJum;
        private System.Windows.Forms.Label label9;
    }
}