using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.FinancialApps
{
    public class BankAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                balance = value;
                OnBalanceChanged(new BalanceEventArgs(balance));
                if (balance < MinimumBalance)
                {
                    OnLowBalance(new BalanceEventArgs(balance));
                }
            }
        }

        public decimal MinimumBalance { get; set; }
        public decimal TransactionThreshold { get; set; }

        // BalanceChanged ve LowBalance event'leri
        public event BalanceEventHandler BalanceChanged;
        public event BalanceEventHandler LowBalance;

        // HighTransaction event'i
        public event TransactionEventHandler HighTransaction;

        public BankAccount(decimal initialBalance, decimal minimumBalance, decimal transactionThreshold)
        {
            Balance = initialBalance;
            MinimumBalance = minimumBalance;
            TransactionThreshold = transactionThreshold;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            if (amount > TransactionThreshold)
            {
                OnHighTransaction(new TransactionEventArgs(amount, "Deposit"));
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                if (amount > TransactionThreshold)
                {
                    OnHighTransaction(new TransactionEventArgs(amount, "Withdrawal"));
                }
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        protected virtual void OnBalanceChanged(BalanceEventArgs e)
        {
            BalanceChanged?.Invoke(this, e);
        }

        protected virtual void OnLowBalance(BalanceEventArgs e)
        {
            LowBalance?.Invoke(this, e);
        }

        protected virtual void OnHighTransaction(TransactionEventArgs e)
        {
            HighTransaction?.Invoke(this, e);
        }
    }

}
