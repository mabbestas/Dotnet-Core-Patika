using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            // int[] numbers = new int[20];
            for (int i = 0; i < 20; i++)
            {
                bool k = Int32.TryParse(Console.ReadLine(), out int number);
                if (k)
                {
                    numbers.Add(number);
                }
                else
                {
                    i--;
                }
            }
            numbers.Sort();
            List<int> minGroup = new List<int>();
            List<int> maxGroup = new List<int>();
            int avgMax = 0;
            int avgMin = 0;
            foreach(var item in numbers)
            {
                if(numbers.IndexOf(item) < 3)
                {
                    minGroup.Add(item);
                    avgMin += item;
                }
                else if(numbers.IndexOf(item) > 16)
                {
                    maxGroup.Add(item);
                    avgMax += item;
                }
            }
            Console.WriteLine($"En Küçük 3 Sayının Ortalaması: {avgMin/3}");
            Console.WriteLine($"En Büyük 3 Sayının Ortalaması: {avgMax/3}");
            Console.WriteLine($"Ortalamalar Toplamı : {(avgMin / 3)+(avgMax/3)}");
        }
    }
}
