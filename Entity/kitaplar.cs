using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class kitaplar
    {
        //veritabanındaki kitaplar tablosundaki sütun verilerini tanımlıyoruz.
        public int kitapid { get; set; }
        public string kitapadi { get; set; }
        public string yazar { get; set; }
        public string kitapnumara { get; set; }
        public string tur { get; set; }
    }
}
