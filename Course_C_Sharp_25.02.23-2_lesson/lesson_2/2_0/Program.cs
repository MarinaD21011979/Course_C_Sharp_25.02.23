﻿// 1. Напишите программу, которая принимает на вход трёхзначное число
//    и на выходе показывает последнюю цифру этого числа.
// первая часть задачи - строки 5 и 6, вторая часть - строка 7

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}


int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// Console.WriteLine(num % 10);

