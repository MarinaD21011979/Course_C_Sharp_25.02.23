// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int[, ] MatrixProd(int[, ] arrFirst, int[, ] arrSecond)
{
    int row1 = arrFirst.GetLength(0);
    int column1 = arrFirst.GetLength(1);

    int row2 = arrSecond.GetLength(0);
    int column2 = arrSecond.GetLength(1);

    int[, ] prodMatrix = new int [row1, column1];
    if (column1 != row2) return prodMatrix;
    else if (column1 == row2)
         prodMatrix = new int[row1, column2];

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int p = 0; p < column1; p++)
                prodMatrix[i, j] += arrFirst[i, p] * arrSecond[p, j];
        }
    }
    return prodMatrix;
}

Console.Write("enter the number of rows 1: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("enter the number of columns 1: ");
int column1 = int.Parse(Console.ReadLine()!);

Console.Write("enter the number of rows 2: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("enter the number of columns 2: ");
int column2 = int.Parse(Console.ReadLine()!);

int[, ] arr1 = MassNums(row1, column1, 1, 10);
Print(arr1);
int[, ] arr2 = MassNums(row2, column2, 1, 10);
Print(arr2);

int[, ] resMatrix = MatrixProd(arr1, arr2);
Print(resMatrix);
