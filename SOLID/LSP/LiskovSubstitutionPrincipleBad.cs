using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class LiskovSubstitutionPrincipleBad
    {
        public class Bird
        {
            public virtual void Fly()
            {
                Console.WriteLine("The bird is flying.");
            }
        }

        public class Ostrich : Bird
        {
            public override void Fly()
            {
                throw new NotImplementedException("Ostriches can't fly!");
            }
        }

    }
}
