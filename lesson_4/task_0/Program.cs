// See https://aka.ms/new-console-template for more information

int SumNum(int Num)
{
    int all_sum = 0;
    for (int i = 1; i <= Num; i++)
        all_sum += i;

    return all_sum;

}

int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);