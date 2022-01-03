using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Number : {0}", Employee.EmployeeNumber);

            Employee employee = new Employee("Erol", "Turkkan", "Game Department");
            Employee employee2 = new Employee("Bunyamin", "Barricade", "Character Design");
            Console.WriteLine("Employee Number : {0}", Employee.EmployeeNumber);

            Console.WriteLine("Sum : " + Transactions.Sum(100, 200));
            Console.WriteLine("Sub : " + Transactions.Sub(800, 200));


            Console.ReadLine();
        }
    }

    class Employee
    {
        private static int employeeNumber;

        public static int EmployeeNumber { get => employeeNumber; }

        private string name;
        private string surname;
        private string depatment;

        static Employee()
        {
            employeeNumber = 0;
        }

        public Employee(string name, string surname, string depatment)
        {
            this.name = name;
            this.surname = surname;
            this.depatment = depatment;
            employeeNumber++;
        }
    }

    static class Transactions
    {
        public static long Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public static long Sub(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
