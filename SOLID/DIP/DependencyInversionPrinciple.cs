using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    //  Dependency Inversion Principle (Bağımlılıkların Tersine Çevrilmesi Prensibi)
    public class DependencyInversionPrinciple
    {
        static void Main(string[] args)
        {
            IMessageService emailService = new EmailService();
            Notification emailNotification = new Notification(emailService);
            emailNotification.Notify("This is an email notification.");

            IMessageService smsService = new SmsService();
            Notification smsNotification = new Notification(smsService);
            smsNotification.Notify("This is an SMS notification.");
        }
    }
}
