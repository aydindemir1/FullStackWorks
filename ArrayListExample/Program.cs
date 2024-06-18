// See https://aka.ms/new-console-template for more information
using ArrayListExample;
using System.Collections;

Console.WriteLine("Hello, World!");





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// ArrayList oluşturma ve eleman ekleme
ArrayList arrayList = new ArrayList();
arrayList.Add("C#");
arrayList.Add(3.14);
arrayList.Add(true);
arrayList.Add(42);

// ArrayList elemanlarını yazdırma
Console.WriteLine("ArrayList Elements:");
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

// ArrayList boyutunu yazdırma
Console.WriteLine($"ArrayList Count: {arrayList.Count}");

// ArrayList'ten eleman çıkarma
arrayList.Remove(true);

// ArrayList'teki elemanları sıralama (sıralama için tip uyumsuzluk hatası verebilir)
//arrayList.Sort(); // hata veriyor.

// ArrayList'teki elemanları tekrar yazdırma
Console.WriteLine("\nArrayList Elements After Removing and Sorting:");
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// ArrayList içinde farklı veri türleri
ArrayList mixedTypes = new ArrayList();
mixedTypes.Add("Hello");
mixedTypes.Add(42);
mixedTypes.Add(DateTime.Now);

// ArrayList elemanlarını döngü ile yazdırma
foreach (var item in mixedTypes)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





// ArrayList'ten dizi oluşturma
ArrayList arrayList1 = new ArrayList();
arrayList1.Add("C#");
arrayList1.Add("Java");
arrayList1.Add("Python");

string[] languages = (string[])arrayList1.ToArray(typeof(string));

// Diziyi döngü ile yazdırma
foreach (var language in languages)
{
    Console.WriteLine(language);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();


// ArrayList oluşturma ve eleman ekleme
ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5 };

// Eleman ekleme
numbers.Add(6);

// Eleman çıkarma
numbers.Remove(3);

// Elemanları sıralama (tip uyumsuzluk hatası verebilir)
numbers.Sort();

// Elemanları dizide toplama
int[] nums = (int[])numbers.ToArray(typeof(int));

// Diziyi döngü ile yazdırma
foreach (var num in nums)
{
    Console.WriteLine(num);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// ArrayList oluşturma ve eleman ekleme
ArrayList numbers1 = new ArrayList() { 1, 2, 3, 4, 5 };

// LINQ ile sorgulama yapma
var evenNumbers = numbers1.Cast<int>().Where(n => n % 2 == 0).ToList();

// Sonuçları yazdırma
foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// ArrayList ile nesne kullanımı
ArrayList persons = new ArrayList();
persons.Add(new Person("Alice", 30));
persons.Add(new Person("Bob", 25));
persons.Add(new Person("Charlie", 35));

// ArrayList'teki nesneleri döngü ile yazdırma
foreach (Person person in persons)
{
    Console.WriteLine(person);
}



