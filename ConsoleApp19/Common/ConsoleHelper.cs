using System;

namespace ConsoleApp19.Common
{
    public static class ConsoleHelper
    {
        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();
                if (int.TryParse(input, out var value)) return value;
                Console.WriteLine("Ошибка, введите число.");
            }
        }

        public static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();
                if (double.TryParse(input, out var value)) return value;
                Console.WriteLine("Ошибка, введите число.");
            }
        }
    }
}