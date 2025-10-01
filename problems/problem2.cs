using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите шестизначный номер билета:");
        int ticket = int.Parse(Console.ReadLine());

        if (ticket < 100000 || ticket > 999999)
        {
            Console.WriteLine("Ошибка: номер билета должен быть шестизначным!");
            return;
        }

        // Последние три цифры
        int d6 = ticket % 10;           // последняя цифра
        int d5 = (ticket / 10) % 10;    // пятая цифра
        int d4 = (ticket / 100) % 10;   // четвёртая цифра

        // Первые три цифры
        int d3 = (ticket / 1000) % 10;  // третья цифра
        int d2 = (ticket / 10000) % 10; // вторая цифра
        int d1 = (ticket / 100000) % 10;// первая цифра

        int sumFirst = d1 + d2 + d3;
        int sumLast  = d4 + d5 + d6;

        if (sumFirst == sumLast)
            Console.WriteLine($"Билет {ticket} — СЧАСТЛИВЫЙ!");
        else
            Console.WriteLine($"Билет {ticket} — обычный.");
    }
}