using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare array
            string[] colours = new string[5];

            string[] animals = { "Cat", "Dog", "Bird", "Monkey" };

            int[] array1;
            array1 = new int[5];

            //assigning and accessing values ​​to arrays
            colours[0] = "Blue";
            array1[3] = 10;

            Console.WriteLine(animals[1]);
            Console.WriteLine(array1[3]);
            Console.WriteLine(colours[0]);

            //using arrays with loops
            //Average of n numbers entered from the keyboard
            Console.Write("Enter lenght of Array : ");
            int lenghtofArray = int.Parse(Console.ReadLine());
            int[] numberArray = new int[lenghtofArray];

            for (int i = 0; i < lenghtofArray; i++)
            {
                Console.Write("Please enter {0}. number : ",i+1);
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            foreach (var number in numberArray)
            {
                total += number;
            }
            Console.WriteLine("Avarage : " + total/lenghtofArray);

            Console.ReadLine();
        }
    }
}
