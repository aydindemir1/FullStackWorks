using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETrade
{
    // Delegate tanımı
    public delegate void OrderCompletedEventHandler(object sender, OrderEventArgs e);

    // Event argümanları için bir sınıf tanımı
    public class OrderEventArgs : EventArgs
    {
        public int OrderId { get; set; }
        public string CustomerEmail { get; set; }
        public List<string> Products { get; set; }

        public OrderEventArgs(int orderId, string customerEmail, List<string> products)
        {
            OrderId = orderId;
            CustomerEmail = customerEmail;
            Products = products;
        }
    }

}
