using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task08_ReverseString : ITask
    {
        public string Title => "Переворот строки";
        public string Description => "Пользователь вводит строку, программа выводит её в обратном порядке.";
        public string[] Requirements => new[] { "Проверить пустой ввод", "Использовать цикл" };

        public void Run()
        {
            Console.Write("Введите строку: ");
            var s = Console.ReadLine();

            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Пустая строка.");
                return;
            }

            var chars = new char[s.Length];
            for (var i = 0; i < s.Length; i++)
                chars[s.Length - 1 - i] = s[i];

            Console.WriteLine("Результат: " + new string(chars));
        }
    }
}