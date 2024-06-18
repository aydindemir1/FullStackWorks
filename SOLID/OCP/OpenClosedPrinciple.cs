using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    // Open/Closed Principle (Açık/Kapalı Prensibi)
    public class OpenClosedPrinciple
    {
        static void Main(string[] args)
        {
            IEmployee permanentEmployee = new PermanentEmployee("John Doe", 50000);
            IEmployee contractEmployee = new ContractEmployee("Jane Smith", 40000);

            BonusCalculator bonusCalculator = new BonusCalculator();

            Console.WriteLine($"Permanent Employee Bonus: {bonusCalculator.Calculate(permanentEmployee)}");
            Console.WriteLine($"Contract Employee Bonus: {bonusCalculator.Calculate(contractEmployee)}");
        }
    }
}
