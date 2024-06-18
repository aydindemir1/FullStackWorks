using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.FinancialApps
{
    public class BalanceEventArgs : EventArgs
    {
        public decimal Balance { get; set; }

        public BalanceEventArgs(decimal balance)
        {
            Balance = balance;
        }
    }
}
