// to find the task description, add it and fix the code at the end

void Print(int[,] arr)
{
	int row = arr.GetLength(0);
	int column = arr.GetLength(1);
	
	for (int i = 0; i < row; i++)
	{
	    for (int j = 0; j < column; j++)
	    Console.Write($" {arr[i, j]} ");
	    Console.WriteLine();
	}
	Console.WriteLine();
}
	
int[,] MassNums(int row, int column, int from, int to)
{
	int[,] arr = new int[row, column];
	
	for (int i = 0; i < row; i++)
	for (int j = 0; j < column; j++)
	    arr[i, j] = new Random().Next(from, to);
	
	return arr;
}
	
int[] FrequencyDictionary(int[,] arr)
{
	int[] arr2 = new int[10];
	foreach (int a in arr) arr2[a]++;
	return arr2;
}
	
void Print2(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	Console.WriteLine($" {i} - {arr[i]} ");
	Console.WriteLine();
}
	
	
Console.WriteLine("Р’РІРµРґРёС‚Рµ РєРѕР»РёС‡РµСЃС‚РІРѕ СЃС‚СЂРѕРє РјР°СЃСЃРёРІР°");
int num_row = int.Parse(Console.ReadLine()!);

