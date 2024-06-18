using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETradeExample
{
    public class ECommerceSystem
    {
        public static void Main()
        {
            // Sipariş oluşturma
            Order order = new Order
            {
                OrderId = 1,
                CustomerName = "John Doe",
                OrderDate = DateTime.Now,
                Items = new List<string> { "Laptop", "Mouse", "Keyboard" }
            };

            // Departmanlar
            CustomerService customerService = new CustomerService();
            WarehouseManagement warehouseManagement = new WarehouseManagement();
            Accounting accounting = new Accounting();

            // Event Abonelikleri
            order.OrderCompleted += customerService.OnOrderCompleted;
            order.OrderCompleted += warehouseManagement.OnOrderCompleted;
            order.OrderCompleted += accounting.OnOrderCompleted;

            // Siparişi Tamamlama
            order.CompleteOrder();
        }
    }
}
