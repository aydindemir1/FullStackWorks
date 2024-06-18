using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    // Liskov Substitution Principle (Liskov Yerine Geçme Prensibi)
    public class LiskovSubstitutionPrinciple
    {
        static void Main(string[] args)
        {
            List<IBird> birds = new List<IBird>
        {
            new Sparrow(),
            new Ostrich()
        };

            foreach (var bird in birds)
            {
                bird.Eat();
            }

            List<IFlyingBird> flyingBirds = new List<IFlyingBird>
        {
            new Sparrow()
        };

            foreach (var flyingBird in flyingBirds)
            {
                flyingBird.Fly();
            }
        }
    }
}
