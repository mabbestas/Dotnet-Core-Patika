using System;

namespace Example_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string input = Console.ReadLine();

            int counter = 1;
            foreach(char item in input)
            {
                if(item == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine($"Cümledeki toplam kelime sayısı: {counter}");

            int counterChar = 0;
            foreach(char item in input)
            {
                if(item != ' ' && item != '.')
                {
                    counterChar++;
                }
            }
            Console.WriteLine($"Cümledeki toplam harf sayısı: {counterChar}");

            Console.ReadLine();
        }
    }
}
