// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// SortedList oluşturma
SortedList<int, string> students = new SortedList<int, string>();

// Eleman ekleme
students.Add(3, "Charlie");
students.Add(1, "Alice");
students.Add(2, "Bob");

// Elemanları ekrana yazdırma
foreach (var student in students)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





// Başlangıç değerleri ile SortedList oluşturma
var students1 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Elemanları ekrana yazdırma
foreach (var student in students1)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students2 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Eleman silme
students2.Remove(2);

// Elemanları ekrana yazdırma
foreach (var student in students2)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();






var students3 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Değeri güncelleme
students3[2] = "Bobby";

// Elemanları ekrana yazdırma
foreach (var student in students3)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}






Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students4 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Anahtarın var olup olmadığını kontrol etme
bool hasStudent = students4.ContainsKey(2);
Console.WriteLine("Contains key 2: " + hasStudent);





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students5 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Değer elde etme
if (students5.TryGetValue(2, out string name))
{
    Console.WriteLine("Student with ID 2: " + name);
}
else
{
    Console.WriteLine("Student with ID 2 not found.");
}






Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students6 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Tüm anahtarları listeleme
foreach (var key in students6.Keys)
{
    Console.WriteLine("Key: " + key);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();






var students7 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Tüm değerleri listeleme
foreach (var value in students7.Values)
{
    Console.WriteLine("Value: " + value);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students8 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// SortedList'i temizleme
students8.Clear();
Console.WriteLine("SortedList count after clearing: " + students8.Count);





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




var students9 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// LINQ kullanarak filtreleme
var filteredStudents = students9.Where(s => s.Value.StartsWith("A"));

// Elemanları ekrana yazdırma
foreach (var student in filteredStudents)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




var students10 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Eleman sayısını öğrenme
int count = students10.Count;
Console.WriteLine("Number of students: " + count);






Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students11 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// SortedList içeriğini listeye kopyalama
var studentList = students11.ToList();

// Elemanları ekrana yazdırma
foreach (var student in studentList)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students12 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Belirli bir anahtarı bulma
if (students12.ContainsKey(2))
{
    Console.WriteLine("Student with ID 2 exists.");
}
else
{
    Console.WriteLine("Student with ID 2 does not exist.");
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students13 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Belirli bir değeri bulma
if (students13.ContainsValue("Charlie"))
{
    Console.WriteLine("Student named Charlie exists.");
}
else
{
    Console.WriteLine("Student named Charlie does not exist.");
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students15 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// KeyValuePair kullanarak elemanları listeleme
foreach (KeyValuePair<int, string> student in students15)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students16 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// SortedList'i diziye dönüştürme
KeyValuePair<int, string>[] studentArray = students16.ToArray();

// Elemanları ekrana yazdırma
foreach (var student in studentArray)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




var students17 = new SortedList<int, string>
        {
            { 3, "Charlie" },
            { 1, "Alice" },
            { 2, "Bob" }
        };

// Belirli bir şartla elemanları silme
var keysToRemove = students17.Where(kvp => kvp.Value.StartsWith("C")).Select(kvp => kvp.Key).ToList();

foreach (var key in keysToRemove)
{
    students.Remove(key);
}

// Elemanları ekrana yazdırma
foreach (var student in students17)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}