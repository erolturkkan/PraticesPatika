using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    internal class Focus : ICar
    {
        public Brand WhichBrand()
        {
            return Brand.Ford;
        }

        public int WheelNumber()
        {
            return 4;
        }

        public Color DefaultColor()
        {
            return Color.White;
        }
    }
}
