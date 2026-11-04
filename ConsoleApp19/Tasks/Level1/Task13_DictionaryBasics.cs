using System;
using System.Collections.Generic;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task13_DictionaryBasics : ITask
    {
        public string Title => "Словарь: подсчёт слов";
        public string Description => "Пользователь вводит строку, программа считает, сколько раз встречается каждое слово.";
        public string[] Requirements => new[] { "Использовать Dictionary<string,int>", "Разбить строку через Split" };

        public void Run()
        {
            Console.Write("Введите строку: ");
            var text = Console.ReadLine() ?? string.Empty;

            var words = text.Split(new[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (var w in words)
            {
                if (dict.ContainsKey(w)) dict[w]++;
                else dict[w] = 1;
            }

            foreach (var pair in dict)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}