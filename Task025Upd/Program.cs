// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double PowNumber (double n, double p)
{
    double res = n;
    for(double i = 2; i <= p && i > 1; i++)
    {
       res = res*n;
    }
     return res;
}

Console.WriteLine("Введите число, возводимое в степень:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
double b = Convert.ToDouble(Console.ReadLine());
if (b >= 0)
{
   if (b == 0 && a != 0)
   {
      Console.WriteLine($"Число {a} в степень {b} составляет 1");
   }
   else
   {
      double number1 = PowNumber(a, b);
      Console.WriteLine($"Число {a} в степень {b} составляет {number1}");
   }
}
else 
{
double c = Math.Abs(b);
double number2 = 1 / (PowNumber(a, c));
Console.WriteLine($"Число {a} в степени {b} составляет {number2}");
}