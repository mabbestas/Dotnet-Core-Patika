using System;
using System.Collections.Generic;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Lütfen pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Lütfen {n} adet kelime yazınız:");
            List<string> words = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string k = Console.ReadLine();
                words.Add(k);
            }
            words.Reverse();
            Console.WriteLine("Girmiş olduğunuz kelimelerin sondan başa sıralanışı şu şekildedir:");
            foreach(var item in words)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
