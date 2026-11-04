using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task07_ArrayStats : ITask
    {
        public string Title => "Массив и его статистика";
        public string Description => "Создать массив из 10 случайных чисел, вывести min, max, сумму и среднее.";
        public string[] Requirements => new[] { "Использовать Random", "Найти min, max, сумму вручную" };

        public void Run()
        {
            var rnd = new Random();
            var arr = new int[10];
            for (var i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(1, 101);

            Console.WriteLine("Массив: " + string.Join(", ", arr));

            var min = arr[0];
            var max = arr[0];
            var sum = 0;

            foreach (var x in arr)
            {
                if (x < min) min = x;
                if (x > max) max = x;
                sum += x;
            }

            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Среднее: {(double)sum / arr.Length:F2}");
        }
    }
}