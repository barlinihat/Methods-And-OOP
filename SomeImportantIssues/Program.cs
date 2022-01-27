using System;

namespace SomeImportantIssues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, bolme;
            try // hata olmadığında buradadır
            {
                Console.WriteLine("a: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("b: ");
                b = int.Parse(Console.ReadLine());
                bolme = a / b;
                Console.WriteLine("bolme:" + bolme);
            }
            catch (Exception) // hata olduğunda girer. burada fırlatılan hata iş kesicidir. burada "when" ile hata mesajına şart konulabilir. "return" kullanarak çalışmaı devam ettirebiiliriz.
            {

                throw;
            }

            finally // try - catch blokları çalışsa da çalışmasada "finally" bloğu her türlü çalışır.
            {

            }

        }
    }
}
