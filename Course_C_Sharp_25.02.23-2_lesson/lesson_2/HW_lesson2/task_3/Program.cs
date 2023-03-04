// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

int num = int.Parse(Console.ReadLine()!);

    if (num < 100) Console.WriteLine("no third digit");
    else
    {
        while (num > 999) Console.WriteLine(num / 10);     
    }
    Console.WriteLine(num % 10);  

