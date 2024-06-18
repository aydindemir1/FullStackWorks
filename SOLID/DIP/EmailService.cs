using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            // Email gönderme kodu
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
