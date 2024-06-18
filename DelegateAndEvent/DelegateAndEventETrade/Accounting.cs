using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.DelegateAndEventETrade
{
    public class Accounting
    {
        public void OnOrderCompleted(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Generating invoice for order {e.OrderId}.");
        }
    }

}
