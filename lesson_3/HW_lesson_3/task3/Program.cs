// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine(i * i * i);
        i++;
    }
}
int x = int.Parse(Console.ReadLine()!);
Cube(x);
