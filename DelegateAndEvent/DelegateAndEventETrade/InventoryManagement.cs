using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETrade
{
    public class InventoryManagement
    {
        public void OnOrderCompleted(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Updating inventory for order {e.OrderId}.");
            foreach (var product in e.Products)
            {
                Console.WriteLine($"Decreasing stock for product {product}.");
            }
        }
    }

}
