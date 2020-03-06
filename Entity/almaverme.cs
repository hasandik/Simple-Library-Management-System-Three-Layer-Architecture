using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class almaverme
    {
        //veritabanındaki almaverme tablosundaki sütunları tanımlıyoruz.
        public int kitapid { get; set; }
        public int ogrenciid { get; set; }
        public string emanettarihi { get; set; }
        public string iadetarihi { get; set; }
        public string iadeedilentarih { get; set; }
        public string borc { get; set; }
        public string islemturu { get; set; }
    }
}
