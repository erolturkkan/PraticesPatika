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
        }
        public void Fly()
        {
            Console.WriteLine("Birds fly");
        }
    }
}
