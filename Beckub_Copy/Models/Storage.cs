using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beckub_Copy.Models
{
    public abstract class Storage
    {
        public int Count { get; set; }

        public int Time { get; set; }

        protected string Name { get; set; }

        public string Model { get; protected set; }

        public abstract double GetMemory();

        public virtual void Copy()
        {
            Console.WriteLine("Copy start");
            Time = 2;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Name -" + Name);
            Console.WriteLine("Model -" + Model);

        }
    }
}
