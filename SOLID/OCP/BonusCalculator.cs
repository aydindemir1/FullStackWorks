using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class BonusCalculator
    {
        public double Calculate(IEmployee employee)
        {
            return employee.CalculateBonus();
        }
    }
}
