// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
    
void Main()
{
    int M = 1;
    int N = 10;
    PrintNumbers(M, N);
}

void PrintNumbers(int M, int N)
{
    if (M > N) return;
    Console.Write(M + " ");
    PrintNumbers(M + 1, N);
 }
Main();
System.Console.WriteLine(" ");


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

static void Main2()
{
    int m = 2; 
    int n = 3; 
    int result = Ackermann(m, n); 
    Console.WriteLine(result); 
}

static int Ackermann(int m, int n)
{
    if (m == 0) return n + 1; 
    if (m > 0 && n == 0) return Ackermann(m - 1, 1); 
    return Ackermann(m - 1, Ackermann(m, n - 1)); 
}
Main2();


// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца
// Использовать рекурсию, не использовать циклы
void Main3()
{
    int[] array = { 1, 2, 3, 4, 5 };
    PrintArrayReverse(array, array.Length - 1);
}

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0) return;
    Console.Write(array[index] + " ");
    PrintArrayReverse(array, index - 1);
}
Main3();