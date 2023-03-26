// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


void Print(int[,] arr)
{
	int rowS = arr.GetLength(0);
    int columnS = arr.GetLength(1);
	
	for (int i = 0; i < rowS; i++)
    {
        for (int j = 0; j < columnS; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
	    
	Console.WriteLine();
}

int[, ] MassDig(int row, int column, int from, int to)
{
    int [, ] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
	        arr[i, j] = new Random().Next(from, to);
	return arr;
}

void ArithmeticValue(int[, ] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double res;

    for (int i = 0; i < column; i++)
    {
        res = 0;
        for (int j = 0; j < row; j++)
        Console.Write($"{Math.Round(res / row, 2)}; ");
    }
}

Console.Write("Enter the number of rows: ");
int rowNum = int.Parse(Console.ReadLine()!); 
Console.Write("Enter the number of columns: ");
int columnNum = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[, ] massiv = MassDig(rowNum, columnNum, start, stop);

Print(massiv);

ArithmeticValue(massiv);
