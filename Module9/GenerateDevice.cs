using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beckub_Copy.Models;

namespace Module9
{
    public class GenerateDevice
    {
        public GenerateDevice()
        {
            hdd = new List<HDD>();
            dvd = new List<DVD>();
            fl = new List<Flash>();
        }

        public List<HDD> hdd;
        public List <DVD> dvd;
        public List<Flash> fl;
        private Random rand = new Random();

        public void generateFlash()
        {
            for (int i = 0; i < rand.Next(1, 20); i++)
            {
                Flash flash = new Flash(string.Format("Model #{0}", rand.Next()));
                flash.MemoryFlash = rand.Next(2000, 128000);
                flash.typeDevice = (TypeDevice)rand.Next(0, 1);
                fl.Add(flash);
            }
        }
    }
}
