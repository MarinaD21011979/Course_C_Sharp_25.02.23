// // 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9
//    https://metanit.com/sharp/tutorial/4.9.php
// https://codechick.io/tutorials/csharp/csharp-foreach-loop

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
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

int[] Vocab(int[,] arr)
{
    int[] arrnew = new int[10];
    foreach  (int a in arr) arrnew[a]++;
    return arrnew; 
}

void PrintNewMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"{i} - {arr[i]}");

}

Console.Write("Enter the number of rows: ");


int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
FirstWithLast(mass);
Print(mass);

