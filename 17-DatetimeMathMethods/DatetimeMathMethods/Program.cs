﻿using System;

namespace DatetimeMathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Now.Date);
            //Console.WriteLine(DateTime.Now.Day);
            //Console.WriteLine(DateTime.Now.Month);
            //Console.WriteLine(DateTime.Now.Year);
            //Console.WriteLine(DateTime.Now.Hour);
            //Console.WriteLine(DateTime.Now.Minute);
            //Console.WriteLine(DateTime.Now.Second);

            //Console.WriteLine(DateTime.Now.DayOfWeek);
            //Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddSeconds(5));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(5));
            Console.WriteLine(DateTime.Now.AddMilliseconds(5));


            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));   //21
            Console.WriteLine(DateTime.Now.ToString("ddd"));  //Mon
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Monday

            Console.WriteLine(DateTime.Now.ToString("MM"));   //04
            Console.WriteLine(DateTime.Now.ToString("MMM"));  //Dec
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //December

            Console.WriteLine(DateTime.Now.ToString("yy"));   //22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022


            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); // mutlak değerini alır
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Floor(22.5)); // Aşağı yuvarlar
            Console.WriteLine(Math.Ceiling(22.5)); // Yukarı yuvarlar
            Console.WriteLine(Math.Round(22.3)); // En yakın tamsayıya yuvarlar
            Console.WriteLine(Math.Round(22.7));

            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Max(2,6));

            Console.WriteLine(Math.Pow(3,4)); // üs alma işlemi
            Console.WriteLine(Math.Sqrt(9));  // kök alma işlemi
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(3));
            Console.WriteLine(Math.Log10(3));
        }
    }
}
