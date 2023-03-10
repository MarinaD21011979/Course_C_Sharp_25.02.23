// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// БЕЗ переменных

void FindNum(int num)
{
    Console.WriteLine(num);

    if ( num / 10000 == num % 10 && num / 1000 == num % 100 )
    {
        Console.WriteLine("palindrom");
    }
    
    else
    {
        Console.WriteLine("NO");
    } 
    
}
FindNum(int.Parse(Console.ReadLine()));
FindNum(new Random().Next(10000, 99999));