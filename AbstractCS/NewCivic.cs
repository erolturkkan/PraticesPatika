using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCS
{
    internal class NewCivic : Car
    {
        public override Brand WhichBrand()
        {
            return Brand.Honda;
        }
        public override Color DefaultColor()
        {
            return Color.Gray;
        }
    }
}
