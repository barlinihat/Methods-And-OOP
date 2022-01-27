using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Nihat");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);

            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();

            Ogrenci.Add(10, "Ahmet");
            Ogrenci.Add(11, "Mehmet");

            Console.WriteLine(Ogrenci[10]);
        }
    }

    //class MyList<T> // Generic class
    //{
    //    T[] _array;
    //    public MyList()
    //    {
    //        _array = new T[0];
    //    }

    //    public void Add(T item)
    //    {

    //    }



    //    public int Count
    //    {
    //        get { return _array.Length; }
    //    }

}
