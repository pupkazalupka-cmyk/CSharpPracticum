using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task09_VowelCount : ITask
    {
        public string Title => "Подсчёт гласных";
        public string Description => "Пользователь вводит строку, программа считает количество гласных.";
        public string[] Requirements => new[] { "Игнорировать регистр", "Использовать цикл по символам" };

        public void Run()
        {
            const string vowels = "aeiouyаеёиоуыэюя";

            Console.Write("Введите строку: ");
            var s = Console.ReadLine() ?? string.Empty;

            var count = 0;
            foreach (var ch in s)
            {
                var lower = char.ToLower(ch);
                if (vowels.IndexOf(lower) >= 0)
                    count++;
            }

            Console.WriteLine($"Гласных: {count}");
        }
    }
}