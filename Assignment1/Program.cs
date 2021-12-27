using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string star = "\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n";

            //First
            Console.WriteLine(star);
            Console.WriteLine("First");

            Console.WriteLine("I want to enter number, first how much you want to enter, second your numbers.");
            Console.WriteLine("For exmaple, You want to enter 6 numbers.");
            Console.WriteLine("First input is 6, Second input is 1 2 3 4 5 6");
            

            Console.WriteLine("Please enter how much you want to add number : ");
            int number = Convert.ToInt32(Console.ReadLine().TrimEnd());
            Console.WriteLine("Enter that numbers seperated by spaces (2 4 5 7 ...) : ");
            int[] numberValues = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToArray();
            
            Console.WriteLine(star);

            Console.WriteLine("Even numbers are ");
            foreach (var num in numberValues)
            {
                if (num.IsEven())
                {
                    Console.WriteLine(num);
                }
            }


            //Second
            

            Console.WriteLine(star);
            Console.WriteLine("Second");
            Console.WriteLine("Enter 2 positive numbers : (n,m) First n, Then m");
            Console.WriteLine("Enter n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter m : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + n + " numbers : ");
            int[] numbersN = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToArray();

            foreach (int value in numbersN)
            {
                if(value == m)
                {
                    Console.WriteLine(value);
                }
                else if (value % m == 0)
                {
                    Console.WriteLine(value);
                }
            }

            Console.WriteLine(star);

            //Third
            Console.WriteLine("Third");
            
            Console.WriteLine("Enter a positive number : ");
            int aPosNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter " + aPosNum + " words.");
            string[] vs = Console.ReadLine().TrimEnd().Split(' ').ToArray();
            
            foreach (var item in vs.Reverse())
            {
                Console.WriteLine(item);
            }

            //Fourth
            Console.WriteLine(star);
            Console.WriteLine("Fourth");
            Console.WriteLine("Please enter a sentence : ");
            string[] sentence = Console.ReadLine().TrimEnd().Split(' ').ToArray();
            Console.WriteLine("There are " + sentence.Length.ToString() + " words");

            int countWords = 0; 
            foreach (var item in sentence)
            {
                int itemCount = Convert.ToInt32(item.ToCharArray().Length);
                countWords = countWords + itemCount;
            }
            Console.WriteLine("There are " + countWords + " letters.");
            Console.ReadLine();
        }
    }

    public static class Extension
    {
        public static bool IsEven(this int param)
        {
            return param % 2 == 0;
        }
    }
}
