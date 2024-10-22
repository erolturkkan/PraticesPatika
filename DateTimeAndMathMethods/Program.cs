﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAndMathMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime format
            Console.WriteLine(DateTime.Now.ToString("dd"));//28
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Tue
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Tuesday

            Console.WriteLine(DateTime.Now.ToString("MM"));//12
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Dec
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//December

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021

            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("* * * * * * * * * * MATH * * * * * * * * * *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");

            //Math
            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); //23
            Console.WriteLine(Math.Floor(22.7)); //22
            Console.WriteLine(Math.Round(22.3)); //22
            Console.WriteLine(Math.Round(22.7)); //23

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); // 3^4 = 81
            Console.WriteLine(Math.Sqrt(9)); // square = 3
            Console.WriteLine(Math.Log(9)); // floor e logarithm
            Console.WriteLine(Math.Exp(3)); // e^3
            Console.WriteLine(Math.Log10(10)); //floor 10 logarithm

            //Convert 12:00:00PM to 24 hours

            String s = "07:05:45PM";
            DateTime dt = DateTime.Parse(s);
            Console.WriteLine(dt.ToString("HH:mm"));

            Console.ReadLine();
        }
    }
}
