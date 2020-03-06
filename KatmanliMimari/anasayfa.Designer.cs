namespace KatmanliMimari
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.kitap_takip = new System.Windows.Forms.Button();
            this.ogr_kitap_listesi = new System.Windows.Forms.Button();
            this.alım_iade = new System.Windows.Forms.Button();
            this.kitap_islemleri = new System.Windows.Forms.Button();
            this.ogrenci_islem = new System.Windows.Forms.Button();
            this.grafik_b = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitap_takip
            // 
            this.kitap_takip.Location = new System.Drawing.Point(473, 446);
            this.kitap_takip.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_takip.Name = "kitap_takip";
            this.kitap_takip.Size = new System.Drawing.Size(199, 98);
            this.kitap_takip.TabIndex = 10;
            this.kitap_takip.Text = "ÖĞRENCİ EMANET - İADE LİSTESİ";
            this.kitap_takip.UseVisualStyleBackColor = true;
            this.kitap_takip.Click += new System.EventHandler(this.kitap_takip_Click);
            // 
            // ogr_kitap_listesi
            // 
            this.ogr_kitap_listesi.Location = new System.Drawing.Point(163, 446);
            this.ogr_kitap_listesi.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_kitap_listesi.Name = "ogr_kitap_listesi";
            this.ogr_kitap_listesi.Size = new System.Drawing.Size(199, 98);
            this.ogr_kitap_listesi.TabIndex = 9;
            this.ogr_kitap_listesi.Text = "KİTAP EMANET - İADE LİSTESİ";
            this.ogr_kitap_listesi.UseVisualStyleBackColor = true;
            this.ogr_kitap_listesi.Click += new System.EventHandler(this.ogr_kitap_listesi_Click);
            // 
            // alım_iade
            // 
            this.alım_iade.Location = new System.Drawing.Point(781, 274);
            this.alım_iade.Margin = new System.Windows.Forms.Padding(2);
            this.alım_iade.Name = "alım_iade";
            this.alım_iade.Size = new System.Drawing.Size(199, 98);
            this.alım_iade.TabIndex = 8;
            this.alım_iade.Text = "KİTAP EMANET VE İADE İŞLEMLERİ";
            this.alım_iade.UseVisualStyleBackColor = true;
            this.alım_iade.Click += new System.EventHandler(this.alım_iade_Click);
            // 
            // kitap_islemleri
            // 
            this.kitap_islemleri.Location = new System.Drawing.Point(473, 274);
            this.kitap_islemleri.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_islemleri.Name = "kitap_islemleri";
            this.kitap_islemleri.Size = new System.Drawing.Size(199, 98);
            this.kitap_islemleri.TabIndex = 7;
            this.kitap_islemleri.Text = "KİTAP İŞLEMLERİ";
            this.kitap_islemleri.UseVisualStyleBackColor = true;
            this.kitap_islemleri.Click += new System.EventHandler(this.kitap_islemleri_Click);
            // 
            // ogrenci_islem
            // 
            this.ogrenci_islem.Location = new System.Drawing.Point(163, 274);
            this.ogrenci_islem.Margin = new System.Windows.Forms.Padding(2);
            this.ogrenci_islem.Name = "ogrenci_islem";
            this.ogrenci_islem.Size = new System.Drawing.Size(199, 98);
            this.ogrenci_islem.TabIndex = 6;
            this.ogrenci_islem.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.ogrenci_islem.UseVisualStyleBackColor = true;
            this.ogrenci_islem.Click += new System.EventHandler(this.ogrenci_islem_Click);
            // 
            // grafik_b
            // 
            this.grafik_b.Location = new System.Drawing.Point(781, 446);
            this.grafik_b.Margin = new System.Windows.Forms.Padding(2);
            this.grafik_b.Name = "grafik_b";
            this.grafik_b.Size = new System.Drawing.Size(199, 98);
            this.grafik_b.TabIndex = 11;
            this.grafik_b.Text = "GRAFİK";
            this.grafik_b.UseVisualStyleBackColor = true;
            this.grafik_b.Click += new System.EventHandler(this.grafik_b_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KatmanliMimari.Properties.Resources.mMLgN21;
            this.pictureBox1.Location = new System.Drawing.Point(163, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 199);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grafik_b);
            this.Controls.Add(this.kitap_takip);
            this.Controls.Add(this.ogr_kitap_listesi);
            this.Controls.Add(this.alım_iade);
            this.Controls.Add(this.kitap_islemleri);
            this.Controls.Add(this.ogrenci_islem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anasayfa";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kitap_takip;
        private System.Windows.Forms.Button ogr_kitap_listesi;
        private System.Windows.Forms.Button alım_iade;
        private System.Windows.Forms.Button kitap_islemleri;
        private System.Windows.Forms.Button ogrenci_islem;
        private System.Windows.Forms.Button grafik_b;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}