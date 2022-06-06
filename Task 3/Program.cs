/*
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int Result(int num, int sum)
{   if(num < 10)
    return sum + num;

    int count = num % 10;
    sum = sum + count;
    num = num / 10;
    return Result(num,sum);   
}


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
int result = Result(num, sum);
Console.WriteLine(result);
