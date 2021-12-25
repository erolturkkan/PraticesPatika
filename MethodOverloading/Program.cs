using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out paramethers
            string number1 = "999";

            bool result = int.TryParse(number1, out int outNumber);
            if (result)
            {
                Console.WriteLine("Success");
                Console.WriteLine(outNumber);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Methods methods = new Methods();
            methods.Sum(4, 5, out int total);
            Console.WriteLine(total);

            //Method Overloading
            int integer = 999;
            methods.PrintTheScreen(Convert.ToString(integer));
            methods.PrintTheScreen(integer);
            methods.PrintTheScreen("Erol","tr");

            Console.ReadLine();
        }
    }

    class Methods
    {
        public void Sum(int a, int b, out int total)
        {
            total = a+b;
        }

        public void PrintTheScreen(string data) 
        { 
            Console.WriteLine(data); 
        }
        public void PrintTheScreen(int data)
        {
            Console.WriteLine(data);
        }
        public void PrintTheScreen(string data1, string data2)
        {
            Console.WriteLine(data1+data2);
        }
    }
}
