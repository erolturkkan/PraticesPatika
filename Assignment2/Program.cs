using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Collections-Question-1

            Console.WriteLine("* * * * * * * * * * * * * * *  * * * * * * * *");
            Console.WriteLine("* * * * * * Collections-Question-1 * * * * * *");
            Console.WriteLine("* * * * * * * * * * * * * * *  * * * * * * * *");

            ArrayList arrayList = new ArrayList();
            ArrayList primeList = new ArrayList();
            ArrayList notPrimeList = new ArrayList();
            Console.WriteLine("Enter 20 number : \n");
            int counter = 0;
            for (int i = 0; i < 20 + counter; i++)
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n < 0)
                    {
                        Console.WriteLine("Please Enter positive number, add one more number.");
                        counter++;
                    }
                    else
                    {
                        arrayList.Add(n);
                    }

                }
                catch (Exception)
                {
                    counter++;
                    Console.WriteLine("\nError, add one more NUMBER!\n");
                }

            }

            foreach (int input in arrayList)
            {
                int control = 0;

                if (input < 0)
                {
                    //Console.WriteLine("\nPlease enter a positive number.\n");

                }
                else if (input == 0)
                {
                    //Console.WriteLine(input + " is not prime number");
                    notPrimeList.Add(input);
                }
                else if (input == 1)
                {
                    //Console.WriteLine(input + " is not prime number");
                    notPrimeList.Add(input);
                }
                else if (input == 2)
                {
                    //Console.WriteLine(input + " is a prime number");
                    primeList.Add(input);
                }
                else
                {
                    for (int i = 2; i < input; i++)
                    {
                        if (input % i == 0)
                            control++;
                    }

                    if (control != 0)
                        notPrimeList.Add(input);
                    else
                        primeList.Add(input);
                }

            }

            Console.WriteLine("* * * Prime list * * *");
            primeList.Sort();
            primeList.Reverse();
            int countPrime = 0;
            foreach (int item in primeList)
            {
                Console.WriteLine(item);
                countPrime++;
            }

            Console.WriteLine("* * * Not Prime list * * *");
            notPrimeList.Sort();
            notPrimeList.Reverse();
            int countNotPrime = 0;
            foreach (int item in notPrimeList)
            {
                Console.WriteLine(item);
                countNotPrime++;
            }

            Console.WriteLine("* * * Count the items * * *");
            Console.WriteLine("Number of primes " + countPrime);
            Console.WriteLine("Number of not primes " + countNotPrime);

            Console.WriteLine("* * * * Avarage of Not prime List * * * *");
            int notPrimeListTotal = 0;
            foreach (int item in notPrimeList)
            {
                notPrimeListTotal = item + notPrimeListTotal;
            }
            try
            {
                double avarageOfNotPrimeList = notPrimeListTotal / countNotPrime;
                Console.WriteLine(avarageOfNotPrimeList);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("There isn't Not Prime number. That's why, I cant calcute the Average of The Prime Numbers.");
                Console.WriteLine(e.Message.ToString()); ;
            }


            Console.WriteLine("* * * * Avarage of Prime List * * * *");
            int primeListTotal = 0;
            foreach (int item in primeList)
            {
                primeListTotal = item + primeListTotal;
            }
            try
            {
                double avarageOfPrimeList = primeListTotal / countPrime;
                Console.WriteLine(avarageOfPrimeList);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("There isn't prime number. That's why, I cant calcute the Average of The Prime Numbers.");
                Console.WriteLine(e.Message.ToString()); ;
            }



            //Collections-Question-2

            Console.WriteLine("* * * * * * * * * * * * * * *  * * * * * * * *");
            Console.WriteLine("* * * * * * Collections-Question-2 * * * * * *");
            Console.WriteLine("* * * * * * * * * * * * * * *  * * * * * * * *");

            Console.WriteLine("\nEnter 20 positive number : ");
            ArrayList positiveArrayList = new ArrayList();
            ArrayList maxArrayList = new ArrayList();
            ArrayList minArrayList = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                positiveArrayList.Add(Convert.ToInt32(Console.ReadLine()));

            }

            int totalPositiveArr = 0;
            positiveArrayList.Sort();
            for (int i = 0; i < 3; i++)
            {
                minArrayList.Add(positiveArrayList[i]);
                totalPositiveArr = totalPositiveArr + Convert.ToInt32(positiveArrayList[i]);
            }
            int avarageOfMinPosArr = totalPositiveArr / 3;
            Console.WriteLine("Average of at least 3 numbers in the positive array list : " + avarageOfMinPosArr);

            int totalMaxArr = 0;
            positiveArrayList.Reverse();
            for (int i = 0; i < 3; i++)
            {
                maxArrayList.Add(positiveArrayList[i]);
                totalMaxArr = totalMaxArr + Convert.ToInt32(positiveArrayList[i]);
            }
            int avarageOfMaxPosArr = totalMaxArr / 3;
            Console.WriteLine("Average of the maximum 3 numbers in the positive array list : " + avarageOfMaxPosArr);

            Console.WriteLine("The sum of these averages : " + (avarageOfMinPosArr + avarageOfMaxPosArr));


            //Collections-Question-3
            Console.WriteLine("* * * * * * * * * * * * * * *  * * * * * * * *");
            Console.WriteLine("* * * * * * Collections-Question-3 * * * * * *");
            Console.WriteLine("* * * * * * * * * * * * * * *  * * * * * * * *");

            Console.WriteLine("Enter a sentence : ");
            ArrayList vowelList = new ArrayList();
            char[] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            string letters = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(letters.Length); i++)
            {
                for (int j = 0; j < Convert.ToInt32(vowels.Length); j++)
                {
                    if (letters[i].Equals(vowels[j]))
                    {
                        vowelList.Add(letters[i]);
                        Console.WriteLine(letters[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}