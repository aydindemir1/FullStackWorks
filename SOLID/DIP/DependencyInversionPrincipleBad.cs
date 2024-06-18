using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    //  Dependency Inversion Principle (Bağımlılıkların Tersine Çevrilmesi Prensibi)
    public class DependencyInversionPrincipleBad
    {
        public class EmailService
        {
            public void SendEmail(string message)
            {
                // Email gönderme kodu
                Console.WriteLine($"Email sent: {message}");
            }
        }

        public class Notification
        {
            private EmailService _emailService;

            public Notification()
            {
                _emailService = new EmailService();
            }

            public void Notify(string message)
            {
                _emailService.SendEmail(message);
            }
        }

    }
}
