// Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

int[] MinElem(int[, ] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int minNum = arr[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (minNum > arr[i, j])
            {
                minNum = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(arr[indexes[0], indexes[1]]);
    return indexes;
}

void RowColumnFree(int[, ] arr, int[] mIndexes)
{
     int row = arr.GetLength(0);
     int column = arr.GetLength(1);

     for (int i = 0; i < row; i++)
     {
        for (int j = 0; j < column; j++)
            if (mIndexes[0] == i || mIndexes[1] == j) continue; // прерывание
            else Console.Write($"{arr[i, j],3}");
        Console.WriteLine();    
     }
     Console.WriteLine();
}

Console.Write("Enter number of rows: ");
int rowNum = int.Parse(Console.Readline()!);
Console.Write("Enter number of columns: ");
int columnNum = int.Parse(Console.ReadLine()!);

