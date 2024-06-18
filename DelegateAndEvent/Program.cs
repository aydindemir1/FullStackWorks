// See https://aka.ms/new-console-template for more information
using DelegateAndEvent.DelegateAndEventETrade;
using DelegateAndEvent.DelegateAndEventGaming;
using DelegateAndEvent.FinancialApps;

Console.WriteLine("Hello, World!");

Console.WriteLine();
Console.WriteLine("Senaryo 3: Finansal Uygulama");
Console.WriteLine("-------------------");

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

Console.WriteLine();
Console.WriteLine("Senaryo 2: Oyun Geliştirme");
Console.WriteLine("-------------------");

Game game = new Game();

// Oyun başlıyor ve bazı işlemler yapılıyor
game.Player.Health = 80; // Can değişimi
game.Player.Health = 15; // Düşük can uyarısı
game.CurrentEnemy.TakeDamage(30); // Düşmana zarar verme
game.CurrentEnemy.TakeDamage(25); // Düşmanı öldürme




Console.WriteLine();
Console.WriteLine("Senaryo 1: E-Ticaret Sistemi");
Console.WriteLine("-------------------");
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