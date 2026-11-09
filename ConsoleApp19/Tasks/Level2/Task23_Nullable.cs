using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task23_Nullable : ITask
    {
        public string Title => "Nullable-типы, ??, ?.";
        public string Description => "Продемонстрировать работу с nullable-типами и операторами.";
        public string[] Requirements => new[] { "int? FindValue", "Использовать ??", "Использовать ?." };

        public void Run()
        {
            var found = FindValue("age");
            var notFound = FindValue("height");

            Console.WriteLine($"Найдено (age): {found ?? -1}");
            Console.WriteLine($"Не найдено (height): {notFound ?? -1}");

            string? nullString = null;
            Console.WriteLine($"Длина null-строки: {nullString?.Length ?? 0}");

            if (found.HasValue) Console.WriteLine($"Значение через HasValue: {found.Value}");
        }

        public int? FindValue(string key)
        {
            if (key == "age") return 25;
            return null;
        }
    }
}