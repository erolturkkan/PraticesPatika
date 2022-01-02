using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList list = new ArrayList();
            //list.Add("Ayse");
            //list.Add(2);
            //list.Add(true);
            //list.Add('A');

            //Access to data
            //Console.WriteLine(list[1]);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //AddRange
            Console.WriteLine("**** Add Range ****");
            //string[] colours = { "Red", "Yellow", "Green" };
            List<int> numbers = new List<int>() {1,8,3,7,9,92,5};
            //list.AddRange(colours);
            list.AddRange(numbers);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("* * * * Sort * * * *");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Binary Search
            Console.WriteLine("* * * * * Binary Search * * * * *");
            Console.WriteLine(list.BinarySearch(9));

            //Reverse
            Console.WriteLine("* * * * Reverse * * * *");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("* * * * Clear * * * *");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
