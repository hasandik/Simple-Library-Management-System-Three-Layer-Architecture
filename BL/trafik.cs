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
    public class trafik
    {
        DAL.DAL dl = new DAL.DAL();
        public int listele()
        {
            //veritabanından kitap sayılarını bir sayaçta tutup geri döndürüyoruz.
            int sayac = 0;
            OleDbDataReader dr = dl.DRVeriCek("Select kitapid from kitaplar", CommandType.Text);
            if (dr.HasRows)
            {
                List<kitaplar> kitaplar = new List<kitaplar>();
                while (dr.Read())
                {
                    sayac++;
                }
                return sayac;
            }

            return 0;
        }

        DAL.DAL d2 = new DAL.DAL();
        public int alma()
        {
            //veritabanında işlem türü alım olan verilerin sayısını bir sayaçta tutup geri döndürüyoruz.
            int sayac = 0;
            OleDbDataReader dr = dl.DRVeriCek("Select * from almaverme where islemturu='" + "alım" + "'", CommandType.Text);
            if (dr.HasRows)
            {
                List<kitaplar> kitaplar = new List<kitaplar>();
                while (dr.Read())
                {
                    sayac++;
                }
                return sayac;
            }

            return 0;
        }
    }
}
