using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // base sınıf yani alt sınıf, referans tutucudur.
    // inheritance : miras
    // parametre olarak sınıf göndermek polymorphisim (çok biçimlilik)' tir.
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
