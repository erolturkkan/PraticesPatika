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

            if(time>=5 && time < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if(time>=12 && time < 18)
            {
                Console.WriteLine("Good afternoon.");
            }
            else if(time >= 18 && time < 23)
            {
                Console.WriteLine("Good evening.");
            }
            else
            {
                Console.WriteLine("Good Night.");
            }
            Console.ReadLine();
        }
    }
}
