using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);
            
            
            
            int result = Topla(a, b);
            Console.WriteLine(result);

            Methods example = new Methods();
            example.PrintTheScreen(result.ToString());

            int result2 = example.IncreasAndSum(ref a,ref b);
            example.PrintTheScreen(result2.ToString());
            example.PrintTheScreen(Convert.ToString(a+b));



            Console.ReadLine();

        }

        static int Topla(int number1, int number2) 
        { 
            return number1 + number2;
        }
           
    }

    class Methods
    {
        public void PrintTheScreen(string data)
        {
            Console.WriteLine(data);
        }

        public int IncreasAndSum(ref int value1,ref int value2)
        {
            value1 += 1;
            value2 += 1;
            return value1 + value2;
        }

    }

}
