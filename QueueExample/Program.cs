// See https://aka.ms/new-console-template for more information
using QueueExample;

Console.WriteLine("Hello, World!");


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Queue oluşturma ve eleman ekleme
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

// Queue elemanlarını yazdırma
Console.WriteLine("Queue Elements:");
foreach (int item in queue)
{
    Console.WriteLine(item);
}

// Queue'den eleman çıkarma
int removedElement = queue.Dequeue();
Console.WriteLine($"Removed Element: {removedElement}");

// Queue'nin en önündeki elemanı görüntüleme (dequeue yapmadan)
int frontElement = queue.Peek();
Console.WriteLine($"Front Element: {frontElement}");



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Queue oluşturma ve farklı veri tipleri ekleme
Queue<object> queue1 = new Queue<object>();
queue1.Enqueue("Hello");
queue1.Enqueue(42);
queue1.Enqueue(true);

// Queue elemanlarını yazdırma
Console.WriteLine("Queue with Different Data Types:");
foreach (var item in queue1)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Queue oluşturma ve iş emirleri ekleme
Queue<string> jobQueue = new Queue<string>();
jobQueue.Enqueue("Job1: Process Order");
jobQueue.Enqueue("Job2: Send Email");
jobQueue.Enqueue("Job3: Generate Report");

// İş emirlerini sırayla işleme
Console.WriteLine("Processing Job Queue:");
while (jobQueue.Count > 0)
{
    string job = jobQueue.Dequeue();
    Console.WriteLine($"Processing {job}");
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// Dizi oluşturma ve Queue'ya ekleme
string[] tasks = { "Task1", "Task2", "Task3" };
Queue<string> taskQueue = new Queue<string>(tasks);

// Queue elemanlarını yazdırma
Console.WriteLine("Queue from Array:");
foreach (var task in taskQueue)
{
    Console.WriteLine(task);
}

// Queue'ya yeni eleman ekleme
taskQueue.Enqueue("Task4");
taskQueue.Enqueue("Task5");

// Queue elemanlarını tekrar yazdırma
Console.WriteLine("\nQueue after Adding New Tasks:");
foreach (var task in taskQueue)
{
    Console.WriteLine(task);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Queue oluşturma ve zamanlanmış görevler ekleme
Queue<string> scheduler = new Queue<string>();
scheduler.Enqueue("Task1: Run Backup");
scheduler.Enqueue("Task2: Update Software");
scheduler.Enqueue("Task3: Send Reports");

// Görevleri belirli aralıklarla işleme
Console.WriteLine("Processing Scheduled Tasks:");
while (scheduler.Count > 0)
{
    string task = scheduler.Dequeue();
    Console.WriteLine($"Executing {task}");
    Thread.Sleep(2000); // Görevler arasında 2 saniye bekleme
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





// Queue oluşturma ve web istekleri ekleme
Queue<WebRequest> requestQueue = new Queue<WebRequest>();
requestQueue.Enqueue(new WebRequest("https://example.com/api/data", "GET"));
requestQueue.Enqueue(new WebRequest("https://example.com/api/data", "POST"));
requestQueue.Enqueue(new WebRequest("https://example.com/api/data", "DELETE"));

// Web isteklerini işleme
Console.WriteLine("Processing Web Requests:");
while (requestQueue.Count > 0)
{
    WebRequest request = requestQueue.Dequeue();
    Console.WriteLine($"Sending {request}");
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// Queue oluşturma ve müşteri ekleme
Queue<Customer> customerQueue = new Queue<Customer>();
customerQueue.Enqueue(new Customer("John Doe"));
customerQueue.Enqueue(new Customer("Jane Smith"));
customerQueue.Enqueue(new Customer("Sam Johnson"));

// Müşteri hizmetleri kuyruğunu işleme
Console.WriteLine("Processing Customer Service Queue:");
while (customerQueue.Count > 0)
{
    Customer customer = customerQueue.Dequeue();
    Console.WriteLine($"Serving Customer: {customer}");
}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Queue oluşturma ve kullanıcı tanımlı nesneler ekleme
Queue<Person> queue3 = new Queue<Person>();
queue3.Enqueue(new Person("Alice", 30));
queue3.Enqueue(new Person("Bob", 25));

// Queue elemanlarını yazdırma
Console.WriteLine("Queue with Custom Objects:");
foreach (Person person in queue3)
{
    Console.WriteLine(person);
}