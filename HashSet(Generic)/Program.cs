// See https://aka.ms/new-console-template for more information
using HashSet_Generic_;
using System.Diagnostics;

Console.WriteLine("Hello, World!");




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





HashSet<int> numbers = new HashSet<int>();

// Eleman ekleme
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

// Aynı elemanı tekrar ekleme (önemsenmez, set'te tekrar olmaz)
numbers.Add(3);

// Eleman sayısı
Console.WriteLine("Eleman sayısı: " + numbers.Count);

// Elemanları yazdırma
foreach (var number in numbers)
{
    Console.WriteLine(number);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();






HashSet<string> fruits = new HashSet<string>
        {
            "Apple",
            "Banana",
            "Cherry"
        };

// Yeni eleman ekleme
fruits.Add("Durian");

// İçerip içermediğini kontrol etme
if (fruits.Contains("Apple"))
{
    Console.WriteLine("Apple set'te mevcut.");
}

// Eleman çıkarma
fruits.Remove("Banana");

// Elemanları yazdırma
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

// Fark işlemi
set1.ExceptWith(set2);

// Sonuçları yazdırma
Console.WriteLine("Set1 - Set2 farkı:");
foreach (var number in set1)
{
    Console.WriteLine(number);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




HashSet<int> set11 = new HashSet<int> { 1, 2, 3, 4 };
HashSet<int> set21 = new HashSet<int> { 3, 4, 5, 6 };

// Kesişim işlemi
set11.IntersectWith(set21);

// Sonuçları yazdırma
Console.WriteLine("Set1 ∩ Set2:");
foreach (var number in set11)
{
    Console.WriteLine(number);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




HashSet<int> set12 = new HashSet<int> { 1, 2, 3, 4 };
HashSet<int> set22 = new HashSet<int> { 3, 4, 5, 6 };

// Birleşim işlemi
set12.UnionWith(set22);

// Sonuçları yazdırma
Console.WriteLine("Set1 ∪ Set2:");
foreach (var number in set12)
{
    Console.WriteLine(number);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




List<int> duplicateList = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
HashSet<int> uniqueSet = new HashSet<int>(duplicateList);

// Sonuçları yazdırma
Console.WriteLine("Benzersiz elemanlar:");
foreach (var number in uniqueSet)
{
    Console.WriteLine(number);
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




int elementCount = 1000000;
List<int> list = new List<int>();
HashSet<int> set = new HashSet<int>();

// Eleman ekleme
for (int i = 0; i < elementCount; i++)
{
    list.Add(i);
    set.Add(i);
}

// Performans testi (List)
Stopwatch sw = Stopwatch.StartNew();
bool contains = list.Contains(elementCount - 1);
sw.Stop();
Console.WriteLine($"List içinde arama süresi: {sw.ElapsedMilliseconds} ms");

// Performans testi (HashSet)
sw.Restart();
contains = set.Contains(elementCount - 1);
sw.Stop();
Console.WriteLine($"HashSet içinde arama süresi: {sw.ElapsedMilliseconds} ms");





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




HashSet<Person> people = new HashSet<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
        };

people.Add(new Person { Name = "Alice", Age = 30 }); // Eklenecek mi?

foreach (var person in people)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}

