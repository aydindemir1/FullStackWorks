// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// Queue oluşturma
Queue<string> queue = new Queue<string>();

// Eleman ekleme
queue.Enqueue("Alice");
queue.Enqueue("Bob");
queue.Enqueue("Charlie");

// Elemanları ekrana yazdırma
foreach (var item in queue)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue1 = new Queue<string>();
queue1.Enqueue("Alice");
queue1.Enqueue("Bob");
queue1.Enqueue("Charlie");

// Eleman çıkarma
string removedItem = queue1.Dequeue();
Console.WriteLine("Removed item: " + removedItem);

// Kalan elemanları ekrana yazdırma
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




Queue<string> queue2 = new Queue<string>();
queue2.Enqueue("Alice");
queue2.Enqueue("Bob");
queue2.Enqueue("Charlie");

// İlk elemanı görüntüleme
string firstItem = queue2.Peek();
Console.WriteLine("First item: " + firstItem);





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue3 = new Queue<string>();
queue3.Enqueue("Alice");
queue3.Enqueue("Bob");
queue3.Enqueue("Charlie");

// Elemanın var olup olmadığını kontrol etme
bool containsBob = queue3.Contains("Bob");
Console.WriteLine("Contains Bob: " + containsBob);




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





Queue<string> queue4 = new Queue<string>();
queue4.Enqueue("Alice");
queue4.Enqueue("Bob");
queue4.Enqueue("Charlie");

// Queue'yu temizleme
queue4.Clear();
Console.WriteLine("Queue count after clearing: " + queue4.Count);





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue5 = new Queue<string>();
queue5.Enqueue("Alice");
queue5.Enqueue("Bob");
queue5.Enqueue("Charlie");

// Queue'yu diziye dönüştürme
string[] array = queue5.ToArray();

// Diziyi ekrana yazdırma
foreach (var item in array)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





Queue<string> queue6 = new Queue<string>();
queue6.Enqueue("Alice");
queue6.Enqueue("Bob");
queue6.Enqueue("Charlie");

// Eleman sayısını öğrenme
int count = queue6.Count;
Console.WriteLine("Number of items in queue: " + count);





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue7 = new Queue<string>();

// Birden fazla eleman ekleme
string[] names = { "Alice", "Bob", "Charlie" };
foreach (var name in names)
{
    queue7.Enqueue(name);
}

// Elemanları ekrana yazdırma
foreach (var item in queue7)
{
    Console.WriteLine(item);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue8 = new Queue<string>();
queue8.Enqueue("Alice");
queue8.Enqueue("Bob");
queue8.Enqueue("Charlie");

// LINQ kullanarak filtreleme
var filteredQueue = queue8.Where(name => name.StartsWith("A"));

// Elemanları ekrana yazdırma
foreach (var item in filteredQueue)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue9 = new Queue<string>();
queue9.Enqueue("Alice");
queue9.Enqueue("Bob");
queue9.Enqueue("Charlie");

// Queue'daki elemanları kopyalama
Queue<string> copyQueue = new Queue<string>(queue9);

// Kopyalanan elemanları ekrana yazdırma
foreach (var item in copyQueue)
{
    Console.WriteLine(item);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue10 = new Queue<string>();
queue10.Enqueue("Alice");
queue10.Enqueue("Bob");
queue10.Enqueue("Charlie");

// For döngüsü ile elemanları görüntüleme
for (int i = 0; i < queue10.Count; i++)
{
    Console.WriteLine(queue10.ElementAt(i));
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue11 = new Queue<string>();
queue11.Enqueue("Alice");
queue11.Enqueue("Bob");

// Eleman ekleyip çıkarma
queue11.Enqueue("Charlie");
string removedItem11 = queue11.Dequeue();

// Kalan elemanları ekrana yazdırma
foreach (var item in queue11)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





Queue<string> queue12 = new Queue<string>();
queue12.Enqueue("Alice");
queue12.Enqueue("Bob");
queue12.Enqueue("Charlie");

// Eleman arama
bool hasCharlie = queue12.Contains("Charlie");
Console.WriteLine("Queue contains Charlie: " + hasCharlie);





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





Queue<string> queue13 = new Queue<string>();
queue13.Enqueue("Alice");
queue13.Enqueue("Bob");
queue13.Enqueue("Charlie");

// Elemanları yazdırma ve boşaltma
while (queue13.Count > 0)
{
    string item = queue13.Dequeue();
    Console.WriteLine(item);
}

Console.WriteLine("Queue count after emptying: " + queue13.Count);





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue14 = new Queue<string>();
queue14.Enqueue("Alice");
queue14.Enqueue("Bob");
queue14.Enqueue("Charlie");

Queue<string> queue15 = new Queue<string>();

// Elemanları başka bir Queue'ya taşıma
while (queue14.Count > 0)
{
    string item = queue14.Dequeue();
    queue15.Enqueue(item);
}

// Yeni Queue'daki elemanları ekrana yazdırma
foreach (var item in queue15)
{
    Console.WriteLine(item);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue16 = new Queue<string>();
queue16.Enqueue("Alice");
queue16.Enqueue("Bob");
queue16.Enqueue("Charlie");

// Queue elemanlarını listeye dönüştürme
List<string> list = queue16.ToList();

// Listeyi ekrana yazdırma
foreach (var item in list)
{
    Console.WriteLine(item);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Queue<string> queue17 = new Queue<string>();
queue17.Enqueue("Alice");
queue17.Enqueue("Bob");
queue17.Enqueue("Charlie");

// LINQ sorgusu yapma
var result = queue17.Where(name => name.Contains('o'));

// Sonuçları ekrana yazdırma
foreach (var item in result)
{
    Console.WriteLine(item);
}