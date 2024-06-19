// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Dictionary oluşturma
Dictionary<int, string> students = new Dictionary<int, string>();

// Eleman ekleme
students.Add(1, "Alice");
students.Add(2, "Bob");
students.Add(3, "Charlie");

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




// Başlangıç değerleri ile dictionary oluşturma
var students1 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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



var students2 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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



var students3 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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



var students4 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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



var students5 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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




var students6 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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




var students7 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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




var students8 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };

// Dictionary'yi temizleme
students8.Clear();
Console.WriteLine("Dictionary count after clearing: " + students8.Count);



Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




var students9 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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



var students10 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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





var students11 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };

// Dictionary içeriğini listeye kopyalama
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



var students12 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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



var students13 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
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



var students14 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };

// KeyValuePair kullanarak elemanları listeleme
foreach (KeyValuePair<int, string> student in students14)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





var students15 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };

// Dictionary'yi diziye dönüştürme
KeyValuePair<int, string>[] studentArray = students15.ToArray();

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



var students16 = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };

// Belirli bir şartla elemanları silme
var keysToRemove = students16.Where(kvp => kvp.Value.StartsWith("C")).Select(kvp => kvp.Key).ToList();

foreach (var key in keysToRemove)
{
    students16.Remove(key);
}

// Elemanları ekrana yazdırma
foreach (var student in students16)
{
    Console.WriteLine("ID: {0}, Name: {1}", student.Key, student.Value);
}