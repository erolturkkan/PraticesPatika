using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SeedPlant seedPlant = new SeedPlant();
            seedPlant.BySeed();

            Console.WriteLine("\n* * * * * * * * * * *\n");

            Birds owl = new Birds();
            owl.Fly();










            //Person[] persons = new Person[3]
            //{
            //    new Customer
            //    {
            //        FirstName = "Erol"
            //    }, 
            //    new Student
            //    {
            //        FirstName = "Ahmet"
            //    },
            //    new Person
            //    {
            //        FirstName = "Mehmet"
            //    }
            //};
            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person.FirstName);
            //}

            Console.ReadLine();
        }
    }

    //class Person
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //}

    //class Customer : Person
    //{
    //    public string City { get; set; }
    //}

    //class Student : Person
    //{
    //    public string Department { get; set; }
    //}

}
