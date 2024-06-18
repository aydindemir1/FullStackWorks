using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETradeExample
{
    public class WarehouseManagement
    {
        public void OnOrderCompleted(string message)
        {
            Console.WriteLine($"Warehouse Management Notification: {message}");
            // Stok güncelleme kodu burada olabilir.
        }
    }
}
