using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam);

            // 'a' dan 'b' ye kadar tüm harfleri console a yazdır.
            char c = 'a';
            while (c < 'z')
            {
                Console.WriteLine(c);
                c++;
            }


            // Foreach

            string[] arabalar = { "BMV", "Ford", "Toyota", "Nissan" };

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
