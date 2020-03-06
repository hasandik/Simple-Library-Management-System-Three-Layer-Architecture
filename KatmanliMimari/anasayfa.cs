using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimari
{
    public partial class anasayfa : Form
    {
        //butonlar ile ilgili sayfalara yönlendirmeler yapılıyor.

        public anasayfa()
        {
            InitializeComponent();
        }

        private void ogrenci_islem_Click(object sender, EventArgs e)
        {
            ogrenci_islemleri ogrislem = new ogrenci_islemleri();
            ogrislem.Show();
            this.Hide();
        }

        private void kitap_islemleri_Click(object sender, EventArgs e)
        {
            kitap_islemleri ktpislem = new kitap_islemleri();
            ktpislem.Show();
            this.Hide();
        }

        private void alım_iade_Click(object sender, EventArgs e)
        {
            iade_ve_alim kai = new iade_ve_alim();
            kai.Show();
            this.Hide();
        }

        private void ogr_kitap_listesi_Click(object sender, EventArgs e)
        {
            alim_iade_gosterim kitp_list = new alim_iade_gosterim();
            kitp_list.Show();
            this.Hide();
        }

        private void kitap_takip_Click(object sender, EventArgs e)
        {
            ogrenci_alim_iade_gosterim ogr_list = new ogrenci_alim_iade_gosterim();
            ogr_list.Show();
            this.Hide();
        }

        private void grafik_b_Click(object sender, EventArgs e)
        {
            kitap_grafik ktp_grfik = new kitap_grafik();
            ktp_grfik.Show();
            this.Hide();
        }
    }
}
