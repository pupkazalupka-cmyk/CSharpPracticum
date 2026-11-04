using System;
using System.Collections.Generic;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task12_ListBasics : ITask
    {
        public string Title => "Работа со списком List<string>";
        public string Description => "Добавить элементы, удалить один, вывести содержимое и количество.";
        public string[] Requirements => new[] { "Использовать List<string>", "Показать Add, Remove, Count" };

        public void Run()
        {
            var list = new List<string> { "яблоко", "банан", "вишня" };
            Console.WriteLine("Изначально:");
            PrintList(list);

            list.Add("дыня");
            list.Remove("банан");

            Console.WriteLine("После изменений:");
            PrintList(list);
        }

        private static void PrintList(List<string> list)
        {
            foreach (var item in list)
                Console.WriteLine($"- {item}");
            Console.WriteLine($"Всего: {list.Count}");
            Console.WriteLine();
        }
    }
}