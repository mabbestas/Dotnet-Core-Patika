using System;
using System.Collections;
using System.Collections.Generic;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Burak");
            list.Add(2);
            list.Add(true);
            list.Add('A');

            Console.WriteLine(list[1]);

            foreach(var item in list)
                Console.WriteLine(item);

            // AddRange
            Console.WriteLine("*****  Add Range *******");
            string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            list.AddRange(renkler);
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            list.AddRange(sayilar);

            foreach (var item in list)
                Console.WriteLine(item);

            // Sort
            //list.Sort();
            //foreach (var item in list)
            //    Console.WriteLine(item);

            // Binary Search  => ilgili item in indexini getirir.
            Console.WriteLine(list.BinarySearch(9));

            // Reverse
            list.Reverse();
            foreach (var item in list)
                Console.WriteLine(item);

            // Clear
            list.Clear();
        }
    }
}
