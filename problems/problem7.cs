using System;

class Program
{
    static void Main()
    {
        // Ввод данных
        Console.WriteLine("Введите количество модулей n:");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите размер модуля a:");
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите размер модуля b:");
        int b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите ширину поля w:");
        int w = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите высоту поля h:");
        int h = int.Parse(Console.ReadLine());
        
        // Поиск максимальной толщины защиты
        int maxD = FindMaxProtectionThickness(n, a, b, w, h);
        
        Console.WriteLine($"Максимальная толщина слоя дополнительной защиты: {maxD}");
    }
    
    static int FindMaxProtectionThickness(int n, int a, int b, int w, int h)
    {
        int maxD = 0;
        
        // Перебираем возможные варианты размещения модулей в сетке
        for (int rows = 1; rows <= n; rows++)
        {
            int cols = (n + rows - 1) / rows; // Округление вверх
            
            // Проверяем оба варианта ориентации модуля
            int d1 = CalculateMaxD(a, b, rows, cols, w, h);
            int d2 = CalculateMaxD(b, a, rows, cols, w, h);
            
            maxD = Math.Max(maxD, Math.Max(d1, d2));
        }
        
        return maxD;
    }
    
    static int CalculateMaxD(int moduleWidth, int moduleHeight, int rows, int cols, int fieldWidth, int fieldHeight)
    {
        // Вычисляем доступное пространство для одного модуля
        double availableWidth = (double)fieldWidth / cols;
        double availableHeight = (double)fieldHeight / rows;
        
        // Максимальная толщина защиты по ширине и высоте
        int maxDWidth = (int)Math.Floor((availableWidth - moduleWidth) / 2);
        int maxDHeight = (int)Math.Floor((availableHeight - moduleHeight) / 2);
        
        // Берем минимальное значение, так как защита должна быть одинаковой со всех сторон
        return Math.Min(maxDWidth, maxDHeight);
    }
}