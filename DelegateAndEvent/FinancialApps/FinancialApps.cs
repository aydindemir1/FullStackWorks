using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.FinancialApps
{
    // Senaryo 3: Finansal Uygulama
    public class FinancialApps
    {
        static void Main(string[] args)
        {
            // Banka hesabı ve kullanıcı bildirim nesneleri oluşturuluyor
            BankAccount account = new BankAccount(initialBalance: 1000m, minimumBalance: 200m, transactionThreshold: 500m);
            UserNotifications notifications = new UserNotifications();

            // Kullanıcı bildirimleri event'lere abone oluyor
            account.BalanceChanged += notifications.OnBalanceChanged;
            account.LowBalance += notifications.OnLowBalance;
            account.HighTransaction += notifications.OnHighTransaction;

            // İşlemler yapılıyor
            account.Deposit(600m); // Yüksek miktarda para yatırma
            account.Withdraw(50m); // Küçük miktarda para çekme
            account.Withdraw(800m); // Yüksek miktarda para çekme
            account.Withdraw(700m); // Düşük bakiye uyarısı ve başarısız işlem
        }
    }
}
