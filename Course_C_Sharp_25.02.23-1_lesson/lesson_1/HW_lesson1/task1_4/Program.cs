// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

string N = Console.ReadLine()!;
int a = int.Parse(N); 
int b = 1; 

while (b <= a)
{
   if (b % 2 == 0) Console.WriteLine(b);
   b++; 
} 
