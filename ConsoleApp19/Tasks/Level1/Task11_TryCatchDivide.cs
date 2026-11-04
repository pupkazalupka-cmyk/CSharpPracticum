using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task11_TryCatchDivide : ITask
    {
        public string Title => "Обработка исключения DivideByZero";
        public string Description => "Продемонстрировать перехват DivideByZeroException через try/catch.";
        public string[] Requirements => new[] { "Использовать try/catch", "Перехватить DivideByZeroException" };

        public void Run()
        {
            var a = ConsoleHelper.ReadInt("Делимое: ");
            var b = ConsoleHelper.ReadInt("Делитель: ");

            try
            {
                var result = a / b;
                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка деления на ноль: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Операция завершена.");
            }
        }
    }
}