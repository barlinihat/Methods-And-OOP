using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> { "ass", "bss", "ssc", "dss" };
            isimler2.Add("jjj");
            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
