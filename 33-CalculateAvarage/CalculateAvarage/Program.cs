using System;

namespace CalculateAvarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Method methods = new Method();
            bool sum = false;

            methods.Start();

            int n = methods.IsNumber(sum);

            long[] fibonacci = new long[n];
            fibonacci = methods.CreateFibonacciArray(n);

            methods.CalculateAvarage(fibonacci);
        }
    }
}
