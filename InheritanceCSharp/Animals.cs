using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceCSharp
{
    internal class Animals:Bios
    {
        protected void Adaptation()
        {
            Console.WriteLine("Animals can adapt.");
        }

        public override void Stimuliresponse()
        {
            base.Stimuliresponse();
            Console.WriteLine("animals react to contact");
        }

    }

    internal class Reptiles:Animals
    {
        public Reptiles()
        {
            base.Adaptation();
            base.Respiration();
            base.Nutrition();
            base.Excretion();
        }
        public void CrawlingMotion()
        {
            Console.WriteLine("reptiles move by crawling");
        }
    }

    internal class Birds:Animals
    {
        public Birds()
        {
            base.Adaptation();
            base.Respiration();
            base.Nutrition();
            base.Excretion();
            base.Stimuliresponse();
        }
        public void Fly()
        {
            Console.WriteLine("Birds fly");
        }
    }
}
