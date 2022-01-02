using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collection.Generic
            Dictionary<int,string> users = new Dictionary<int,string>();

            users.Add(10, "Erol Turkkan");
            users.Add(12, "Ahmet Cabbar");
            //users.Add(12, "Ahmet Cabbar");
            //System.ArgumentException: 'An item with the same key has already been added.'
            users.Add(18, "Mamet Yardım");
            users.Add(20, "Ece Kırmızı");

            //Access item of array
            Console.WriteLine("Access item of array");
            Console.WriteLine(users[12]);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("* * * * Count * * * *");
            Console.WriteLine(users.Count);

            //Contains
            Console.WriteLine("* * * * Contains * * * *");
            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("Erol Turkkan"));

            //Remove
            Console.WriteLine("* * * * Remove * * * *");
            users.Remove(12);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("* * * * Keys * * * *");
            foreach (var item in users.Keys)
            {
                Console.WriteLine(item);
            }
            //Values
            Console.WriteLine("* * * * Values * * * *");
            foreach (var item in users.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
