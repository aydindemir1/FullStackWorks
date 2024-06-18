using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
   // Single Responsibility Principle(Tek Sorumluluk Prensibi)
    public class SingleResponsibilityPrinciple
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John Doe", "john.doe@example.com", 50000);
            EmployeeRepository repository = new EmployeeRepository();
            EmployeeReportGenerator reportGenerator = new EmployeeReportGenerator();

            repository.SaveToDatabase(employee);
            reportGenerator.GenerateReport(employee);
        }
    }
}
