using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    internal interface ICar
    {
        int WheelNumber();
        Brand WhichBrand();
        Color DefaultColor();
    }
}
