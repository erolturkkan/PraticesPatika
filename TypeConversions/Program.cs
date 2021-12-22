using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string star5 = " ***** ";

            // Implict Conversion
            Console.WriteLine(star5 + "Implict Conversion" + star5);

            byte byte1 = 5;
            sbyte sbyte1 = 6;
            short short1 = 7;

            int int1 = byte1 + sbyte1 + short1;
            Console.WriteLine("Integer 1 : " + int1);

            long long1 = int1;
            Console.WriteLine("Long 1 : " + long1);

            float float1 = long1;
            Console.WriteLine("Float 1 : " + float1);

            string string1 = "Erol";
            char char1 = 'b';
            object obj1 = string1 + char1 + int1;
            Console.WriteLine("Object 1 : " + obj1);

            //Explicit Conversion

            Console.WriteLine(star5 + "Explicit Conversion" + star5);
            int int2 = 4;
            byte byte2 = (byte)int2;
            Console.WriteLine("Byte 2 : " + byte2);

            int int3 = 100;
            byte byte3 = (byte)int3;
            Console.WriteLine("Byte 3 : " + byte3);

            //ToString Methodu
            Console.WriteLine(star5 + "ToString Methodu" + star5);
            int int4 = 6;
            string string2 = int4.ToString();
            Console.WriteLine("String 2 : " + string2);

            string string3 = 12.5f.ToString();
            Console.WriteLine("String : " + string3);

            //System.Convert
            Console.WriteLine(star5 + "System.Convert Class" + star5);
            string string4 = "10", string5 = "20";
            int int6, int7;
            int total;

            int6 = Convert.ToInt32(string4);
            int7 = Convert.ToInt32(string5);
            
            total = int6 + int7;
            Console.WriteLine("Total : "+ total);

            //Parse
            Console.WriteLine(star5 + "Parse Method" + star5);
            ParseMethod();
            Console.WriteLine("\nPress key for close the screen.");
            Console.ReadLine();
        }

        public static void ParseMethod()
        {
            string str1 = "10";
            string str2 = "10.25";
            int number1;
            double double1;

            number1 = Int32.Parse(str1);
            double1 = Double.Parse(str2);

            Console.WriteLine("Number 1 : "+number1);
            Console.WriteLine("Double 1 : "+double1);

            
        }

    }
}
