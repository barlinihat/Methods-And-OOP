using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " adlı kullanıcı eklenmiştir. " );
            musteri.Id = 1;
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + " adlı kullanıcı silinmiştir." );
        }

        public void Listeleme(Musteri[] musteriler)
        {
            foreach(var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.Id);
                Console.WriteLine("Musteri Adı: " + musteri.Ad);
                Console.WriteLine("Musteri Soyadı: " + musteri.Soyad);
                Console.WriteLine("Musteri hesap no: " + musteri.MusteriHesapNo);
            }
        }
    }


}
