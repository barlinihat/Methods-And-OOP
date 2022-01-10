using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişken türleri:  "int", "long", "float", "double", "decimal", "char", "bool", "byte", "short", "struct", "enum"
            // Referans türleri:  "string", "object", "class", "interface", "array", "delegate", "pointer"
            // String veri türünde istisna vardır. "ref" ve "auto" anahtar kelimeleri ile string veri tipi değişken tür gibi kullanılabilir.
            //ref, ilgili değişkeni referans tip olarak (heap'teki adresini) gönderir. 
            //out ile ref arasındaki tek fark, ref'te ilk değer olması gerekirken out ta böyle bir zorunluluk yoktur. 

            Console.WriteLine("Hello World!");
        }
    }
}
