using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public class Worker : IWorkable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("Working...");
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
}
