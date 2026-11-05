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
            long l = 9_000_000_000L;
            decimal m = 19.99m;

            Console.WriteLine($"int     = {i}, тип: {i.GetType().Name}");
            Console.WriteLine($"double  = {d}, тип: {d.GetType().Name}");
            Console.WriteLine($"bool    = {b}, тип: {b.GetType().Name}");
            Console.WriteLine($"char    = {c}, тип: {c.GetType().Name}");
            Console.WriteLine($"string  = {s}, тип: {s.GetType().Name}");
            Console.WriteLine($"long    = {l}, тип: {l.GetType().Name}");
            Console.WriteLine($"decimal = {m}, тип: {m.GetType().Name}");
        }
    }
}