using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace DAL
{
    class Baglanti
    {
        //veritabanı bağlantımızı kontrol açmak için bu yapıyı kullanıyoruz.
        OleDbConnection baglanti;
        public OleDbConnection BaglantiKablosu
        {
            get {
                if (baglanti != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti; 
                }
                else
                {
                    baglanti = new OleDbConnection(Provider());
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti; 
                }

            }
        
        }

        //App.config'den veritabanı adresimizi almak için bir bağlantı cümlesi oluşturuyoruz.
        private string Provider() {

            return ConfigurationManager.AppSettings["BaglantiCumlesi"];
        }


    }
}
