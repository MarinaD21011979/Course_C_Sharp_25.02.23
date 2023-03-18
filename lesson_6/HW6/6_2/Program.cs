// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossLines (double b1, double k1, double b2, double k2) 
{
    if ((k1 == k2) && (b1 == b2)) // проверка
       Console.WriteLine("the lines are crossed");
    else if (k1 == k2)
       Console.WriteLine("the lines are parallel");
    else
    {
        double pointx = (b2 - b1) / (k1 - k2); // поиск координаты 1 точки пересечения
        double pointy = (k1*(b2 - b1)) / (k1 - k2) + b1; // поиск координаты 2 точки пересечения
        Console.WriteLine($"pointx = {pointx}");
        Console.WriteLine($"pointy = {pointy}");
    }
    return;
}
Console.WriteLine("input b1: "); // приглашение ко вводу
double b1 = double.Parse(Console.ReadLine()!); // ввод числа
Console.WriteLine("input k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("input b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("input k2: ");
double k2 = double.Parse(Console.ReadLine()!);
CrossLines(b1, b2, k1, k2);

