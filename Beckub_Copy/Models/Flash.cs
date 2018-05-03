using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beckub_Copy.Models
{
    public enum TypeDevice { USB2, USB3}

    public class Flash : Storage
    {
        public int SpeedFlash { get; private set; }

        public double MemoryFlash { get; set; }

        public TypeDevice typeDevice {
            get
            {
                return typeDevice;
            }
            set
            {
                if (TypeDevice.USB2 == value)
                    SpeedFlash = 2000;
                else
                    SpeedFlash = 3000;
            }
        }

        public override double GetMemory()
        {
            return MemoryFlash;
        }

        public override void PrintInfo()
        {
            base.PrintInfo(); // вызываем то, что есть в Printinfo в базовом классе

            Console.WriteLine("Speed Flash -" + SpeedFlash);
            Console.WriteLine("Memory Flash -" + MemoryFlash);
            Console.WriteLine("Type Device -" + typeDevice);
        }
    }
}
