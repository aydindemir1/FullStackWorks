using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class PermanentEmployee : IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public PermanentEmployee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public double CalculateBonus()
        {
            return Salary * 0.1;
        }
    }
}
