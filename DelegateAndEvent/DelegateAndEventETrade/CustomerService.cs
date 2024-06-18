using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETrade
{
    public class CustomerService
    {
        public void OnOrderCompleted(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Sending email to customer {e.CustomerEmail} about order {e.OrderId}.");
        }
    }

}
