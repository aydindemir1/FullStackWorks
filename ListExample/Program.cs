// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Boş bir liste oluşturma
List<int> numbers = new List<int>();

// Listeye eleman ekleme
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

// Elemanları ekrana yazdırma
foreach (int number in numbers)
{
    Console.WriteLine(number);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Başlangıç değerleri ile liste oluşturma
List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

// Elemanları ekrana yazdırma
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




List<string> fruits1 = new List<string> { "Apple", "Banana", "Cherry" };

// Eleman silme
fruits1.Remove("Banana");

// Elemanları ekrana yazdırma
foreach (string fruit in fruits1)
{
    Console.WriteLine(fruit);
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



List<string> fruits3 = new List<string> { "Apple", "Banana", "Cherry" };

// İndeksteki elemanı güncelleme
fruits3[1] = "Blueberry";

// Elemanları ekrana yazdırma
foreach (string fruit in fruits3)
{
    Console.WriteLine(fruit);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };

// Elemanın var olup olmadığını kontrol etme
bool containsThree = numbers1.Contains(3);
Console.WriteLine("Contains 3: " + containsThree);




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };

// Listeyi ters çevirme
numbers2.Reverse();

// Elemanları ekrana yazdırma
foreach (int number in numbers2)
{
    Console.WriteLine(number);
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




List<int> numbers3 = new List<int> { 5, 3, 1, 4, 2 };

// Listeyi sıralama
numbers3.Sort();

// Elemanları ekrana yazdırma
foreach (int number in numbers3)
{
    Console.WriteLine(number);
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5 };

// Linq ile filtreleme
var evenNumbers = numbers4.Where(n => n % 2 == 0);

// Elemanları ekrana yazdırma
foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();






List<int> numbers5 = new List<int> { 1, 2, 3, 4, 5 };

// Listeyi diziye dönüştürme
int[] numberArray = numbers5.ToArray();

// Elemanları ekrana yazdırma
foreach (int number in numberArray)
{
    Console.WriteLine(number);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




List<int> numbers6 = new List<int> { 1, 2, 3 };
int[] moreNumbers = new int[] { 4, 5, 6 };

// Listeye dizi ekleme
numbers6.AddRange(moreNumbers);

// Elemanları ekrana yazdırma
foreach (int number in numbers6)
{
    Console.WriteLine(number);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





List<int> numbers7 = new List<int> { 1, 2, 3, 4, 5 };

// Listeyi temizleme
numbers7.Clear();

// Eleman sayısını ekrana yazdırma
Console.WriteLine("Count after clearing: " + numbers7.Count);




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };

// Belirli bir şartla filtreleme
List<string> filteredNames = names.FindAll(name => name.Length > 3);

// Elemanları ekrana yazdırma
foreach (string name in filteredNames)
{
    Console.WriteLine(name);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



List<int> numbers8 = new List<int> { 1, 2, 3, 4, 5 };

// Belirli bir elemanın indeksini bulma
int index = numbers8.IndexOf(3);
Console.WriteLine("Index of 3: " + index);



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



List<string> names1 = new List<string> { "Alice", "Bob", "Charlie", "David" };

// Belirli bir şartla eleman bulma
string foundName = names1.Find(name => name.StartsWith("C"));
Console.WriteLine("Found name: " + foundName);



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




List<int> list1 = new List<int> { 1, 2, 3 };
List<int> list2 = new List<int> { 4, 5, 6 };

// Listeleri birleştirme
list1.AddRange(list2);

// Elemanları ekrana yazdırma
foreach (int number in list1)
{
    Console.WriteLine(number);
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




List<int> numbers9 = new List<int> { 1, 2, 3, 4, 5 };

// Belirli bir şartla elemanları silme
numbers9.RemoveAll(n => n % 2 == 0);

// Elemanları ekrana yazdırma
foreach (int number in numbers9)
{
    Console.WriteLine(number);
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



List<int> originalList = new List<int> { 1, 2, 3, 4, 5 };

// Listeyi kopyalama
List<int> copyList = new List<int>(originalList);

// Elemanları ekrana yazdırma
foreach (int number in copyList)
{
    Console.WriteLine(number);
}