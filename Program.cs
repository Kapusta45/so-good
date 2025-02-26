using System;

class Program
{
    static void Main()
    {
        // Размер таблицы
        int size = 16;

        // Печать заголовка таблицы
        Console.Write("   |");
        for (int i = 0; i < size; i++)
        {
            Console.Write($" {i:X2} ");
        }
        Console.WriteLine("\n" + new string('-', 4 + size * 4));

        // Печать таблицы сложения
        Console.WriteLine("Таблица сложения:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{i:X2} |");
            for (int j = 0; j < size; j++)
            {
                Console.Write($" {(i + j):X2} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n" + new string('-', 4 + size * 4));

        // Печать таблицы умножения
        Console.WriteLine("Таблица умножения:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{i:X2} |");
            for (int j = 0; j < size; j++)
            {
                Console.Write($" {(i * j):X2} ");
            }
            Console.WriteLine();
        }
    }
}
