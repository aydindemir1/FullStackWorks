using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class EmployeeReportGenerator
    {
        public void GenerateReport(Employee employee)
        {
            // Rapor oluşturma kodu
            Console.WriteLine($"Report for employee {employee.Name} has been generated.");
        }
    }

}
