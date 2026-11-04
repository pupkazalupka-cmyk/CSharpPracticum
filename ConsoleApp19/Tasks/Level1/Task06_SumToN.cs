using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task06_SumToN : ITask
    {
        public string Title => "Сумма чисел от 1 до N";
        public string Description => "Пользователь вводит N, программа выводит сумму двумя способами.";
        public string[] Requirements => new[] { "Реализовать через цикл for", "Реализовать по формуле n*(n+1)/2" };

        public void Run()
        {
            var n = ConsoleHelper.ReadInt("Введите N (положительное): ");
            if (n < 1)
            {
                Console.WriteLine("N должно быть положительным.");
                return;
            }

            var byLoop = 0L;
            for (var i = 1; i <= n; i++)
                byLoop += i;

            var byFormula = (long)n * (n + 1) / 2;

            Console.WriteLine($"Сумма циклом: {byLoop}");
            Console.WriteLine($"Сумма по формуле: {byFormula}");
        }
    }
}