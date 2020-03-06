using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ogrenciler
    {
        //veritabanındaki öğrenciler tablosundaki sütunları tanımlıyoruz.
        public int ogrenciid { get; set; }
        public string isim { get; set; }
        public string numara { get; set; }
        public string bolum { get; set; }
    }
}
