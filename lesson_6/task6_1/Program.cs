// / 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

void CheckTrng (int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    Console.WriteLine("yes!");

    else
    Console.WriteLine("no");
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);

CheckTrng(num1, num2, num3);