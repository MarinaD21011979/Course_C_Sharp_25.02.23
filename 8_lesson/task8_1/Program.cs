// to finad and add the task description and to fix code at the end

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
	
void ReplaceColumnRows(int[,] arr)
{
	int row = arr.GetLength(0);
	int column = arr.GetLength(1);
	
	if (row != column)
	{
	   Console.WriteLine("Р—Р°РјРµРЅР° РЅРµРІРѕР·РјРѕР¶РЅР°");
	   return;
	}
	for (int i = 0; i < row; i++)
	for (int j = 0; j < i; j++)
	    (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
}
	
	
Console.WriteLine("Р’РІРµРґРёС‚Рµ РєРѕР»РёС‡РµСЃС‚РІРѕ СЃС‚СЂРѕРє РјР°СЃСЃРёРІР°");