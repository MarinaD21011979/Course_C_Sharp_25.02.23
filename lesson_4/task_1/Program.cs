// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

int NumDig(int num)
{
    int dig1 = 0; // объявили переменную
    for (int i = 0; num > 0; i++) // в фор располагаются 3 элемента: счетчик, условие, увеличение
    {
        num = num / 10;
        dig1 += i;
    }
    return dig1;
}

int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumDig(A));
