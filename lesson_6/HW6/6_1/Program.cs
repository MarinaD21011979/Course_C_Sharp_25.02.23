// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// введенное число отдается в цикл, внутри цикла идет проверка, затем выводится результат

Console.WriteLine("Введите пять чисел");

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.WriteLine($"{arr[i]}");
    Console.WriteLine();
}

int[] FillMass(int size)
{
    int[] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = size; 
    }
    return arr;
}

int CheckPositiv(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        count ++;
    }  
    return count;
}

int size = int.Parse(Console.ReadLine()!);
int[] arr;
arr = FillMass(size);
Print(arr);