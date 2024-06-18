using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class EmployeeBad
    {
      
            public string Name { get; set; }
            public string Email { get; set; }
            public double Salary { get; set; }

            public void SaveToDatabase()
            {
                // Veritabanına kaydetme kodu
            }

            public void GenerateReport()
            {
                // Rapor oluşturma kodu
            }
       

    }
}
