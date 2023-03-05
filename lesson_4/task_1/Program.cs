// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

int NumDig(int num)
{
    int dig1 = 0;
    for (int i = 0; num > 0; i++){
        num = num / 10;
        dig1 = 1;
    }
    return dig1;
}

int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumDig(A));
