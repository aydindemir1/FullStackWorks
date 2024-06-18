using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    // Interface Segregation Principle (Arayüz Ayrımı Prensibi)
    public class InterfaceSegregationPrinciple
    {
        static void Main(string[] args)
        {
            IWorkable worker = new Worker();
            IWorkable robot = new Robot();

            worker.Work();
            robot.Work();

            IEatable eater = new Worker();
            eater.Eat();
        }
    }
}
