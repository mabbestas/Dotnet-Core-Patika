using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAvarage
{
    public class Method
    {
        public void Start()
        {
            Console.WriteLine("Hoşgeldiniz!\nHesaplama için fibonacci serisindeki ilk kaç sayıyı kullanmak istiyorsunuz?");
        }

        public int IsNumber(bool sum)
        {
            int n = 0;
            while (sum == false)
            {
                sum = int.TryParse(Console.ReadLine(), out n);
                if (sum == false)
                    Console.WriteLine("Lütfen bir tamsayı giriniz!");
                else
                    sum = true;
            }
            return n;
        }

        public long[] CreateFibonacciArray(int n)
        {
            long[] fibonacci = new long[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }

        public void CalculateAvarage(long[] fibonacci)
        {
            double total = 0;
            for (int j = 0; j < fibonacci.Length; j++)
            {
                total += fibonacci[j];
            }
            double avarage = (double)total / (double)fibonacci.Length;
            Console.WriteLine($"Fibonacci sayılarının ortalaması: {avarage}");
        }
    }
}
