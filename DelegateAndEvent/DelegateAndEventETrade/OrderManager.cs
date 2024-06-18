using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETrade
{
    public class OrderManager
    {
        // Event tanımı
        public event OrderCompletedEventHandler OrderCompleted;

        // Siparişi tamamlayan metot
        public void CompleteOrder(int orderId, string customerEmail, List<string> products)
        {
            // Sipariş tamamlandığında yapılacak işlemler
            Console.WriteLine($"Order {orderId} has been completed.");

            // Event'i tetikle
            OnOrderCompleted(new OrderEventArgs(orderId, customerEmail, products));
        }

        // Event'i tetikleyen korumalı sanal metot
        protected virtual void OnOrderCompleted(OrderEventArgs e)
        {
            OrderCompleted?.Invoke(this, e);
        }
    }

}
