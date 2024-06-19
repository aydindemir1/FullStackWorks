// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// Stack oluşturma
Stack<string> stack = new Stack<string>();

// Eleman ekleme
stack.Push("Alice");
stack.Push("Bob");
stack.Push("Charlie");

// Elemanları ekrana yazdırma
foreach (var item in stack)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack2 = new Stack<string>();
stack2.Push("Alice");
stack2.Push("Bob");
stack2.Push("Charlie");

// Eleman çıkarma
string poppedItem = stack2.Pop();
Console.WriteLine("Popped item: " + poppedItem);

// Kalan elemanları ekrana yazdırma
foreach (var item in stack2)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack3 = new Stack<string>();
stack3.Push("Alice");
stack3.Push("Bob");
stack3.Push("Charlie");

// En üstteki elemanı görüntüleme
string topItem = stack3.Peek();
Console.WriteLine("Top item: " + topItem);





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack4 = new Stack<string>();
stack4.Push("Alice");
stack4.Push("Bob");
stack4.Push("Charlie");

// Elemanın var olup olmadığını kontrol etme
bool containsBob = stack4.Contains("Bob");
Console.WriteLine("Contains Bob: " + containsBob);




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





Stack<string> stack5 = new Stack<string>();
stack5.Push("Alice");
stack5.Push("Bob");
stack5.Push("Charlie");

// Stack'i temizleme
stack5.Clear();
Console.WriteLine("Stack count after clearing: " + stack5.Count);




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack6 = new Stack<string>();
stack6.Push("Alice");
stack6.Push("Bob");
stack6.Push("Charlie");

// Stack'i diziye dönüştürme
string[] array = stack6.ToArray();

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




Stack<string> stack7 = new Stack<string>();
stack7.Push("Alice");
stack7.Push("Bob");
stack7.Push("Charlie");

// Eleman sayısını öğrenme
int count = stack7.Count;
Console.WriteLine("Number of items in stack: " + count);




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





Stack<string> stack8 = new Stack<string>();

// Birden fazla eleman ekleme
string[] names = { "Alice", "Bob", "Charlie" };
foreach (var name in names)
{
    stack8.Push(name);
}

// Elemanları ekrana yazdırma
foreach (var item in stack8)
{
    Console.WriteLine(item);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack9 = new Stack<string>();
stack9.Push("Alice");
stack9.Push("Bob");
stack9.Push("Charlie");

// LINQ kullanarak filtreleme
var filteredStack = stack9.Where(name => name.StartsWith("A"));

// Elemanları ekrana yazdırma
foreach (var item in filteredStack)
{
    Console.WriteLine(item);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack10 = new Stack<string>();
stack10.Push("Alice");
stack10.Push("Bob");
stack10.Push("Charlie");

// Stack elemanlarını listeye dönüştürme
List<string> list = stack10.ToList();

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




Stack<string> stack11 = new Stack<string>();
stack11.Push("Alice");
stack11.Push("Bob");
stack11.Push("Charlie");

// Stack'teki elemanları kopyalama
Stack<string> copyStack = new Stack<string>(stack11);

// Kopyalanan elemanları ekrana yazdırma
foreach (var item in copyStack)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack12 = new Stack<string>();
stack12.Push("Alice");
stack12.Push("Bob");
stack12.Push("Charlie");

// For döngüsü ile elemanları görüntüleme
for (int i = 0; i < stack12.Count; i++)
{
    Console.WriteLine(stack12.ElementAt(i));
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack13 = new Stack<string>();
stack13.Push("Alice");
stack13.Push("Bob");
stack13.Push("Charlie");

// Eleman arama
bool hasBob = stack13.Contains("Bob");
Console.WriteLine("Stack contains Bob: " + hasBob);




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack14 = new Stack<string>();
stack14.Push("Alice");
stack14.Push("Bob");
stack14.Push("Charlie");

// Elemanları yazdırma ve boşaltma
while (stack14.Count > 0)
{
    string item = stack14.Pop();
    Console.WriteLine(item);
}

Console.WriteLine("Stack count after emptying: " + stack14.Count);





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack15 = new Stack<string>();
stack15.Push("Alice");
stack15.Push("Bob");
stack15.Push("Charlie");

Stack<string> stack16 = new Stack<string>();

// Elemanları başka bir Stack'e taşıma
while (stack15.Count > 0)
{
    string item = stack15.Pop();
    stack16.Push(item);
}

// Yeni Stack'teki elemanları ekrana yazdırma
foreach (var item in stack16)
{
    Console.WriteLine(item);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




Stack<string> stack17 = new Stack<string>();
stack17.Push("Alice");
stack17.Push("Bob");
stack17.Push("Charlie");

// Stack'teki elemanları listeye kopyalama
List<string> list17 = new List<string>(stack);

// Listeyi ekrana yazdırma
foreach (var item in list17)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





Stack<string> stack18 = new Stack<string>();
stack18.Push("Alice");
stack18.Push("Bob");
stack18.Push("Charlie");

// LINQ sorgusu yapma
var result = stack18.Where(name => name.Contains('o'));

// Sonuçları ekrana yazdırma
foreach (var item in result)
{
    Console.WriteLine(item);
}