namespace KatmanliMimari
{
    partial class alim_iade_gosterim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alim_iade_gosterim));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arama_btn = new System.Windows.Forms.Button();
            this.giris_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ozellik_c = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liste_d = new System.Windows.Forms.DataGridView();
            this.yukleme_btn = new System.Windows.Forms.Button();
            this.anasayfa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arama_btn);
            this.groupBox1.Controls.Add(this.giris_t);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ozellik_c);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(168, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet-İade edilen kitap";
            // 
            // arama_btn
            // 
            this.arama_btn.Location = new System.Drawing.Point(179, 106);
            this.arama_btn.Name = "arama_btn";
            this.arama_btn.Size = new System.Drawing.Size(206, 25);
            this.arama_btn.TabIndex = 4;
            this.arama_btn.Text = "Arama Yap";
            this.arama_btn.UseVisualStyleBackColor = true;
            this.arama_btn.Click += new System.EventHandler(this.arama_btn_Click);
            // 
            // giris_t
            // 
            this.giris_t.Location = new System.Drawing.Point(162, 66);
            this.giris_t.Name = "giris_t";
            this.giris_t.Size = new System.Drawing.Size(303, 20);
            this.giris_t.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Bilgisi:";
            // 
            // ozellik_c
            // 
            this.ozellik_c.FormattingEnabled = true;
            this.ozellik_c.Items.AddRange(new object[] {
            "kitapadi",
            "yazar",
            "tur"});
            this.ozellik_c.Location = new System.Drawing.Point(162, 24);
            this.ozellik_c.Name = "ozellik_c";
            this.ozellik_c.Size = new System.Drawing.Size(303, 21);
            this.ozellik_c.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitabı şuna göre ara:";
            // 
            // liste_d
            // 
            this.liste_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_d.Location = new System.Drawing.Point(89, 359);
            this.liste_d.Name = "liste_d";
            this.liste_d.Size = new System.Drawing.Size(745, 383);
            this.liste_d.TabIndex = 1;
            // 
            // yukleme_btn
            // 
            this.yukleme_btn.Location = new System.Drawing.Point(287, 286);
            this.yukleme_btn.Name = "yukleme_btn";
            this.yukleme_btn.Size = new System.Drawing.Size(325, 47);
            this.yukleme_btn.TabIndex = 2;
            this.yukleme_btn.Text = "Tüm Kayıtları Göster";
            this.yukleme_btn.UseVisualStyleBackColor = true;
            this.yukleme_btn.Click += new System.EventHandler(this.cagirma_btn_Click);
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.SystemColors.Highlight;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.Location = new System.Drawing.Point(13, 13);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(113, 30);
            this.anasayfa.TabIndex = 6;
            this.anasayfa.Text = "ANASAYFA";
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // alim_iade_gosterim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 798);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.yukleme_btn);
            this.Controls.Add(this.liste_d);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "alim_iade_gosterim";
            this.Text = "Kitap Emanet - İade Listesi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox giris_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ozellik_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView liste_d;
        private System.Windows.Forms.Button yukleme_btn;
        private System.Windows.Forms.Button arama_btn;
        private System.Windows.Forms.Button anasayfa;
    }
}