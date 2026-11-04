using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task05_MultiplicationTable : ITask
    {
        public string Title => "Таблица умножения";
        public string Description => "Вывести таблицу умножения от 1 до 10 в виде сетки.";
        public string[] Requirements => new[] { "Использовать вложенные циклы for" };

        public void Run()
        {
            for (var i = 1; i <= 10; i++)
            {
                for (var j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }
    }
}