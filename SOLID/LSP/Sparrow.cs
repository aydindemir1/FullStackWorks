using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class Sparrow : IFlyingBird
    {
        public void Eat()
        {
            Console.WriteLine("The sparrow is eating.");
        }

        public void Fly()
        {
            Console.WriteLine("The sparrow is flying.");
        }
    }
}
