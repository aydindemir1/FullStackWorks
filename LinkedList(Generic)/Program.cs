// See https://aka.ms/new-console-template for more information
using LinkedList_Generic_;

Console.WriteLine("Hello, World!");





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




LinkedList<int> numbers = new LinkedList<int>();

// Eleman ekleme
numbers.AddLast(1);
numbers.AddLast(2);
numbers.AddLast(3);

// İlk ve son elemanları yazdırma
Console.WriteLine("İlk eleman: " + numbers.First.Value);
Console.WriteLine("Son eleman: " + numbers.Last.Value);

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




LinkedList<string> words = new LinkedList<string>();

// Başa ekleme
words.AddFirst("World");
words.AddFirst("Hello");

// Ortaya ekleme
LinkedListNode<string> node = words.Find("Hello");
words.AddAfter(node, "Beautiful");

// Sona ekleme
words.AddLast("!");

// Eleman çıkarma
words.Remove("Beautiful");

// Elemanları yazdırma
foreach (var word in words)
{
    Console.WriteLine(word);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




LinkedList<int> numbers1 = new LinkedList<int>();
numbers1.AddLast(1);
numbers1.AddLast(2);
numbers1.AddLast(3);

// Ters sırada yazdırma
LinkedListNode<int> node1 = numbers1.Last;
while (node1 != null)
{
    Console.WriteLine(node1.Value);
    node1 = node1.Previous;
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





LinkedList<string> words1 = new LinkedList<string>();
words1.AddLast("apple");
words1.AddLast("banana");
words1.AddLast("cherry");

// Eleman arama
LinkedListNode<string> node2 = words1.Find("banana");
if (node2 != null)
{
    Console.WriteLine("Bulundu: " + node2.Value);
}
else
{
    Console.WriteLine("Bulunamadı.");
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




LinkedList<int> numbers2 = new LinkedList<int>();
LinkedListNode<int> first = new LinkedListNode<int>(1);
LinkedListNode<int> second = new LinkedListNode<int>(2);
LinkedListNode<int> third = new LinkedListNode<int>(3);

numbers2.AddLast(first);
numbers2.AddLast(second);
numbers2.AddLast(third);

// Döngü oluşturma (tehlikeli, sonsuz döngüye neden olabilir)
//third.Next = first;
//third.Next = second;

// Döngü kontrolü
Console.WriteLine(ContainsLoop(numbers2) ? "Döngü var." : "Döngü yok.");

static bool ContainsLoop(LinkedList<int> list)
{
    LinkedListNode<int> slow = list.First;
    LinkedListNode<int> fast = list.First;

    while (fast != null && fast.Next != null)
    {
        slow = slow.Next;
        fast = fast.Next.Next;

        if (slow == fast)
        {
            return true;
        }
    }
    return false;
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





//LinkedList<int> numbers3 = new LinkedList<int>();
//numbers3.AddLast(10);
//numbers3.AddLast(5);
//numbers3.AddLast(15);
//numbers3.AddLast(3);
//numbers3.AddLast(7);

//TreeNode root = ConvertToBST(numbers3);
//InOrderTraversal(root);

//static TreeNode ConvertToBST(LinkedList<int> list)
//{
//    return ConvertToBST(list.First, null);
//}

//static TreeNode ConvertToBST(LinkedListNode<int> start, LinkedListNode<int> end)
//{
//    if (start == end) return null;

//    LinkedListNode<int> mid = GetMiddle(start, end);
//    TreeNode node = new TreeNode(mid.Value);
//    node.Left = ConvertToBST(start, mid);
//    node.Right = ConvertToBST(mid.Next, end);
//    return node;
//}

//static LinkedListNode<int> GetMiddle(LinkedListNode<int> start, LinkedListNode<int> end)
//{
//    LinkedListNode<int> slow = start;
//    LinkedListNode<int> fast = start;

//    while (fast != end && fast.Next != end)
//    {
//        slow = slow.Next;
//        fast = fast.Next.Next;
//    }

//    return slow;
//}

//static void InOrderTraversal(TreeNode root)
//{
//    if (root == null) return;

//    InOrderTraversal(root.Left);
//    Console.WriteLine(root.Value);
//    InOrderTraversal(root.Right);
//}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




LinkedList<int> stack = new LinkedList<int>();

// Yığına ekleme
Push(stack, 1);
Push(stack, 2);
Push(stack, 3);

// Yığından çıkarma
Console.WriteLine("Pop: " + Pop(stack));
Console.WriteLine("Pop: " + Pop(stack));
Console.WriteLine("Pop: " + Pop(stack));

static void Push(LinkedList<int> stack, int value)
{
    stack.AddFirst(value);
}

static int Pop(LinkedList<int> stack)
{
    if (stack.Count == 0)
        throw new InvalidOperationException("Yığın boş.");

    int value = stack.First.Value;
    stack.RemoveFirst();
    return value;
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




//LinkedList<int> numbers4 = new LinkedList<int>();
//numbers4.AddLast(1);
//numbers4.AddLast(2);
//numbers4.AddLast(3);

//// Döngüsel liste oluşturma
////numbers4.Last.Next = numbers4.First;

//// Döngüsel listeyi yazdırma
//PrintCircularList(numbers4, 6);  // 6 eleman yazdır

//static void PrintCircularList(LinkedList<int> list, int count)
//{
//    LinkedListNode<int> current = list.First;
//    for (int i = 0; i < count; i++)
//    {
//        Console.WriteLine(current.Value);
//        current = current.Next;
//    }
//}
