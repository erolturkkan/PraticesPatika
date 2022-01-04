using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCS
{
    internal abstract class Car
    {
        public int NumberOfWheel()
        {
            return 4;
        }
        public virtual Color DefaultColor()
        {
            return Color.White;
        }
        public abstract Brand WhichBrand();
    }
}
