using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public class InterfaceSegregationPrincipleBad
    {
        public interface IWorker
        {
            void Work();
            void Eat();
        }

        public class Worker : IWorker
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

        public class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Working...");
            }

            public void Eat()
            {
                throw new NotImplementedException("Robots do not eat.");
            }
        }

    }
}
