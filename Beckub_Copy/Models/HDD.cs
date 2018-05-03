using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beckub_Copy.Models
{
    public class HDD : Storage
    {
        public int SpeedHDD { get; set; }
        public TypeDevice typeDevice { get; set; }
        public int  Claster { get; set; }
        public int ClasterMomory { get; set; }

        public override double GetMemory()
        {
            return ClasterMomory;
        }

        public override void PrintInfo()
        {
            base.PrintInfo(); // вызываем то, что есть в Printinfo в базовом классе

            Console.WriteLine("Speed HDD -" + SpeedHDD);
            Console.WriteLine("Type device -" + typeDevice);
            Console.WriteLine("Claster -" + typeDevice);
            Console.WriteLine("Claster Momory - " + ClasterMomory);
        }
    }
}
