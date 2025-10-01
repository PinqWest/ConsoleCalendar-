using System;

class Program
{
    static void Main()
    {
        // Константы
        const int waterAmericano = 300;
        const int priceAmericano = 150;

        const int waterLatte = 30;
        const int milkLatte = 270;
        const int priceLatte = 170;

        // Остатки
        Console.WriteLine("Введите количество воды (мл):");
        int water = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество молока (мл):");
        int milk = int.Parse(Console.ReadLine());

        // Учёт
        int americanoCount = 0;
        int latteCount = 0;
        int money = 0;

        while (true)
        {
            // Проверка: хватает ли хотя бы на один напиток
            bool canAmericano = water >= waterAmericano;
            bool canLatte = (water >= waterLatte && milk >= milkLatte);

            if (!canAmericano && !canLatte)
            {
                Console.WriteLine("\nИнгредиенты подошли к концу!");
                Console.WriteLine($"Остаток воды: {water} мл");
                Console.WriteLine($"Остаток молока: {milk} мл");
                Console.WriteLine($"Приготовлено американо: {americanoCount}");
                Console.WriteLine($"Приготовлено латте: {latteCount}");
                Console.WriteLine($"Выручка: {money} рублей");
                break;
            }

            Console.WriteLine("\nВыберите напиток: 1 - американо, 2 - латте (0 - завершить):");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 0)
            {
                Console.WriteLine("\nСмена завершена.");
                Console.WriteLine($"Остаток воды: {water} мл");
                Console.WriteLine($"Остаток молока: {milk} мл");
                Console.WriteLine($"Приготовлено американо: {americanoCount}");
                Console.WriteLine($"Приготовлено латте: {latteCount}");
                Console.WriteLine($"Выручка: {money} рублей");
                break;
            }

            if (choice == 1) // Американо
            {
                if (canAmericano)
                {
                    water -= waterAmericano;
                    americanoCount++;
                    money += priceAmericano;
                    Console.WriteLine("Ваш американо готов!");
                }
                else
                {
                    Console.WriteLine("Не хватает воды для американо.");
                }
            }
            else if (choice == 2) // Латте
            {
                if (canLatte)
                {
                    water -= waterLatte;
                    milk -= milkLatte;
                    latteCount++;
                    money += priceLatte;
                    Console.WriteLine("Ваш латте готов!");
                }
                else
                {
                    if (water < waterLatte) Console.WriteLine("Не хватает воды для латте.");
                    else if (milk < milkLatte) Console.WriteLine("Не хватает молока для латте.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введите 1, 2 или 0.");
            }
        }
    }
}