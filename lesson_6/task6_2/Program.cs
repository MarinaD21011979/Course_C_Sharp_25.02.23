// напишите программу, которая будет преобразовывать десятичное число в двоичное
// доп строковая переменная - позволяет сразу получить результат вычислений
// в стринг преобразовывать не надо

string Convert (int num)
{
    string result = ""; // empty string & result variable
    while(num > 0)
    {
        result = num % 2 + result;
        num = num / 2; // уменьшаем на 2 или =/ 2
    }
    return result;
}

Console.WriteLine(Convert(12)); // int.Parse, string result = F, 
