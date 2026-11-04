using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task02_Primitives : ITask
    {
        public string Title => "Переменные примитивных типов";
        public string Description => "Объявить переменные разных типов и вывести их значения.";
        public string[] Requirements => new[]
        {
            "Использовать int, double, bool, char, string",
            "Вывести значения"
        };

        public void Run()
        {
            int i = 42;
            double d = 3.14;
            bool b = true;
            char c = 'A';
            string s = "C#";

            Console.WriteLine($"int = {i}");
            Console.WriteLine($"double = {d}");
            Console.WriteLine($"bool = {b}");
            Console.WriteLine($"char = {c}");
            Console.WriteLine($"string = {s}");
        }
    }
}