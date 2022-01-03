using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Saturday);

            int temparature = 32;

            if (temparature<=(int)AirTemparature.Normal)
            {
                Console.WriteLine("Wait for getting hot");
            }
            else if (temparature >= (int)AirTemparature.VeryHot)
            {
                Console.WriteLine("Wait for getting cold");
            }else if (temparature >= (int)AirTemparature.Normal && temparature<(int)AirTemparature.VeryHot)
            { Console.WriteLine("You can go out."); }
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=1,
        Tuesday,
        Wednesday,            
        Thursday,
        Friday=23,
        Saturday,
        Sunday
    }

    enum AirTemparature
    {
        Cold =5,
        Normal = 25,
        VeryHot =30
    }

}
