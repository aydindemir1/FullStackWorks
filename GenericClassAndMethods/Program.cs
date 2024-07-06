// See https://aka.ms/new-console-template for more information
using GenericClassAndMethods;

Console.WriteLine("Hello, World!");
Console.WriteLine("Veri Depolama (Data Storage):");
Console.WriteLine();

// int veri tipi için DataStore kullanımı
DataStore<int> intStore = new DataStore<int>();
intStore.Add(10);
intStore.Add(20);
intStore.Add(30);
intStore.DisplayAll();

// string veri tipi için DataStore kullanımı
DataStore<string> stringStore = new DataStore<string>();
stringStore.Add("Merhaba");
stringStore.Add("Dünya");
stringStore.DisplayAll();

// farklı veri tipi için DataStore kullanımı
DataStore<double> doubleStore = new DataStore<double>();
doubleStore.Add(10.5);
doubleStore.Add(20.7);
doubleStore.DisplayAll();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Algoritmalar (Algorithms):");
Console.WriteLine();
Console.WriteLine();

// int[] dizisini sıralama
int[] intArray = { 5, 3, 8, 4, 2 };
Sorting.Sort(intArray);
Console.WriteLine("Sorted int array: " + string.Join(", ", intArray));

// string[] dizisini sıralama
string[] stringArray = { "Apple", "Orange", "Banana", "Grape" };
Sorting.Sort(stringArray);
Console.WriteLine("Sorted string array: " + string.Join(", ", stringArray));

// double[] dizisini sıralama
double[] doubleArray = { 3.2, 1.5, 4.8, 2.3 };
Sorting.Sort(doubleArray);
Console.WriteLine("Sorted double array: " + string.Join(", ", doubleArray));


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Veri Dönüşümü (Data Transformation):");
Console.WriteLine();
Console.WriteLine();


// List<string> türündeki veriyi List<int> türüne dönüştürme
List<string> stringList = new List<string> { "1", "2", "3", "4", "5" };
List<int> intList = DataTransformation.ConvertTo(stringList, int.Parse);

Console.WriteLine("Converted int list: " + string.Join(", ", intList));

// List<string> türündeki veriyi List<double> türüne dönüştürme
List<string> doubleStringList = new List<string> { "1.1", "2.2", "3.3", "4.4" };
List<double> doubleList = DataTransformation.ConvertTo(doubleStringList, double.Parse);

Console.WriteLine("Converted double list: " + string.Join(", ", doubleList));