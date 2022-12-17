using System;
using System.Collections.Generic;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.Write("Lütfen pozitif bir sayı olacak şekilde ilk sayıyı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen pozitif bir sayı olacak şekilde ikinci sayıyı giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();
            Console.WriteLine($"Lütfen {n} adet pozitif tam sayı giriniz:");
            for (int i = 0; i < n; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);
            }

            List<int> divisibleNumbers = new List<int>();
            foreach (var item in numbers)
            {
                if (item % m == 0)
                {
                    divisibleNumbers.Add(item);
                }
            }

            Console.WriteLine($"{m}'ye bölünebilen sayılar:");
            foreach (var item in divisibleNumbers)
                Console.WriteLine(item);


            Console.ReadLine();
        }
    }
}
