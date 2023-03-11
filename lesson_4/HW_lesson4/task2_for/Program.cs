// на вход число и поиск суммы цифр в этом числе с помощью for

int SumDigs(int num)
{
    int dig1 = 0;

    for (int i = num; num != 0; num /=10) // ! НЕ равно, то есть пока число не равно нулю
        dig1 += num % 10;

        return dig1;
}
int dig1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumDigs(dig1));
