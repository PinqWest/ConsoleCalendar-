using System;

class Program
{
    // Алгоритм Евклида для нахождения НОД
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return Math.Abs(a);
    }

    static void Main()
    {
        Console.WriteLine("Введите числитель (M):");
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите знаменатель (N):");
        int N = int.Parse(Console.ReadLine());

        if (N == 0)
        {
            Console.WriteLine("Ошибка: знаменатель не может быть равен нулю!");
            return;
        }

        int gcd = GCD(M, N);

        M /= gcd;
        N /= gcd;

        Console.WriteLine($"Сокращённая дробь: {M}/{N}");
    }
}