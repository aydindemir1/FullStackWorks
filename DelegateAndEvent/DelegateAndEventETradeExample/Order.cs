using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETradeExample
{
    // Delegate Tanımlaması
    public delegate void OrderCompletedHandler(string message);

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<string> Items { get; set; }

        // Event Tanımlaması
        public event OrderCompletedHandler OrderCompleted;

        public void CompleteOrder()
        {
            // Event Tetikleme
            OrderCompleted?.Invoke($"Order Completed: {OrderId} for {CustomerName} on {OrderDate}");
        }
    }
}
