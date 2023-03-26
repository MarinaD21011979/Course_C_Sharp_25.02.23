// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int[, ] MassDig( int row, int column, int from, int to)
{
	int[, ] arr = new int[row, column];
	
	for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
	        arr[i, j] = new Random().Next(from, to +1);
	return arr;
}

string FindEl(int[, ] arr, int f, int s)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (f > row || f <= 0 || s > column || s <= 0)
       return $"{f} {s} -> not in arr";
    return $"arr[{f}, {s}] = {arr[f - 1, s - 1]} -> in the array"; 
}

Console.Write("Enter the number of rows: ");
int rowNum = int.Parse(Console.ReadLine()!); 
Console.Write("Enter the number of columns: ");
int columnNum = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[, ] massiv = MassDig(rowNum, columnNum, start, stop);

Print(massiv);

Console.Write("Enter the row position: ");
int first = int.Parse(Console.ReadLine()!); 
Console.Write("Enter the column position: ");
int second = int.Parse(Console.ReadLine()!);

string answer = FindEl(massiv, first, second);
Console.WriteLine(answer);

