using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndAccessSpecifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class ClassName
            //   {
            //      [Access Specifier] [data type (int,string)] FieldName;
            //      [Access Specifier] [return type] MethodName([paramether list])
            //      {
            //       //Method Commands
            //      }
            //      
            //   }

            //Access Specifier
            // * Public 
            // * Private 
            // * Internal
            // * Protected

            Console.WriteLine("* * * * * Employee1 * * * * *");
            Employee employee1 = new Employee("Ahmet", "Yılmaz", "Sofware Department", 1);

            employee1.EmployeeInfos();

            Console.WriteLine("* * * * * Employee2 * * * * *");
            Employee employee2 = new Employee("Erol", "Turkkan", "Game Department", 2);

            employee2.EmployeeInfos();

            Console.WriteLine("* * * * * Employee3 * * * * *");
            Employee employee3 = new Employee("Bunyamin", "Barricade");

            employee3.EmployeeInfos();


            Console.ReadLine();
        }
        class Employee
        {
            public int id;
            public string name;
            public string surname;
            public string department;

            public Employee(string name, string surname, string department, int id)
            {
                this.name = name;
                this.surname = surname;
                this.department = department;
                this.id = id;
            }

            public Employee(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
            }

            public Employee()
            {

            }

            public void EmployeeInfos()
            {
                Console.WriteLine("Employee name : {0}", name);
                Console.WriteLine("Employee surname : {0}", surname);
                Console.WriteLine("Employee id : {0}", id);
                Console.WriteLine("Employee department : {0}", department);

            }
        }
    }
}
