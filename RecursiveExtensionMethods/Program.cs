using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Recursive 
            //3^4 = 3*3*3*3

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;

            }
            Console.WriteLine(result);

            Operations operations = new Operations();
            Console.WriteLine(operations.Expo(3, 4));

            //Extension Methods
            string str = "Erol Turkkan";
            bool result1 = str.CheckSpaces();
            Console.WriteLine(result1);
            if (result1)
            {
                Console.WriteLine(str.RemoveWhiteSpaces());
            }
            Console.WriteLine(str.MakeUpperCase());
            Console.WriteLine(str.MakeLowerCase());

            int[] array1 = { 9, 2, 5, 6, 7, 4, 5, 4, 0};
            array1.SortArray();
            array1.PrintTheScreen();

            int number = 5;
            Console.WriteLine(number.IsEven());

            Console.WriteLine(str.GetFirstCharacter());

            Console.ReadLine();
        }
    }

    public class Operations
    {
        public int Expo(int number1, int expo)
        {
            if (expo < 2)
            {
                return number1;
            }
            return Expo(number1, expo - 1) * number1;
            //Expo(3,4)
            //Expo(3,3) * 3
            //Expo(3,2) * 3 * 3;
            //Expo(3,1) * 3 * 3 * 3;
            //3 * 3 * 3 * 3 = 3^4;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] array = param.Split(' ');
            return string.Join("*", array);
        }


        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void PrintTheScreen(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEven(this int param)
        {
            return (param % 2 == 0);
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }

    }
}
