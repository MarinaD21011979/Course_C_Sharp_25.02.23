// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.


void ValueSet(int M, int N)
{
    if (N < M) return;
    ValueSet(M, N - 1);
    if (N % 2 == 0)
    Console.Write($"{N} "); 
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
ValueSet(num1, num2);