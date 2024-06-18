using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class EmployeeRepository
    {
        public void SaveToDatabase(Employee employee)
        {
            // Veritabanına kaydetme kodu
            Console.WriteLine($"Employee {employee.Name} has been saved to the database.");
        }
    }

}
