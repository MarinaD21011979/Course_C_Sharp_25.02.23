// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
int[] MassNums(double size, double from, double to)
{
    double[] arr = new double[size];
    for (double i = 0; i < size; i++)
        arr[i] = new Random.NextDouble(from, to);
    return arr;
}
void DiffMaxMin(int[] arr)
{
    int size = arr.Length;
    int result = arr[size] - arr[0];
    Console.WriteLine(result);
}
Console.WriteLine(DiffMaxMin(result));

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, start, stop);
Print(mass);
DiffMaxMin(mass);


