using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BL;

namespace KatmanliMimari
{
    public partial class ogrenci_alim_iade_gosterim : Form
    {
        public ogrenci_alim_iade_gosterim()
        {
            InitializeComponent();
        }

        iade_alim_islemleri iade_ve_alimlar = new iade_alim_islemleri();
        private void yukleme_btn_Click(object sender, EventArgs e)
        {
            //öğrencilerin daha önce yaptığı kitap alım ve iadeleri datagridview üzerinde gösterilir.
            List<almaverme> ktp1 = iade_ve_alimlar.iade_alim_yukle();
            liste_d.DataSource = ktp1;
            MessageBox.Show("Kayıt gösterme başarılı!");
        }

        private void giris_t_Click(object sender, EventArgs e)
        {
            //textbox üzerine tıklanınca text'ler silinir.
            giris_t.Text = "";
        }

        private void arama_btn_Click(object sender, EventArgs e)
        {
            //BL'daki iade_alim_islemleri sınıfından ogrenci_emanet_iade_listele fanksiyonu çalıştırılıp arama textbox içindeki veri tablodan çağırılıp datagridview üzerinden
            //gösterilir.
            List<almaverme> arama = iade_ve_alimlar.ogrenci_emanet_iade_listele(giris_t.Text);
            liste_d.DataSource = arama;
            MessageBox.Show("Arama Başarılı!");
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            anasayfa anasyf = new anasayfa();
            anasyf.Show();
            this.Hide();
        }
    }
}
