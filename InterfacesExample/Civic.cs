using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    internal class Civic : ICar
    {
        public Color DefaultColor()
        {
            return Color.Gray;
        }

        public int WheelNumber()
        {
            return 4;
        }

        public Brand WhichBrand()
        {
            return Brand.Honda;
        }
    }
}
