using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.FinancialApps
{
    // Delegate tanımı
    public delegate void TransactionEventHandler(object sender, TransactionEventArgs e);
    public delegate void BalanceEventHandler(object sender, BalanceEventArgs e);

    // Event argümanları için sınıf tanımları
    public class TransactionEventArgs : EventArgs
    {
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }

        public TransactionEventArgs(decimal amount, string transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
        }
    }

   

}
