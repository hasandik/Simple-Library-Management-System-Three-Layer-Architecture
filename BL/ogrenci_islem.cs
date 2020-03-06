using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data;
using System.Data.OleDb;



namespace BL
{
    public class ogrenci_islem
    {
        DAL.DAL dl1 = new DAL.DAL();
        public List<ogrenciler> ogrenci_goster()
        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = dl1.DRVeriCek("SELECT * FROM ogrenciler", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<ogrenciler> ogrenciler1 = new List<ogrenciler>();
                while (dr.Read())
                {
                    ogrenciler ogrnci = new ogrenciler { ogrenciid = int.Parse(dr["ogrenciid"].ToString()),  isim = dr["isim"].ToString(), numara = dr["numara"].ToString(), bolum = dr["bolum"].ToString() };
                    ogrenciler1.Add(ogrnci);
                }
                return ogrenciler1;
            }

            return null;
        }

        DAL.DAL dl2 = new DAL.DAL();
        public List<ogrenciler> ogrenci_goster(string numara)
        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = dl2.DRVeriCek("SELECT * FROM ogrenciler WHERE numara='" + numara + "'", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<ogrenciler> ogrenciler1 = new List<ogrenciler>();
                while (dr.Read())
                {
                    ogrenciler ogrnci = new ogrenciler { ogrenciid = int.Parse(dr["ogrenciid"].ToString()), isim = dr["isim"].ToString(), numara = dr["numara"].ToString(), bolum = dr["bolum"].ToString() };
                    ogrenciler1.Add(ogrnci);
                }
                return ogrenciler1;
            }

            return null;
        }


        DAL.DAL dl3 = new DAL.DAL();
        public int ogr_ekle(string isim, string numara, string bolum)
        {
            //öğrenci eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl3.EkleSilGuncelle("INSERT into ogrenciler (isim,numara,bolum) VALUES ('" + isim + "','" + numara + "','" + bolum + "')", System.Data.CommandType.Text);
            return sonuc;
        }

        DAL.DAL dl4 = new DAL.DAL();
        public int ogr_guncelle(int ogrenciid, string isim, string numara, string bolum)
        {
            //öğrenci güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl4.EkleSilGuncelle("UPDATE ogrenciler SET isim='" + isim + "', numara='" + numara + "', bolum='" + bolum + "' WHERE ogrenciid=" + ogrenciid + "", System.Data.CommandType.Text);
            return sonuc;
        }

        DAL.DAL dl5 = new DAL.DAL();

        public int ogr_sil(int ogrenciid)
        {
            //öğrenciyi silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = dl5.EkleSilGuncelle("DELETE from ogrenciler where ogrenciid =" + ogrenciid + "", System.Data.CommandType.Text);
            return sonuc;
        }


    }
}
