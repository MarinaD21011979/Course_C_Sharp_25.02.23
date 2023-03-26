// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.


void Print(double[,] arr)
{
	int rowS = arr.GetLength(0);
    int columnS = arr.GetLength(1);
	
	for (int i = 0; i < rowS; i++)
    {
        for (int j = 0; j < columnS; j++)
            Console.Write($" {arr[i, j], 6} ");
        Console.WriteLine();
    }
	    
	Console.WriteLine();
}

double[, ] MassDig(int row, int column, int from, int to)
{
    double[, ] arr = new double[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(n_new.NextDouble() * -10, 2);
    return arr;
}

Console.Write("Enter the number of rows: ");
int rowNum = int.Parse(Console.ReadLine()!); 
Console.Write("Enter the number of columns: ");
int columnNum = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
double[, ] massiv = MassDig(rowNum, columnNum, start, stop);

Print(massiv);
