using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETradeExample
{
    public class CustomerService
    {
        public void OnOrderCompleted(string message)
        {
            Console.WriteLine($"Customer Service Notification: {message}");
            // Müşteriye e-posta gönderme kodu burada olabilir.
        }
    }
}
