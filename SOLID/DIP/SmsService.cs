using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class SmsService : IMessageService
    {
        public void SendMessage(string message)
        {
            // SMS gönderme kodu
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
