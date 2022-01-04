using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCS
{
    internal class NewFocus : Car
    {
        public override Brand WhichBrand()
        {
            return Brand.Ford;
        }
    }
}
