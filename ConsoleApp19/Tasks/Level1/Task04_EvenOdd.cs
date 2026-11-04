using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task04_EvenOdd : ITask
    {
        public string Title => "Чётное или нечётное";
        public string Description => "Пользователь вводит целое число, программа сообщает, чётное оно или нет.";
        public string[] Requirements => new[] { "Использовать оператор %", "Использовать if/else" };

        public void Run()
        {
            var n = ConsoleHelper.ReadInt("Введите целое число: ");
            if (n % 2 == 0)
                Console.WriteLine($"Число {n} — чётное.");
            else
                Console.WriteLine($"Число {n} — нечётное.");
        }
    }
}