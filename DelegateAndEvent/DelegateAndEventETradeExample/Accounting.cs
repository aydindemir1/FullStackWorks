using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETradeExample
{
    public class Accounting
    {
        public void OnOrderCompleted(string message)
        {
            Console.WriteLine($"Accounting Notification: {message}");
            // Fatura oluşturma kodu burada olabilir.
        }
    }
}
