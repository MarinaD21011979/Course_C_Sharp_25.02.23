// задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N при помощи рекурсии

void ValueSet(int N)
{
    if (N == 0) return;
    ValueSet(N - 1);
    Console.Write($"{N} ");
}

int num = int.Parse(Console.ReadLine()!);
ValueSet(num);