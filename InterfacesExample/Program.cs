using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.WhichBrand().ToString());
            Console.WriteLine(focus.WheelNumber());
            Console.WriteLine(focus.DefaultColor().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.WhichBrand().ToString());
            Console.WriteLine(civic.WheelNumber());
            Console.WriteLine(civic.DefaultColor().ToString());

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.WhichBrand().ToString());
            Console.WriteLine(corolla.WheelNumber());
            Console.WriteLine(corolla.DefaultColor().ToString());
        }
    }
}
