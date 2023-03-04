// Напишите программу, которая выводит случайное трехзначное число
// и убирает вторую цифру в числе

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num / 100 * 10 + num % 10; 
}
int itog = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(itog);
