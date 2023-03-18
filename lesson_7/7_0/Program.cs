// задайте двумерный массив размером m x n

void Print(int[,] arr)
{
	int row = arr.GetLength(0);
    int column = arr.GetLength(1);
	
	for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
	    
	Console.WriteLine();
}
	
int[,] MassNums(int row, int column, int from, int to)
{
	int[] arr = new int[row, column];
	
	for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
	    arr[i, j] = new Random().Next(from, to);
	return arr;
}