using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETrade
{
    // Senaryo 1: E-Ticaret Sistemi
    public class DelegateAndEventETrade
    {
        static void Main(string[] args)
        {
            // Sipariş yönetimi, müşteri hizmetleri, depo yönetimi ve muhasebe nesneleri oluşturuluyor
            OrderManager orderManager = new OrderManager();
            CustomerService customerService = new CustomerService();
            InventoryManagement inventoryManagement = new InventoryManagement();
            Accounting accounting = new Accounting();

            // Departmanlar event'e abone oluyor
            orderManager.OrderCompleted += customerService.OnOrderCompleted;
            orderManager.OrderCompleted += inventoryManagement.OnOrderCompleted;
            orderManager.OrderCompleted += accounting.OnOrderCompleted;

            // Bir sipariş tamamlanıyor
            List<string> products = new List<string> { "Laptop", "Mouse", "Keyboard" };
            orderManager.CompleteOrder(1, "customer@example.com", products);
        }
    }
}
