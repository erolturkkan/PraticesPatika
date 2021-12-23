using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number is : " + number);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata : "+ex.Message.ToString());
            }

            //**************************************\\

            try
            {
                int a = int.Parse(null);
                int b = int.Parse("test");
                int c = int.Parse("-2000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You entered empty value.");
                Console.WriteLine(ex.Message.ToString());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Data type is not proper.");
                Console.WriteLine(ex.Message.ToString());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Very big or very small");
                Console.WriteLine(ex.Message.ToString());
            }
            Console.ReadLine();
        }
    }
}
