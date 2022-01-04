using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NewFocus newFocus = new NewFocus();
            Console.WriteLine(newFocus.WhichBrand().ToString());
            Console.WriteLine(newFocus.NumberOfWheel());
            Console.WriteLine(newFocus.DefaultColor().ToString());

            Console.WriteLine("* * * * * * *  * * * * * * * * * * * ");

            NewCivic newCivic = new NewCivic();
            Console.WriteLine(newCivic.WhichBrand().ToString());
            Console.WriteLine(newCivic.NumberOfWheel());
            Console.WriteLine(newCivic.DefaultColor().ToString());

            Console.WriteLine("* * * * * * *  * * * * * * * * * * * ");

            NewCorolla newCorolla = new NewCorolla();
            Console.WriteLine(newCorolla.WhichBrand().ToString());
            Console.WriteLine(newCorolla.NumberOfWheel());
            Console.WriteLine(newCorolla.DefaultColor().ToString());


            Console.ReadLine();
        }
    }
}
