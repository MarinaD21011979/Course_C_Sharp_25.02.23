// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.

void Massiv(int length)
{
    int[] Arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        Arr[1] = new Random().Next(2);
        Console.WriteLine(Arr[i]);
    }
}

Massiv(int.Parse(Console.ReadLine()!));

