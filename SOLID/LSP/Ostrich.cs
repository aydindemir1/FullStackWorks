using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class Ostrich : IBird
    {
        public void Eat()
        {
            Console.WriteLine("The ostrich is eating.");
        }
    }
}
