// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Например: 452 -> 11; 82 -> 10; 9012 -> 12

int SumDigit (int number)
{
    int sum = default;
    int i = number % 10;
    while(i > 0)
    {
        sum = sum + i;
        number = number / 10;
        i = number % 10;
    }
    return sum;
}

Console.WriteLine("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 0)
{
int s = SumDigit(n);
//int s = SumDigit(Math.Abs(n));
Console.WriteLine($"Сумма цифр числа {n} составляет {s}");
}
else
{
Console.WriteLine("Введите положительное число");
}
