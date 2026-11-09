using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task18_TryParseVsTryCatch : ITask
    {
        public string Title => "TryParse vs try/catch";
        public string Description => "Сравнить два способа обработки некорректного ввода.";
        public string[] Requirements => new[] { "Способ 1: int.TryParse", "Способ 2: int.Parse внутри try/catch" };

        public void Run()
        {
            string[] inputs = { "123", "abc" };

            foreach (var input in inputs)
            {
                Console.WriteLine($"Ввод: '{input}'");
                Console.WriteLine($"TryParse: {ParseWithTryParse(input)}");
                Console.WriteLine($"TryCatch: {ParseWithTryCatch(input)}");
                Console.WriteLine();
            }
        }

        private string ParseWithTryParse(string input)
        {
            if (int.TryParse(input, out int result)) return result.ToString();
            return "Ошибка";
        }

        private string ParseWithTryCatch(string input)
        {
            try { return int.Parse(input).ToString(); }
            catch (FormatException) { return "Ошибка"; }
        }
    }
}