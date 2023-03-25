// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Print(int[, ] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
            Console.Write($" {arr[i, j],3} ");
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

void OrderToMin(int[, ] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            for (int k = 0; k < columnSize - j - 1; k++)
                if (arr[i, k] < arr[i, k + 1])
                   (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
        }
    }
}

Console.Write("enter the number of rows: ");
int rowNum = int.Parse(Console.ReadLine()!);
Console.Write("enter the number of columns: ");
int columnNum = int.Parse(Console.ReadLine()!);