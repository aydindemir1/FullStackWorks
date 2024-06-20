using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_Generic_
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return this.Name == other.Name && this.Age == other.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }
    }
}
