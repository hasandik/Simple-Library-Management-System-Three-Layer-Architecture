using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.OleDb;
using Entity;

namespace BL
{
    public class iade_alim_islemleri
    {

        DAL.DAL dl = new DAL.DAL();
        public List<almaverme> iade_alim_yukle()
        {
            OleDbDataReader dr = dl.DRVeriCek("Select * from almaverme", CommandType.Text); //DAL katmanı yardımıyla almaverme tablosundaki verilerimizi çekiyoruz.
            if (dr.HasRows)
            {
                List<almaverme> islem_kayit = new List<almaverme>();
                while (dr.Read())
                {
                    //tablodaki verileri çekip yukle listesine ekliyoruz. 
                    almaverme yukle = new almaverme { kitapid = int.Parse(dr["kitapid"].ToString()), ogrenciid = int.Parse(dr["ogrenciid"].ToString()), emanettarihi = dr["emanettarihi"].ToString(), iadetarihi = dr["iadetarihi"].ToString(), iadeedilentarih = dr["iadeedilentarih"].ToString(), borc = dr["borc"].ToString(), islemturu = dr["islemturu"].ToString() };

                    islem_kayit.Add(yukle);
                }
                return islem_kayit; //listeyi geri yolluyoruz.
            }

            return null;
        }

        DAL.DAL dl1 = new DAL.DAL();
        public int tablo_iade_duzenleme(int kitapid, int ogrenciid, string islemturu)
        {
            //almaverme tablosundaki verileri güncellemek için sorgumuzu gönderiyoruz.
            int Sonuc = dl1.EkleSilGuncelle("update almaverme set islemturu='" + islemturu + "' where ogrenciid=" + ogrenciid + " and kitapid = " + kitapid + "", System.Data.CommandType.Text);

            return Sonuc;   
        }


        public List<almaverme> kayit_listeleme1(int numara)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dr = dl.DRVeriCek("Select * from almaverme where ogrenciid in (select ogrenciid from ogrenciler where numara ='" + numara + "') ", CommandType.Text);
            if (dr.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<almaverme> islem_kayit = new List<almaverme>();
                while (dr.Read())
                {



                    almaverme kaydet = new almaverme { kitapid = int.Parse(dr["kitapid"].ToString()), ogrenciid = int.Parse(dr["ogrenciid"].ToString()), emanettarihi = dr["emanettarihi"].ToString(), iadetarihi = dr["iadetarihi"].ToString(), iadeedilentarih = dr["iadeedilentarih"].ToString(), borc = dr["borc"].ToString(), islemturu = dr["islemturu"].ToString() };

                    islem_kayit.Add(kaydet);
                }
                return islem_kayit;
            }

            return null;
        }

        DAL.DAL dl2 = new DAL.DAL();
        public int emanet_islemi(int kitapid, int ogrenciid, DateTime emanettarihi, DateTime iadetarihi, string islemturu)
        {
            //emanet vermek için almaverme tablosuna gerekli verileri yolluyoruz.
            int Sonuc = dl2.EkleSilGuncelle("insert into almaverme (kitapid,ogrenciid,emanettarihi,iadetarihi,islemturu) values (" + kitapid + "," + ogrenciid + ",'" + emanettarihi + "','" + iadetarihi + "','" + islemturu + "')", System.Data.CommandType.Text);
            return Sonuc;
        }

        DAL.DAL dl3 = new DAL.DAL();
        public List<almaverme> ogrenci_emanet_iade_listele(string deger)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dr = dl3.DRVeriCek("Select * from almaverme where ogrenciid in (Select ogrenciid from ogrenciler where numara='" + deger + "')", CommandType.Text);
            if (dr.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<almaverme> islem_kayit = new List<almaverme>();
                while (dr.Read())
                {
                    almaverme kayit_etme = new almaverme { kitapid = int.Parse(dr["kitapid"].ToString()), ogrenciid = int.Parse(dr["ogrenciid"].ToString()), emanettarihi = dr["emanettarihi"].ToString(), iadetarihi = dr["iadetarihi"].ToString(), iadeedilentarih = dr["iadeedilentarih"].ToString(), borc = dr["borc"].ToString(), islemturu = dr["islemturu"].ToString() };

                    islem_kayit.Add(kayit_etme);
                }
                return islem_kayit;
            }

            return null;
        }


        DAL.DAL dl4 = new DAL.DAL();
        public List<almaverme> kayit_listeleme2(string deger, string konum)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
            OleDbDataReader dr = dl4.DRVeriCek("Select * from almaverme where kitapid in (Select kitapid from kitaplar where " + konum + " ='" + deger + "')", CommandType.Text);
            if (dr.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<almaverme> islem_kayit = new List<almaverme>();
                while (dr.Read())
                {
                    almaverme kayit_etme = new almaverme { kitapid = int.Parse(dr["kitapid"].ToString()), ogrenciid = int.Parse(dr["ogrenciid"].ToString()), emanettarihi = dr["emanettarihi"].ToString(), iadetarihi = dr["iadetarihi"].ToString(), iadeedilentarih = dr["iadeedilentarih"].ToString(), borc = dr["borc"].ToString(), islemturu = dr["islemturu"].ToString() };

                    islem_kayit.Add(kayit_etme);
                }
                return islem_kayit;
            }

            return null;
        }

        
    }
}
