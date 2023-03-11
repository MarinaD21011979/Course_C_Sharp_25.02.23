// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double PowNum(int a, int b) // название функции и что нужно для работы
{
    double n_pow = 1; // 1 потмоу что произведение
    int b_abs = Math.Abs(b);

    for (int i = 1; i <= b_abs; i++) // i <= количество итераций
    {
        if (b > 0)
            n_pow *= a;
        else
            n_pow /= a;  // если  степень отрицательная 
    }
    return n_pow;
}

Console.WriteLine("Enter a number: ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter degree of number; ");
int num_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(PowNum(num_1, num_2));


