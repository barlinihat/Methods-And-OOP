using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama="Sari Elma";

            Urun urun2 = new();
            urun2.Adi = "armut";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Kirimizi Armut";

            Urun[] urunler = new Urun[] {urun1,urun2};

            //type-safe - tip güvenli

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
