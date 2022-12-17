using System;

namespace IfElseTernaryIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time >= 0 && time <= 6)
            {
                Console.WriteLine("İyi geceler.");
            }
            else if(time > 6 && time <= 18)
            {
                Console.WriteLine("İyi günler");
            }
            else
            {
                Console.WriteLine("İyi akşamlar");
            }

            string sonuc = time <= 18 ? "İyi günler" : "İyi geceler";

            sonuc = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi günler" : "İyi Geceler";

            Console.WriteLine(sonuc);
        }
    }
}
