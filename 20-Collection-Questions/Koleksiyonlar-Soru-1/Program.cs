using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> asalSayilar = new List<int>();
            List<int> asalOlmayanSayilar = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                bool k = Int32.TryParse(Console.ReadLine(), out int number);
                if (k && number > 0)
                {
                    int count = 0;
                    for(int j = 1; j <= number; j++)
                    {
                        if(number % j == 0)
                        {
                            count++;
                        }
                    }
                    if(count == 2)
                    {
                        asalSayilar.Add(number);
                    }
                    else
                    {
                        asalOlmayanSayilar.Add(number);
                    }                   
                }
                else
                {
                    i--;
                }
            }
            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();
            asalSayilar.Sort();
            asalSayilar.Reverse();
            Console.WriteLine("Asal Sayılar:");
            int asalToplam = 0;
            int asalOlmayanToplam = 0;
            foreach(var item in asalSayilar)
            {
                asalToplam += item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Asal Sayılar Eleman Sayısı: {asalSayilar.Count}");
            Console.WriteLine($"Asal Sayılar Toplamı: {asalToplam}");

            foreach (var item in asalOlmayanSayilar)
            {
                asalOlmayanToplam += item;
                Console.WriteLine(item);
            }
            Console.WriteLine($"Asal Olmayan Sayılar Eleman Sayısı: {asalOlmayanSayilar.Count}");
            Console.WriteLine($"Asal Olmayan Sayılar Toplamı: {asalOlmayanToplam}");
        }
    }
}
