using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начальное количество бактерий (N):");
        int bacteria = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество капель антибиотика (X):");
        int drops = int.Parse(Console.ReadLine());

        int hour = 1;
        int antibioticPower = 10;

        while (bacteria > 0 && antibioticPower > 0)
        {
            // 1. Удвоение бактерий
            bacteria *= 2;

            // 2. Действие антибиотика
            int killed = drops * antibioticPower;
            bacteria -= killed;
            if (bacteria < 0) bacteria = 0;

            // 3. Вывод состояния
            Console.WriteLine($"Час {hour}: осталось {bacteria} бактерий");

            // 4. Переход к следующему часу
            hour++;
            antibioticPower--;
        }

        Console.WriteLine("Процесс завершён.");
    }
}