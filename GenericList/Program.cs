using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<T> class
            //System.Collections.Generic
            //T -> object type

            List<int> numberList = new List<int>();
            numberList.Add(23);
            numberList.Add(10);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(92);
            numberList.Add(34);

            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("Blue");
            colorList.Add("Orange");
            colorList.Add("Yellow");
            colorList.Add("Green");
            colorList.Add("Purple");

            Console.WriteLine("* * * * Count Started * * * *");
            //Count
            Console.WriteLine(colorList.Count);
            Console.WriteLine(numberList.Count);
            Console.WriteLine("* * * * Count Done * * * *");

            //Foreach and List.ForEach access of items
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
            foreach (var color in colorList)
            {
                Console.WriteLine(color);
            }

            string stars = "******************";
            Console.WriteLine(stars);
            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));
            Console.WriteLine(stars);

            //Remove item in list
            numberList.Remove(4);
            colorList.Remove("Green");

            Console.WriteLine(stars);
            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));
            Console.WriteLine(stars);

            Console.WriteLine(stars);

            numberList.RemoveAt(0);
            colorList.RemoveAt(1);

            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            Console.WriteLine(stars);

            //Search item in list
            if (numberList.Contains(10))
            {
                Console.WriteLine("There is 10 in number list.");
            }

            //Go to index with item            
            Console.WriteLine(colorList.BinarySearch("Blue"));

            //Convert array to list
            string[] animals = { "Cat", "Dog", "Bird" };

            List<string> animalList = new List<string>(animals);

            //Clear the list
            animalList.Clear();

            //If I want to hold object in list
            List<Users> userList = new List<Users>();
            Users user1 = new Users();
            user1.Name = "Ayse";
            user1.Surname = "Yilmaz";
            user1.Age = 26;

            Users user2 = new Users();
            user2.Name = "Ahmet";
            user2.Surname = "Cakal";
            user2.Age = 54;

            userList.Add(user1);
            userList.Add(user2);

            List<Users> newList = new List<Users>();
            newList.Add(new Users(){
                Name = "Erol",
                Surname = "Turkkan",
                Age = 19
            });

            foreach (Users user in userList)
            {
                Console.WriteLine("User name : " +user.Name);
                Console.WriteLine("User surname : " + user.Surname);
                Console.WriteLine("User age : "+ user.Age);
            }

            Console.ReadLine();
        }
        
    }

    public class Users
    {
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}
