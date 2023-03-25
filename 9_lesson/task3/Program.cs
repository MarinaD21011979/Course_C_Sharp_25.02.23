// // 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

int ValueSet(int M)
{
    if (M == 0) return 0;
    return ValueSet(M / 10) + M % 10;
}

int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(ValueSet(num1));
