using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task22_ParamsOverload : ITask
    {
        public string Title => "params-метод + перегрузка";
        public string Description => "Метод суммы с params и его перегрузка.";
        public string[] Requirements => new[] { "Sum(params int[] numbers)", "Sum(int[] numbers)" };

        public void Run()
        {
            Console.WriteLine($"Sum(1, 2, 3) = {Sum(1, 2, 3)}");
            // Чтобы вызвать перегрузку для массива, можно явно указать тип:
            Console.WriteLine($"Sum(new[] {{1, 2, 3}}) = {Sum((int[])new[] { 1, 2, 3 })}");
            Console.WriteLine($"Sum() = {Sum()}");
        }

        public static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (var n in numbers) total += n;
            return total;
        }
    }
}