using Beckub_Copy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9 // Наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите объем данных");
            double temp = Double.Parse(Console.ReadLine());

            GenerateDevice gd = new GenerateDevice();
            gd.generateFlash();

            Service serv = new Service();
            double totalMemory = serv.CalculateTotalMemory( new List<HDD>(), gd.fl, new List<DVD>());
            Console.WriteLine("Общий объем флешек = {0} ({1})", totalMemory, gd.fl.Count);

            TimeSpan time = serv.CalculateTotalTime(gd.fl);
            Console.WriteLine(time.TotalMinutes);

            serv.getCount(ref gd.fl, temp);
            foreach (Flash item in gd.fl)
            {
                item.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}
