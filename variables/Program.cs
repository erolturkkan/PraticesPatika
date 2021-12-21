using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stars = "**********";
            Console.WriteLine(stars);
            Console.WriteLine("Numbers");

            byte b = 5;       //1 byte
            sbyte sb = 5;      //1 byte

            short sh = 5;     //2 byte
            ushort ush = 5;   //2 byte

            Int16 i16 = 2;    //2 byte
            int i = 2;        //4 byte
            Int32 i32 = 2;    //4 byte
            Int64 i64 = 2;    //8 byte

            uint ui = 2;      //4 byte
            long l = 4;       //8 byte
            ulong ul = 4;     //8 byte


            Console.WriteLine(stars);
            Console.WriteLine("Reel Numbers");
            float f = 5;      //4 byte
            double d = 5;     //8 byte
            decimal c = 5;    //16 byte

            Console.WriteLine(stars);
            char ch = '2';         // 2 byte
            string str = "Erol";   // limitless

            bool b1 = true;
            bool b2 = false;

            Console.WriteLine(stars);

            DateTime dt1 = DateTime.Now;

            Console.WriteLine(dt1);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //strings
            Console.WriteLine(stars);

            string str1 = string.Empty;
            str1 = "Erol Turkkan";
            string name = "Erol";
            string surname = "Turkkan";
            string fullName = name + " " + surname;

            //ways to define integers

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean

            bool bool1 = 10>2; //true

            //Convert of variables
            Console.WriteLine(stars);
            string st20 = "20";
            int int21 = 21;
            string newValue = st20 + int21.ToString();
            Console.WriteLine(newValue); // out: 2021

            int int2021 = Convert.ToInt32(st20) + int21;
            Console.WriteLine(int2021.ToString());

            // dateTime
            Console.WriteLine(stars);
            Console.WriteLine("Date time");

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            //hour
            Console.WriteLine(stars);
            Console.WriteLine("Hour");

            string hour = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(hour);

            Console.ReadLine();
        }
    }
}
