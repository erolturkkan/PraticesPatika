using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Assignment Operators
            /* 
             
            +=
            -=
            *=
            /=
            %=
            <<=
            >>=
            >>>=
            &=
            ^=
            |=
             
             */

            int x = 3;
            int y = 4;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Logical Operators
            // || or
            // && and
            // !  not

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }
            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }
            if (!isSuccess == false && isCompleted == false)
            {
                Console.WriteLine("Bad");
            }

            //relational operators
            /*
                 >   greater than
                 >=  greater than or equal to
                 <   less than
                 <=  less than or equal to 
                 ==  equal to
                 !=  not equal to
             */ 

            int a = 3;
            int b = 4;
            bool result = a>b;

            Console.WriteLine(result);
            result = a>=b;
            Console.WriteLine(result);
            result = a < b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

            //Arithmetic Operators
            // + - * / % ++ --

            //myNotes
            //conditions
            var number1 = 11;
            //single line if else
            Console.WriteLine(number1 == 10 ? "Number is 10" : "Number is not 10");


            var number2 = 20;
            //normal if else
            if (number2 == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number2 == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }

            //switch
            var number3 = 30;
            switch (number3)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                case 30:
                    Console.WriteLine("Number is 30");
                    break;
            }

            //operators
            var number4 = 27;
            if (number4 >= 0 && number4 <= 100)
            {
                Console.WriteLine(number4.ToString() + " is between 0-100");
            }else if (number4 > 100 && number4 < 200)
            {
                Console.WriteLine(number4.ToString() + " is between 101-200");
            }
            else if (number4 > 200)
            {
                Console.WriteLine(number4.ToString()+ " greater than 200");
            }
            else if (number4 < 0)
            {
                Console.WriteLine(number4.ToString() + " is less than 0");
            }
            else
            {
                Console.WriteLine(number4.ToString() + " is not number");
            }

            Console.ReadLine();

            }
        }
    }
