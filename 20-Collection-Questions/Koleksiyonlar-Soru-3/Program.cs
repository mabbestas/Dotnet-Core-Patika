using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> harfler = new List<char>();

            string input = Console.ReadLine().ToLower();
            foreach(char item in input)
            {
                for(int i = 0; i < sesliHarfler.Length; i++)
                {
                    if( item == sesliHarfler[i])
                    {
                        harfler.Add(item);
                    }
                }
            }
            foreach(char item in harfler)
                Console.WriteLine(item);
        }
    }
}
