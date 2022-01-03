using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();
            rectangle.ShortSide = 3;
            rectangle.LongSide = 4;

            Console.WriteLine("Calculate Area : {0}",rectangle.CalculateArea());
            
            RectangleStruct rectangleStruct;
            rectangleStruct.ShortSide = 3;
            rectangleStruct.LongSide = 4;

            Console.WriteLine("Calculate Area : {0}", rectangleStruct.CalculateArea());


            Console.ReadLine();
        }

        class Rectangle
        {
            public int ShortSide;
            public int LongSide;

            public Rectangle()
            {
                ShortSide = 3;
                LongSide = 4;
            }

            public long CalculateArea() { return this.ShortSide*this.LongSide; }

        }

        struct RectangleStruct
        {

            public int ShortSide;
            public int LongSide;

            public RectangleStruct(int shortSide, int longSide)
            {
                ShortSide = shortSide;
                LongSide = longSide;
            }

            public long CalculateArea() { return this.ShortSide * this.LongSide; }


        }
    }
}
