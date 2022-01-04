using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCSharp
{
    internal class Bios
    {
        protected void Nutrition()
        {
            Console.WriteLine("living things feed");
        }
        protected void Respiration()
        {
            Console.WriteLine("living things breathe");
        }
        protected void Excretion() 
        {
            Console.WriteLine("living things excrete");
        }

        public virtual void Stimuliresponse()
        {
            Console.WriteLine("living things react to stimuli");
        }

    }
}
