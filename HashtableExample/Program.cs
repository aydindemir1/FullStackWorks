// See https://aka.ms/new-console-template for more information
using HashtableExample;
using System.Collections;

Console.WriteLine("Hello, World!");



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Hashtable oluşturma ve eleman ekleme
Hashtable hashtable = new Hashtable();
hashtable.Add("id", 101);
hashtable.Add("name", "John Doe");
hashtable.Add("age", 30);

// Hashtable elemanlarını yazdırma
Console.WriteLine("Hashtable Elements:");
foreach (DictionaryEntry entry in hashtable)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}

// Hashtable boyutunu yazdırma
Console.WriteLine($"Hashtable Count: {hashtable.Count}");

// Hashtable'den eleman çıkarma
hashtable.Remove("age");

// Hashtable'deki elemanları tekrar yazdırma
Console.WriteLine("\nHashtable Elements After Removing 'age':");
foreach (DictionaryEntry entry in hashtable)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Hashtable oluşturma ve farklı veri tipleri ekleme
Hashtable hashtable1 = new Hashtable();
hashtable1.Add("isEmployee", true);
hashtable1.Add("salary", 50000.75);
hashtable1.Add("joiningDate", new DateTime(2020, 1, 1));

// Hashtable elemanlarını yazdırma
Console.WriteLine("Hashtable Elements with Different Data Types:");
foreach (DictionaryEntry entry in hashtable1)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// Hashtable oluşturma ve eleman ekleme
Hashtable hashtable2 = new Hashtable();
hashtable2.Add("username", "johndoe");
hashtable2.Add("password", "12345");

// Anahtarın var olup olmadığını kontrol etme
if (hashtable2.ContainsKey("username"))
{
    Console.WriteLine("Username key exists.");
}

// Değerin var olup olmadığını kontrol etme
if (hashtable2.ContainsValue("12345"))
{
    Console.WriteLine("Password value exists.");
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





// Hashtable oluşturma ve eleman ekleme
Hashtable hashtable3 = new Hashtable();
hashtable3.Add("colors", new string[] { "red", "green", "blue" });
hashtable3.Add("numbers", new int[] { 1, 2, 3 });

// Hashtable elemanlarını yazdırma
Console.WriteLine("Hashtable with Array Values:");
foreach (DictionaryEntry entry in hashtable3)
{
    Console.Write($"{entry.Key}: ");
    foreach (var item in (Array)entry.Value)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// Hashtable oluşturma ve eleman ekleme
Hashtable hashtable4 = new Hashtable();
hashtable4.Add("city", "New York");
hashtable4.Add("country", "USA");

// Anahtar ile değer elde etme
string city = (string)hashtable4["city"];
Console.WriteLine($"City: {city}");

// Anahtar ile değer güncelleme
hashtable4["city"] = "Los Angeles";
Console.WriteLine($"Updated City: {hashtable4["city"]}");




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// Hashtable oluşturma ve nesneler ekleme
Hashtable hashtable5 = new Hashtable();
hashtable5.Add("car1", new Car { Make = "Toyota", Model = "Corolla" });
hashtable5.Add("car2", new Car { Make = "Honda", Model = "Civic" });

// Hashtable elemanlarını yazdırma
Console.WriteLine("Hashtable with Car Objects:");
foreach (DictionaryEntry entry in hashtable5)
{
    Car car = (Car)entry.Value;
    Console.WriteLine($"{entry.Key}: {car.Make} {car.Model}");
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





// Hashtable oluşturma ve kullanıcı tanımlı nesneler ekleme
Hashtable hashtable6 = new Hashtable();
hashtable6.Add(1, new Person("Alice", 30));
hashtable6.Add(2, new Person("Bob", 25));

// Hashtable elemanlarını yazdırma
Console.WriteLine("Hashtable with Custom Objects:");
foreach (DictionaryEntry entry in hashtable6)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}