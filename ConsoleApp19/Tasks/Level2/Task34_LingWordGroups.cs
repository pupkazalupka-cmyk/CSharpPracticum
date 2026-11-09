using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task34_LinqWordGroups : ITask
    {
        public string Title => "LINQ: группировка слов по первой букве";
        public string Description => "Сгруппировать слова по первой букве.";
        public string[] Requirements => new[] { "Список слов 10+", "GroupBy(w => w[0])", "Сортировка групп и слов" };

        public void Run()
        {
            var words = new List<string> { "яблоко", "арбуз", "банан", "апельсин", "вишня", "брусника", "авокадо", "ягода", "абрикос", "виноград" };

            var groups = words.GroupBy(w => w[0])
                              .OrderBy(g => g.Key);

            foreach (var group in groups)
            {
                var sortedWords = group.OrderBy(w => w);
                Console.WriteLine($"Буква '{char.ToUpper(group.Key)}': {string.Join(", ", sortedWords)}");
            }
        }
    }
}