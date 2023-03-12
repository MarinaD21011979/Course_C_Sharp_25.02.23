// задайте одномерный массив из 123 случайных чисел
// найдите количество элементов массива, 
// значения которых лежат в отрезке от 10 до 99

void Print(int[] arr)
{
	int size = arr.Length;
	
	for (int i = 0; i < size; i++)
	    Console.Write($"{arr[i]} ");
	Console.WriteLine();
}
	
int[] MassNums(int size, int from, int to)
{
	int[] arr = new int[size];
	
	for (int i = 0; i < size; i++)
	    arr[i] = new Random().Next(from, to);
	return arr;
}
	
int SumPosNeg(int[] arr)
{
    int num2 = 0;
    for (int i = 0; i < arr.Length; i++)
     {
        if (arr[i] >= 10 && arr[i] <= 99) // arr[i] - текущий массив
        num2 ++;  
        
     }
    return num2;
}
	
		
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, start, stop); // сборка массива: кол-во цифр, начало и конец
Print(mass);
Console.WriteLine(SumPosNeg(mass));

	