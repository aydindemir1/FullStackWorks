// See https://aka.ms/new-console-template for more information
using StackExample;

Console.WriteLine("Hello, World!");




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



// Stack oluşturma ve eleman ekleme
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);

// Stack elemanlarını yazdırma
Console.WriteLine("Stack Elements:");
foreach (int item in stack)
{
    Console.WriteLine(item);
}

// Stack'ten eleman çıkarma
int removedElement = stack.Pop();
Console.WriteLine($"Removed Element: {removedElement}");

// Stack'in en üstündeki elemanı görüntüleme (pop yapmadan)
int topElement = stack.Peek();
Console.WriteLine($"Top Element: {topElement}");




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





// Stack oluşturma ve farklı veri tipleri ekleme
Stack<object> stack1 = new Stack<object>();
stack1.Push("Hello");
stack1.Push(42);
stack1.Push(true);

// Stack elemanlarını yazdırma
Console.WriteLine("Stack with Different Data Types:");
foreach (var item in stack1)
{
    Console.WriteLine(item);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// Stack oluşturma ve kullanıcı tanımlı nesneler ekleme
Stack<Person> stack2 = new Stack<Person>();
stack2.Push(new Person("Alice", 30));
stack2.Push(new Person("Bob", 25));

// Stack elemanlarını yazdırma
Console.WriteLine("Stack with Custom Objects:");
foreach (Person person in stack2)
{
    Console.WriteLine(person);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// Stack oluşturma ve geri alma işlemleri ekleme
Stack<string> undoStack = new Stack<string>();
undoStack.Push("Action1: Open File");
undoStack.Push("Action2: Edit File");
undoStack.Push("Action3: Save File");

// Geri alma işlemi yapma
Console.WriteLine("Performing Undo Operations:");
while (undoStack.Count > 0)
{
    string action = undoStack.Pop();
    Console.WriteLine($"Undo {action}");
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




string expression = "{[()]}";
bool isBalanced = CheckBalancedParentheses(expression);
Console.WriteLine($"Is the expression '{expression}' balanced? {isBalanced}");

static bool CheckBalancedParentheses(string expression)
{
    Stack<char> stack = new Stack<char>();
    foreach (char ch in expression)
    {
        if (ch == '(' || ch == '{' || ch == '[')
        {
            stack.Push(ch);
        }
        else if (ch == ')' || ch == '}' || ch == ']')
        {
            if (stack.Count == 0) return false;

            char open = stack.Pop();
            if (!IsMatchingPair(open, ch)) return false;
        }
    }
    return stack.Count == 0;
}

static bool IsMatchingPair(char open, char close)
{
    return (open == '(' && close == ')') ||
           (open == '{' && close == '}') ||
           (open == '[' && close == ']');
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();




// Stack oluşturma ve tarayıcı geçmişi ekleme
Stack<string> browserHistory = new Stack<string>();
browserHistory.Push("https://example.com");
browserHistory.Push("https://example.com/page1");
browserHistory.Push("https://example.com/page2");

// Tarayıcı geçmişini yazdırma ve geri gitme işlemi yapma
Console.WriteLine("Browser History:");
while (browserHistory.Count > 0)
{
    string url = browserHistory.Pop();
    Console.WriteLine($"Visited: {url}");
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();





int number = 10;
string binaryRepresentation = ConvertToBinary(number);
Console.WriteLine($"Binary representation of {number}: {binaryRepresentation}");

static string ConvertToBinary(int number)
{
    Stack<int> stack = new Stack<int>();
    while (number > 0)
    {
        stack.Push(number % 2);
        number /= 2;
    }

    string binary = string.Empty;
    while (stack.Count > 0)
    {
        binary += stack.Pop().ToString();
    }
    return binary;
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.WriteLine();



int number1 = 5;
int factorial = CalculateFactorial(number);
Console.WriteLine($"Factorial of {number}: {factorial}");

static int CalculateFactorial(int n)
{
    Stack<int> stack = new Stack<int>();
    for (int i = n; i > 1; i--)
    {
        stack.Push(i);
    }

    int result = 1;
    while (stack.Count > 0)
    {
        result *= stack.Pop();
    }
    return result;
}
