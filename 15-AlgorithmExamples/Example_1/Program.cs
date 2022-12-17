using System;
using System.Collections.Generic;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.Write("Lütfen pozitif bir sayi giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Lütfen {n} adet pozitif sayı giriniz:");
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                numbers.Add(k);
            }
            List<int> evenNumbers = new List<int>();
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenNumbers.Add(item);
                }
            }
            Console.WriteLine("2'ye bölüne bilen sayılar: ");
            foreach (var item in evenNumbers)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
