using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class EmployeeBad
    {
            public string Name { get; set; }
            public double Salary { get; set; }

            public double CalculateBonus(string employeeType)
            {
                if (employeeType == "Permanent")
                {
                    return Salary * 0.1;
                }
                else if (employeeType == "Contract")
                {
                    return Salary * 0.05;
                }
                else
                {
                    return 0;
                }
            }
        

    }
}
