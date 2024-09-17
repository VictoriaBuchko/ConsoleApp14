// See https://aka.ms/new-console-template for more information

Console.WriteLine("Завдання 1");
Message mess;

mess = ShowMessage;
mess("відпрацювало");

void ShowMessage(string message)
{
    Console.WriteLine("повідомлення: " + message);
}

Console.WriteLine("\nЗавдання 2");
Op add = Add;
Op subtract = Subtract;
Op multiply = Multiply;

Console.WriteLine(add.Invoke(5, 3));
Console.WriteLine(subtract.Invoke(5, 3));
Console.WriteLine(multiply.Invoke(5, 3));
double Add(double x, double y)
{
    return x + y;
}

double Subtract(double x, double y)
{
    return x - y;
}

double Multiply(double x, double y)
{
    return x * y;
}

Console.WriteLine("\nЗавдання 3");
Predicate<int> checkEven = IsEven;
Predicate<int> checkOdd = IsOdd;
Predicate<int> checkPrime = IsPrime;
Predicate<int> checkFibonacci = IsFibonacci;

Console.Write("Введіть число: ");
int number = int.Parse(Console.ReadLine());


Console.WriteLine($"{number} парне: {checkEven.Invoke(number)}");
Console.WriteLine($"{number} непарне: {checkOdd.Invoke(number)}");
Console.WriteLine($"{number} просте: {checkPrime.Invoke(number)}");
Console.WriteLine($"{number} число Фібоначчі: {checkFibonacci.Invoke(number)}");

bool IsEven(int number)
{
    return number % 2 == 0;
}


bool IsOdd(int number)
{
    return number % 2 != 0;
}


bool IsPrime(int number)
{
    if (number <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0) return false;
    }
    return true;
}
static bool IsFibonacci(int number)
{
    if (number < 0) return false;

    int a = 0;
    int b = 1;

    while (b < number)
    {
        int temp = a;
        a = b;
        b = temp + b;
    }

    return b == number;
}

Predicate<int> isEven = delegate (int number)
 {
     return number % 2 == 0;
 };

Console.WriteLine("\nЗавдання 4");
Predicate<int> isEvenNum = delegate (int num)
{
    return num % 2 == 0;
};

Console.Write("Введіть число: ");
int num = int.Parse(Console.ReadLine());

bool result = isEvenNum(num);
Console.WriteLine($"{num} парне: {result}");



Console.WriteLine("\nЗавдання 5");
Func<int, int> cube = x => x * x * x;

Console.Write("Введіть число: ");
int a = int.Parse(Console.ReadLine());

int cubeRes = cube(number);
Console.WriteLine($"Куб числа {a} дорівнює: {cubeRes}");



Console.WriteLine("\nЗавдання 6");
int[] numb = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Func<int, bool> isOdd = number => number % 2 != 0;
int[] tempArray = new int[numb.Length];
int count = 0;

foreach (var z in numb)
{
    if (isOdd(z))
    {
        tempArray[count] = z;
        count++;
    }
}
int[] oddNumbers = new int[count];
Array.Copy(tempArray, oddNumbers, count);

Console.WriteLine("Непарні числа у масиві:");
foreach (var x in oddNumbers)
{
    Console.WriteLine(x);
}

delegate double Op(double x, double y);
delegate void Message(string message);