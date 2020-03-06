namespace KatmanliMimari
{
    partial class ogrenci_islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenci_islemleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ogr_ara_b = new System.Windows.Forms.Button();
            this.ogr_ara_t = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id_t = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bolum_t = new System.Windows.Forms.TextBox();
            this.numara_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isim_t = new System.Windows.Forms.TextBox();
            this.sil_b = new System.Windows.Forms.Button();
            this.guncelle_b = new System.Windows.Forms.Button();
            this.ekle_b = new System.Windows.Forms.Button();
            this.tum_b = new System.Windows.Forms.Button();
            this.ogrenci_listesi_d = new System.Windows.Forms.DataGridView();
            this.anasayfa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_listesi_d)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ogr_ara_b);
            this.groupBox1.Controls.Add(this.ogr_ara_t);
            this.groupBox1.Location = new System.Drawing.Point(38, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(164, 142);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ara";
            // 
            // ogr_ara_b
            // 
            this.ogr_ara_b.Location = new System.Drawing.Point(10, 75);
            this.ogr_ara_b.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_ara_b.Name = "ogr_ara_b";
            this.ogr_ara_b.Size = new System.Drawing.Size(143, 31);
            this.ogr_ara_b.TabIndex = 1;
            this.ogr_ara_b.Text = "Öğrenci Ara";
            this.ogr_ara_b.UseVisualStyleBackColor = true;
            this.ogr_ara_b.Click += new System.EventHandler(this.ogr_ara_b_Click);
            // 
            // ogr_ara_t
            // 
            this.ogr_ara_t.Location = new System.Drawing.Point(10, 39);
            this.ogr_ara_t.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_ara_t.Name = "ogr_ara_t";
            this.ogr_ara_t.Size = new System.Drawing.Size(144, 20);
            this.ogr_ara_t.TabIndex = 0;
            this.ogr_ara_t.Text = "Öğrenci Numarası Giriniz";
            this.ogr_ara_t.Click += new System.EventHandler(this.ogr_ara_t_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.id_t);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bolum_t);
            this.groupBox2.Controls.Add(this.numara_t);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.isim_t);
            this.groupBox2.Location = new System.Drawing.Point(251, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(452, 142);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // id_t
            // 
            this.id_t.Location = new System.Drawing.Point(74, 26);
            this.id_t.Margin = new System.Windows.Forms.Padding(2);
            this.id_t.Name = "id_t";
            this.id_t.Size = new System.Drawing.Size(350, 20);
            this.id_t.TabIndex = 7;
            this.id_t.Text = "Öğrenci ID";
            this.id_t.Click += new System.EventHandler(this.id_t_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bölüm:";
            // 
            // bolum_t
            // 
            this.bolum_t.Location = new System.Drawing.Point(74, 111);
            this.bolum_t.Margin = new System.Windows.Forms.Padding(2);
            this.bolum_t.Name = "bolum_t";
            this.bolum_t.Size = new System.Drawing.Size(350, 20);
            this.bolum_t.TabIndex = 4;
            this.bolum_t.Text = "Öğrencinin Okuduğu Bölüm";
            this.bolum_t.Click += new System.EventHandler(this.bolum_t_Click);
            // 
            // numara_t
            // 
            this.numara_t.Location = new System.Drawing.Point(74, 83);
            this.numara_t.Margin = new System.Windows.Forms.Padding(2);
            this.numara_t.Name = "numara_t";
            this.numara_t.Size = new System.Drawing.Size(350, 20);
            this.numara_t.TabIndex = 3;
            this.numara_t.Text = "Öğrenci Numarası";
            this.numara_t.Click += new System.EventHandler(this.numara_t_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim:";
            // 
            // isim_t
            // 
            this.isim_t.Location = new System.Drawing.Point(74, 53);
            this.isim_t.Margin = new System.Windows.Forms.Padding(2);
            this.isim_t.Name = "isim_t";
            this.isim_t.Size = new System.Drawing.Size(350, 20);
            this.isim_t.TabIndex = 0;
            this.isim_t.Text = "Ad Soyad";
            this.isim_t.Click += new System.EventHandler(this.isim_t_Click);
            // 
            // sil_b
            // 
            this.sil_b.Location = new System.Drawing.Point(733, 160);
            this.sil_b.Margin = new System.Windows.Forms.Padding(2);
            this.sil_b.Name = "sil_b";
            this.sil_b.Size = new System.Drawing.Size(218, 43);
            this.sil_b.TabIndex = 17;
            this.sil_b.Text = "SİL";
            this.sil_b.UseVisualStyleBackColor = true;
            this.sil_b.Click += new System.EventHandler(this.sil_b_Click);
            // 
            // guncelle_b
            // 
            this.guncelle_b.Location = new System.Drawing.Point(733, 109);
            this.guncelle_b.Margin = new System.Windows.Forms.Padding(2);
            this.guncelle_b.Name = "guncelle_b";
            this.guncelle_b.Size = new System.Drawing.Size(218, 43);
            this.guncelle_b.TabIndex = 16;
            this.guncelle_b.Text = "GÜNCELLE";
            this.guncelle_b.UseVisualStyleBackColor = true;
            this.guncelle_b.Click += new System.EventHandler(this.guncelle_b_Click);
            // 
            // ekle_b
            // 
            this.ekle_b.Location = new System.Drawing.Point(733, 64);
            this.ekle_b.Margin = new System.Windows.Forms.Padding(2);
            this.ekle_b.Name = "ekle_b";
            this.ekle_b.Size = new System.Drawing.Size(218, 43);
            this.ekle_b.TabIndex = 15;
            this.ekle_b.Text = "EKLE";
            this.ekle_b.UseVisualStyleBackColor = true;
            this.ekle_b.Click += new System.EventHandler(this.ekle_b_Click);
            // 
            // tum_b
            // 
            this.tum_b.Location = new System.Drawing.Point(387, 253);
            this.tum_b.Margin = new System.Windows.Forms.Padding(2);
            this.tum_b.Name = "tum_b";
            this.tum_b.Size = new System.Drawing.Size(218, 43);
            this.tum_b.TabIndex = 18;
            this.tum_b.Text = "TÜM KAYITLARI GÖSTER";
            this.tum_b.UseVisualStyleBackColor = true;
            this.tum_b.Click += new System.EventHandler(this.tum_b_Click);
            // 
            // ogrenci_listesi_d
            // 
            this.ogrenci_listesi_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenci_listesi_d.Location = new System.Drawing.Point(38, 324);
            this.ogrenci_listesi_d.Margin = new System.Windows.Forms.Padding(2);
            this.ogrenci_listesi_d.Name = "ogrenci_listesi_d";
            this.ogrenci_listesi_d.RowTemplate.Height = 24;
            this.ogrenci_listesi_d.Size = new System.Drawing.Size(913, 410);
            this.ogrenci_listesi_d.TabIndex = 19;
            this.ogrenci_listesi_d.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrenci_listesi_d_CellContentClick);
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.SystemColors.Highlight;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.Location = new System.Drawing.Point(12, 7);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(113, 30);
            this.anasayfa.TabIndex = 21;
            this.anasayfa.Text = "ANASAYFA";
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(981, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 41);
            this.label5.TabIndex = 22;
            this.label5.Text = "Öğrenci Eklemek İçin Sadece isim, numara ve bölüm giriniz ve ekle butonuna basını" +
    "z.";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(981, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 43);
            this.label6.TabIndex = 23;
            this.label6.Text = "Güncellenecek Öğrencinin ID\'sini yazınız ve yeni bilgilerini giriniz ve Güncelle " +
    "butonuna basınız.";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(981, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "Silmek istediğiniz öğrencinin ID\'sini giriniz ve Sil butonuna basınız.";
            // 
            // ogrenci_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 863);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.ogrenci_listesi_d);
            this.Controls.Add(this.tum_b);
            this.Controls.Add(this.sil_b);
            this.Controls.Add(this.guncelle_b);
            this.Controls.Add(this.ekle_b);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ogrenci_islemleri";
            this.Text = "Öğrenci İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_listesi_d)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ogr_ara_b;
        private System.Windows.Forms.TextBox ogr_ara_t;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox id_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bolum_t;
        private System.Windows.Forms.TextBox numara_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isim_t;
        private System.Windows.Forms.Button sil_b;
        private System.Windows.Forms.Button guncelle_b;
        private System.Windows.Forms.Button ekle_b;
        private System.Windows.Forms.Button tum_b;
        private System.Windows.Forms.DataGridView ogrenci_listesi_d;
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}