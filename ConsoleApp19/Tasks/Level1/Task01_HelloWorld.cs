using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task01_HelloWorld : ITask
    {
        public string Title => "Hello, World + текущая дата";
        public string Description => "Вывести приветствие и текущую дату/время в консоль.";
        public string[] Requirements => new[]
        {
            "Использовать Console.WriteLine",
            "Получить текущую дату через DateTime.Now"
        };

        public void Run()
        {
            Console.WriteLine("Hello, World!");
            var now = DateTime.Now;
            Console.WriteLine($"Текущая дата: {now:dd.MM.yyyy}");
            Console.WriteLine($"Текущее время: {now:HH:mm:ss}");
        }
    }
}