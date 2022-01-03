using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConcept
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

            Employee employee1 = new Employee();
            employee1.name = "Ahmet";
            employee1.surname = "Yılmaz";
            employee1.id = 1;
            employee1.department = "Sofware Department";
            employee1.EmployeeInfos();
            Console.WriteLine("* * * * * * * * * * *");

            Employee employee2 = new Employee();
            employee2.name = "Erol";
            employee2.surname = "Turkkan";
            employee2.id = 2;
            employee2.department = "Game Department";
            employee2.EmployeeInfos();
            Console.WriteLine("* * * * * * * * * * *");

            Console.ReadLine();
        }
        class Employee
        {
            public int id;
            public string name;
            public string surname;
            public string department;

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
