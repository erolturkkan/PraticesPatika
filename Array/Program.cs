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

            //array class methods
            Console.WriteLine("\n***************************\n*** Array Class Methods ***\n***************************\n");

            //Sort
            int[] numberArray1 = { 1, 2, 3 , 34, 54, 54,67, 97,12, 45, 67};

            //not sort
            foreach (var number in numberArray1)
            {
                Console.WriteLine(number);
            }
            //sort
            Console.WriteLine("* * * * * Sort * * * * *");
            Array.Sort(numberArray1);
            foreach (var number in numberArray1)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("*** Array Clear ***");
            //This method makes 0 the 2nd index and the next index.
            Array.Clear(numberArray1, 2, 2);
            foreach (var number in numberArray1)
            {
                Console.WriteLine(number);
            }

            //Reverse
            Console.WriteLine("* * * * * Reverse * * * * *");
            Array.Reverse(numberArray1);
            foreach (var number in numberArray1)
            {
                Console.WriteLine(number);
            }

            //Index Of
            Console.WriteLine("* * * * * Index Of * * * * *");
            Console.WriteLine(Array.IndexOf(numberArray1, 34));

            //Resize
            Console.WriteLine("* * * * * Resize * * * * *");
            Array.Resize<int>(ref numberArray1, 13);
            numberArray1[12] = 99;
            foreach (var number in numberArray1)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
