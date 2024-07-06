// See https://aka.ms/new-console-template for more information
using ExtensionsMethods;


Console.WriteLine(" ICollection için Extension Method:");
Console.WriteLine();
Console.WriteLine();



// List<int> türündeki koleksiyona eleman ekleme
List<int> intList = new List<int> { 1, 2, 3 };
intList.AddRange(new int[] { 4, 5, 6 });
Console.WriteLine("After AddRange: " + string.Join(", ", intList));

// List<int> türündeki koleksiyondan eleman çıkarma
intList.RemoveRange(new int[] { 2, 3 });
Console.WriteLine("After RemoveRange: " + string.Join(", ", intList));

// HashSet<string> türündeki koleksiyona eleman ekleme
HashSet<string> stringSet = new HashSet<string> { "Apple", "Banana" };
stringSet.AddRange(new string[] { "Cherry", "Date" });
Console.WriteLine("After AddRange: " + string.Join(", ", stringSet));

// HashSet<string> türündeki koleksiyondan eleman çıkarma
stringSet.RemoveRange(new string[] { "Apple", "Cherry" });
Console.WriteLine("After RemoveRange: " + string.Join(", ", stringSet));

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("IEnumerable için Extension Method:");
Console.WriteLine();
Console.WriteLine();


// int türündeki koleksiyondan belirli bir değerden büyük olanları filtreleme
IEnumerable<int> intList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
var filteredInts = intList1.WhereGreaterThan(3);
Console.WriteLine("Filtered int list: " + string.Join(", ", filteredInts));

// double türündeki koleksiyondan belirli bir değerden büyük olanları filtreleme
IEnumerable<double> doubleList = new List<double> { 1.1, 2.2, 3.3, 4.4, 5.5 };
var filteredDoubles = doubleList.WhereGreaterThan(3.3);
Console.WriteLine("Filtered double list: " + string.Join(", ", filteredDoubles));

// string türündeki koleksiyondan belirli bir değerden büyük olanları filtreleme (alfabetik)
IEnumerable<string> stringList = new List<string> { "apple", "banana", "cherry", "date" };
var filteredStrings = stringList.WhereGreaterThan("banana");
Console.WriteLine("Filtered string list: " + string.Join(", ", filteredStrings));


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("List için Extension Method:");
Console.WriteLine();
Console.WriteLine();


// List<int> türündeki koleksiyonu ters sıraya çevirme
List<int> intList2 = new List<int> { 1, 2, 3, 4, 5 };
intList2.ReverseOrder();
Console.WriteLine("Reversed int list: " + string.Join(", ", intList2));

// List<string> türündeki koleksiyonu ters sıraya çevirme
List<string> stringList2 = new List<string> { "apple", "banana", "cherry", "date" };
stringList2.ReverseOrder();
Console.WriteLine("Reversed string list: " + string.Join(", ", stringList2));

// List<int> türündeki koleksiyonu belirli bir sıraya göre sıralama (büyükten küçüğe)
intList2.SortBy((x, y) => y.CompareTo(x));
Console.WriteLine("Sorted int list (descending): " + string.Join(", ", intList2));

// List<string> türündeki koleksiyonu belirli bir sıraya göre sıralama (alfabetik olarak ters)
stringList2.SortBy((x, y) => y.CompareTo(x));
Console.WriteLine("Sorted string list (descending): " + string.Join(", ", stringList2));



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Dictionary için Extension Method:");
Console.WriteLine();
Console.WriteLine();


var dictionary = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 }
        };

// GetOrDefault kullanımı
int value = dictionary.GetOrDefault("two");
Console.WriteLine($"Value for 'two': {value}");

value = dictionary.GetOrDefault("four", -1);
Console.WriteLine($"Value for 'four' (default -1): {value}");

// Remove with out param kullanımı
if (dictionary.Remove("two", out int removedValue))
{
    Console.WriteLine($"Removed 'two' with value: {removedValue}");
}
else
{
    Console.WriteLine("Key 'two' not found.");
}

// Sözlükte kalan elemanları yazdırma
Console.WriteLine("Remaining dictionary:");
foreach (var kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

