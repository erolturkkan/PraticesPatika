using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string variable1 = "Our lesson is CSharp, Welcome!";

            string variable2 = "CSharp";
            
            //Length
            Console.WriteLine(variable1.Length);

            //ToUpper , ToLower
            Console.WriteLine(variable1.ToUpper());
            Console.WriteLine(variable1.ToLower());

            //Concat
            Console.WriteLine(String.Concat(variable1, " Hello!"));

            //Compare, CompareTo
            Console.WriteLine(variable1.CompareTo(variable2)); //0, 1, -1
            Console.WriteLine(String.Compare(variable1 ,variable2, true)); //0, 1, -1
            Console.WriteLine(String.Compare(variable1, variable2, false)); //0, 1, -1

            //Contains
            Console.WriteLine(variable1.Contains(variable2));
            Console.WriteLine(variable1.EndsWith("Welcome!"));
            Console.WriteLine(variable1.StartsWith("Hello!"));

            //IndexOf
            Console.WriteLine(variable1.IndexOf("CS"));
            Console.WriteLine(variable1.IndexOf("Erol"));

            //Insert
            Console.WriteLine(variable1.Insert(0, "Hello! "));
            Console.WriteLine(variable1.LastIndexOf("i"));

            //Padleft, Padright
            Console.WriteLine(variable1 + variable2.PadLeft(30));
            Console.WriteLine(variable1 + variable2.PadLeft(30, '*'));
            Console.WriteLine(variable1.PadRight(50) + variable2);
            Console.WriteLine(variable1.PadRight(50, '-') + variable2.PadLeft(30, '*'));

            //Remove
            Console.WriteLine(variable1.Remove(10));
            Console.WriteLine(variable1.Remove(5,3));
            Console.WriteLine(variable1.Remove(0,1));

            //Replace
            Console.WriteLine(variable1.Replace("CSharp", "C#"));
            Console.WriteLine(variable1.Replace(" ", "*"));

            //Split
            Console.WriteLine(variable1.Split(' ')[1]);

            //Substring
            Console.WriteLine(variable1.Substring(4));
            Console.WriteLine(variable1.Substring(4,6));

            Console.ReadLine();
            
        }
    }
}
