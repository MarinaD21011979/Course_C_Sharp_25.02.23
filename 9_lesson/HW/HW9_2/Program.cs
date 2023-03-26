// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int Summary(int M, int N)
{
    if (M == N) return M;
    return Summary(M, N -1) +N;
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(Summary(num1, num2));