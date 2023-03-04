// 1. Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

void Quarters(int num)
{
    if (num == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (num == 2)
        Console.WriteLine("x < 0 && y > 0");
    else if (num == 3)
        Console.WriteLine("x < 0 && y < 0");
    else if (num == 4)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quarters(num_1, num_2);

