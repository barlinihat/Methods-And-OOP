using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            AdYas.Add("Amy", 25);
            AdYas.Add("Ali", 17);
            AdYas.Add("Birisi", 30);

            foreach (var item in AdYas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
