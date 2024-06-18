// See https://aka.ms/new-console-template for more information
using SOLID.DIP;
using SOLID.ISP;
using SOLID.LSP;
using SOLID.OCP;
using SOLID.SRP;

Console.WriteLine("Hello, World!");


// Dependency Inversion Principle (Bağımlılıkların Tersine Çevrilmesi Prensibi)
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine("Dependency Inversion Principle (Bağımlılıkların Tersine Çevrilmesi Prensibi) ");
Console.WriteLine();

IMessageService emailService = new EmailService();
Notification emailNotification = new Notification(emailService);
emailNotification.Notify("This is an email notification.");

IMessageService smsService = new SmsService();
Notification smsNotification = new Notification(smsService);
smsNotification.Notify("This is an SMS notification.");

// Interface Segregation Principle (Arayüz Ayrımı Prensibi)
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine("Interface Segregation Principle (Arayüz Ayrımı Prensibi) ");
Console.WriteLine();

IWorkable worker = new Worker();
IWorkable robot = new Robot();

worker.Work();
robot.Work();

IEatable eater = new Worker();
eater.Eat();

// Liskov Substitution Principle (Liskov Yerine Geçme Prensibi)
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine("Liskov Substitution Principle (Liskov Yerine Geçme Prensibi) ");
Console.WriteLine();
List<IBird> birds = new List<IBird>
        {
            new Sparrow(),
            new Ostrich()
        };

foreach (var bird in birds)
{
    bird.Eat();
}

List<IFlyingBird> flyingBirds = new List<IFlyingBird>
        {
            new Sparrow()
        };

foreach (var flyingBird in flyingBirds)
{
    flyingBird.Fly();
}

// Open/Closed Principle (Açık/Kapalı Prensibi)
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine("Open/Closed Principle (Açık/Kapalı Prensibi) ");
Console.WriteLine();
IEmployee permanentEmployee = new PermanentEmployee("John Doe", 50000);
IEmployee contractEmployee = new ContractEmployee("Jane Smith", 40000);

BonusCalculator bonusCalculator = new BonusCalculator();

Console.WriteLine($"Permanent Employee Bonus: {bonusCalculator.Calculate(permanentEmployee)}");
Console.WriteLine($"Contract Employee Bonus: {bonusCalculator.Calculate(contractEmployee)}");

//  Single Responsibility Principle (Tek Sorumluluk Prensibi)
Console.WriteLine("----------------------------------");
Console.WriteLine();
Console.WriteLine("Single Responsibility Principle (Tek Sorumluluk Prensibi)");
Console.WriteLine();
Employee employee = new Employee("John Doe", "john.doe@example.com", 50000);
EmployeeRepository repository = new EmployeeRepository();
EmployeeReportGenerator reportGenerator = new EmployeeReportGenerator();

repository.SaveToDatabase(employee);
reportGenerator.GenerateReport(employee);

