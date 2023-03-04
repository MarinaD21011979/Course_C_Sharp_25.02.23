// 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
//    причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
//    в которой находится эта точка.

void Quarters(int x, int y) // void - функция, которая больше информирует
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0, y = 0");
    if (x > 0 && y > 0)
        Console.WriteLine("One");
    if (x < 0 && y > 0)
        Console.WriteLine("Two");
    if (x < 0 && y < 0)
        Console.WriteLine("Three");
    if (x > 0 && y < 0)
        Console.WriteLine("Four"); 
}
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Quarters(num1 , num2);