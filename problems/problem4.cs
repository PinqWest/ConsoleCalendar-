using System;

class Program
{
    static void Main()
    {
        int low = 0;
        int high = 63;

        Console.WriteLine("Загадайте число от 0 до 63. Отвечайте 1 = да, 0 = нет.");

        while (low < high)
        {
            int mid = (low + high) / 2;
            Console.WriteLine($"Ваше число больше {mid}? (1 - да, 0 - нет)");

            int answer;
            while (!int.TryParse(Console.ReadLine(), out answer) || (answer != 0 && answer != 1))
            {
                Console.WriteLine("Ошибка! Введите 1 (да) или 0 (нет).");
            }

            if (answer == 1)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        Console.WriteLine($"Ваше число: {low}");
    }
}