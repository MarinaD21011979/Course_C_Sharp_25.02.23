// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[, ] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

int[, ] MassivNum(int row, int column, int from, int to)
{
    int[, ] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

int SumNum(int[, ] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] allNums = new int[row];

    for (int i = 0; i < row; i++) // обычный цикл для обхода двумерного массива
    {
        for (int j = 0; j < column; j++)
        {
            allNums[i] += arr[i, j];
        }
    }
    return allNums;
}

void FindMin(int[] arr) // заходит одномерный массив, поиск мин и где оно находится
{
    int minNum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[minNum]) minNum = i;
    }
    Console.WriteLine($"Summ of elements: {arr[minNum]}, line: {minNum + 1}");
}

Console.Write("enter the number of rows: ");
int rowNum = int.Parse(Console.ReadLine()!);
Console.Write("enter the number of columns: ");
int columnNum = int.Parse(Console.ReadLine()!);