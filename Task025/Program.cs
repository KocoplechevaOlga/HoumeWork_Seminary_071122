// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int PowNumber (int n, int p)
{
    int res = n;
    for(int i = 2; i <= p && p > 1; i++)
    {
       res = res*n;
    }
     return res;
}

Console.WriteLine("Введите число, возводимое в степень:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
int number = PowNumber(a, b);
Console.WriteLine($"Число {a} в степень {b} составляет {number}");
}
else
{
    Console.WriteLine("Степень числа должна быть натуральным чилом, введете целое положительное число");
}