using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task14_Factorial : ITask
    {
        public string Title => "Факториал: цикл и рекурсия";
        public string Description => "Вычислить факториал N двумя способами и сравнить результаты.";
        public string[] Requirements => new[] { "Реализовать циклом", "Реализовать рекурсией" };

        public void Run()
        {
            var n = ConsoleHelper.ReadInt("Введите N (0..20): ");
            if (n < 0 || n > 20)
            {
                Console.WriteLine("N должно быть в диапазоне 0..20.");
                return;
            }

            Console.WriteLine($"Циклом:   {FactorialLoop(n)}");
            Console.WriteLine($"Рекурсией: {FactorialRecursive(n)}");
        }

        private static long FactorialLoop(int n)
        {
            var result = 1L;
            for (var i = 2; i <= n; i++) result *= i;
            return result;
        }

        private static long FactorialRecursive(int n)
        {
            if (n <= 1) return 1L;
            return n * FactorialRecursive(n - 1);
        }
    }
}