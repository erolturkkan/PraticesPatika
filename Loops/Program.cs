using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print odd numbers from 1 to entered number
            Console.WriteLine("print odd numbers from 1 to entered number\n");
            Console.Write("Please enter a number : ");
            int counter = int.Parse(Console.ReadLine());
            for (int i = 1; i < counter; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //print Total odd and Total even numbers 
            Console.WriteLine("\nprint Total odd and Total even numbers \n");
            int oddTotal = 0;
            int evenTotal = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 1)
                {
                    oddTotal += i;
                }
                else
                {
                    evenTotal += i;
                }
            }
            Console.WriteLine("Odd total : " + oddTotal);
            Console.WriteLine("Even total  : " + evenTotal);

            //break, continue

            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
