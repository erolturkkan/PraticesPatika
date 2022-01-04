using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCSharp
{
    internal class Plants:Bios
    {
        protected void Photosynthesis()
        {
            Console.WriteLine("Plants can photosynthesize.");
        }

        public override void Stimuliresponse()
        {
            //base.Stimuliresponse();
            Console.WriteLine("plants react to the sun");
        }

    }

    internal class SeedPlant:Plants
    {
        public SeedPlant()
        {
            base.Photosynthesis();
            base.Nutrition();
            base.Excretion();
            base.Respiration();
            base.Stimuliresponse();

        }
        public void BySeed()
        {
            Console.WriteLine("seed plants reproduce by seeds.");
        }
        
    }

    internal class SeedlessPlant:Plants
    {
        public SeedlessPlant()
        {
            base.Photosynthesis();
            base.Respiration();
            base.Nutrition();
            base.Excretion();
        }
        public void Spore()
        {
            Console.WriteLine("seedless plants reproduce by spores.");
        }
        
    }
}
