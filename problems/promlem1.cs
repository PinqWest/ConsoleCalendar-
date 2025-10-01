using System;

class Program
{
    // Факториал
    static double Factorial(int n)
    {
        if (n == 0 || n == 1) return 1;
        double result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }

    // Вычисление e^x через ряд Маклорена
    static double MaclaurinExp(double x, double eps)
    {
        double sum = 0;
        double term;
        int n = 0;

        do
        {
            term = Math.Pow(x, n) / Factorial(n); // n-й член ряда
            sum += term;
            n++;
        } while (Math.Abs(term) > eps);

        return sum;
    }

    // Вычисление n-го члена ряда e^x
    static double NthTerm(double x, int n)
    {
        return Math.Pow(x, n) / Factorial(n);
    }

    static void Main()
    {
        Console.WriteLine("Введите x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите точность e (<0.01):");
        double eps = double.Parse(Console.ReadLine());

        if (eps >= 0.01)
        {
            Console.WriteLine("Ошибка: e должно быть меньше 0.01");
            return;
        }

        // Вычисление через ряд
        double result = MaclaurinExp(x, eps);
        Console.WriteLine($"Приближенное значение e^{x} = {result}");

        // Вычисление n-го члена
        Console.WriteLine("Введите n для вычисления n-го члена ряда:");
        int n = int.Parse(Console.ReadLine());

        double nth = NthTerm(x, n);
        Console.WriteLine($"{n}-й член ряда = {nth}");
    }
}