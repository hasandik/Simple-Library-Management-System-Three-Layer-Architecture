using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entity;

namespace KatmanliMimari
{
    public partial class ogrenci_islemleri : Form
    {
        public ogrenci_islemleri()
        {
            InitializeComponent();
        }

        ogrenci_islem o_islm = new ogrenci_islem();
        private void ekle_b_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_ekle fonksiyonu çalıştırılarak öğrenci ekleme işlemi yapılır.
            int sonuc = o_islm.ogr_ekle(isim_t.Text, numara_t.Text, bolum_t.Text);
            MessageBox.Show("Öğrenci Başarıyla Eklendi.");
        }

        private void guncelle_b_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_guncelle fonksiyonu çalıştırılarak öğrenci güncelleme işlemi yapılır.
            try
            {
                int sonuc = o_islm.ogr_guncelle(int.Parse(id_t.Text), isim_t.Text, numara_t.Text, bolum_t.Text);
                MessageBox.Show("Öğrenci Başarıyla Güncellendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru girdiğinizden emin olun!");
            }
        }

        ogrenci_islem o_sill = new ogrenci_islem();
        private void sil_b_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_sil fonksiyonu çalıştırılarak öğrenci silme işlemi yapılır.
            try
            {
                o_sill.ogr_sil(int.Parse(id_t.Text));
                MessageBox.Show("Öğrenci Başarıyla Silindi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen girilen değerleri kontrol ediniz!");
            }
        }

        ogrenci_islem o_list = new ogrenci_islem();

        void ogr_gstr()
        {
            //ogrencilerrenciler listesindeki verileri ogr_goster fonkiyonu ile datagridview'e çağırır. 
            List<ogrenciler> ogrenciler1 = o_list.ogrenci_goster();
            ogrenci_listesi_d.DataSource = ogrenciler1;
        }

        private void tum_b_Click(object sender, EventArgs e)
        {
            //ogr_gstr fonksiyonu ile öğrenci listelemesi yapılır.
            ogr_gstr();
            MessageBox.Show("Öğrenciler Başarıyla Listelendi.");
        }

        private void ogrenci_listesi_d_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de tıklanan satırın bilgileri textbox'a aktarılır.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ogrenci_listesi_d.Rows[e.RowIndex];
                id_t.Text = row.Cells[0].Value.ToString();
                isim_t.Text = row.Cells[1].Value.ToString();
                numara_t.Text = row.Cells[2].Value.ToString();
                bolum_t.Text = row.Cells[3].Value.ToString();
            }
        }

        private void ogr_ara_b_Click(object sender, EventArgs e)
        {
            // arama textbox'ındaki metin ogrenciler tablosundan bulunarak listeleniyor.
            List<ogrenciler> ogrenciler1 = o_islm.ogrenci_goster(ogr_ara_t.Text);
            ogrenci_listesi_d.DataSource = ogrenciler1;
        }

        private void ogr_ara_t_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            ogr_ara_t.Text = "";
        }

        private void id_t_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            id_t.Text = "";
        }

        private void isim_t_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            isim_t.Text = "";
        }

        private void numara_t_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            numara_t.Text = "";
        }

        private void bolum_t_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            bolum_t.Text = "";
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu
            anasayfa anasyf = new anasayfa();
            anasyf.Show();
            this.Hide();
        }
    }
}
