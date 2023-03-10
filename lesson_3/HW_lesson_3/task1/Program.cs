// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// WITH variable

void FindNum(int num)
{
    int digitFirst = num / 10000;
    int digitLast = num % 10;
    int digitSecond = num / 1000;
    int digitPreLast = num % 100;
    if (digitFirst == digitLast && digitSecond == digitPreLast)
    {
        Console.WriteLine("Palindrom!");
    } 
    else
    {
        Console.WriteLine("NO");
    }
    
}

FindNum (int.Parse(Console.ReadLine()));
FindNum(new Random().Next(10000, 99999));


