using System;

public class HexTable
{
    public static void Main(string[] args)
    {
        int tableSize = 16; // Размер таблицы (до F в шестнадцатеричной системе)

        // Печать таблицы умножения
        Console.WriteLine("Таблица умножения (шестнадцатеричная)");
        Console.Write("   "); // Отступ для заголовка
        for (int i = 0; i < tableSize; i++)
        {
            Console.Write("{0,3} ", i.ToString("X")); // Заголовок столбцов (шестнадцатеричные числа)
        }
        Console.WriteLine();
        Console.WriteLine("---" + new string('-', tableSize * 4)); // Разделитель

        for (int i = 0; i < tableSize; i++)
        {
            Console.Write("{0,2}| ", i.ToString("X")); // Заголовок строк (шестнадцатеричные числа)

            for (int j = 0; j < tableSize; j++)
            {
                Console.Write("{0,3} ", (i * j).ToString("X")); // Результат умножения в шестнадцатеричной системе
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Печать таблицы сложения
        Console.WriteLine("Таблица сложения (шестнадцатеричная)");
        Console.Write("   "); // Отступ для заголовка
        for (int i = 0; i < tableSize; i++)
        {
            Console.Write("{0,3} ", i.ToString("X")); // Заголовок столбцов (шестнадцатеричные числа)
        }
        Console.WriteLine();
        Console.WriteLine("---" + new string('-', tableSize * 4)); // Разделитель

        for (int i = 0; i < tableSize; i++)
        {
            Console.Write("{0,2}| ", i.ToString("X")); // Заголовок строк (шестнадцатеричные числа)

            for (int j = 0; j < tableSize; j++)
            {
                Console.Write("{0,3} ", (i + j).ToString("X")); // Результат сложения в шестнадцатеричной системе
            }
            Console.WriteLine();
        }

        Console.ReadKey(); 
    }
}
