using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 5 && time < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time >= 12 && time < 18)
            {
                Console.WriteLine("Good afternoon.");
            }
            else if (time >= 18 && time < 23)
            {
                Console.WriteLine("Good evening.");
            }
            else
            {
                Console.WriteLine("Good Night.");
            }


            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Ok");
                    break;

            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Fall");
                    break;

                default:
                    break;
            }

            Console.ReadLine();

        }
    }
}
