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
}
