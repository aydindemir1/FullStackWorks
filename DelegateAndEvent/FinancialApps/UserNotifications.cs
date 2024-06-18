using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.FinancialApps
{
    public class UserNotifications
    {
        public void OnBalanceChanged(object sender, BalanceEventArgs e)
        {
            Console.WriteLine($"Balance changed: New balance is {e.Balance:C}.");
        }

        public void OnLowBalance(object sender, BalanceEventArgs e)
        {
            Console.WriteLine($"Warning: Low balance. Current balance is {e.Balance:C}.");
        }

        public void OnHighTransaction(object sender, TransactionEventArgs e)
        {
            Console.WriteLine($"High {e.TransactionType} transaction detected: Amount is {e.Amount:C}.");
        }
    }

}
