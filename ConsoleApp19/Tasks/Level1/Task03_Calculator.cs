using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task03_Calculator : ITask
    {
        public string Title => "Калькулятор с делением на ноль";
        public string Description => "Принимает два числа и оператор, выводит результат.";
        public string[] Requirements => new[]
        {
            "Использовать switch",
            "Обработать деление на ноль"
        };

        public void Run()
        {
            var a = ConsoleHelper.ReadDouble("Введите первое число: ");
            var b = ConsoleHelper.ReadDouble("Введите второе число: ");

            Console.Write("Введите оператор (+, -, *, /): ");
            var op = Console.ReadLine();

            switch (op)
            {
                case "+": Console.WriteLine($"Результат: {a + b}"); break;
                case "-": Console.WriteLine($"Результат: {a - b}"); break;
                case "*": Console.WriteLine($"Результат: {a * b}"); break;
                case "/":
                    if (b == 0) Console.WriteLine("Ошибка: деление на ноль.");
                    else Console.WriteLine($"Результат: {a / b}");
                    break;
                default: Console.WriteLine("Неизвестный оператор."); break;
            }
        }
    }
}