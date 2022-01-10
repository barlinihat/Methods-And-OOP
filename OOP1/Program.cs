using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "kalem", UnitPrice = 35 };

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

           // Değişken türleri:  "int", "long", "float", "double", "decimal", "char", "bool", "byte", "short", "struct", "enum"
           // Referans türleri:  "string", "object", "class", "interface", "array", "delegate", "pointer"
           // String veri türünde istisna vardır. "ref" ve "auto" anahtar kelimeleri ile string veri tipi değişken tür gibi kullanılabilir.
           //ref, ilgili değişkeni referans tip olarak (heap'teki adresini) gönderir. 
           //out ile ref arasındaki tek fark, ref'te ilk değer olması gerekirken out ta böyle bir zorunluluk yoktur. 
        }
    }
}
