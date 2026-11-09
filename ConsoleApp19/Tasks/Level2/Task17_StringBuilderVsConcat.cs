using System;
using System.Diagnostics;
using System.Text;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task17_StringBuilderVsConcat : ITask
    {
        public string Title => "StringBuilder vs конкатенация";
        public string Description => "Сравнить производительность сборки строки двумя способами.";
        public string[] Requirements => new[] { "Собрать строку из 10000 чисел", "Замерить время через Stopwatch" };

        public void Run()
        {
            int count = 10000;

            var sw1 = Stopwatch.StartNew();
            string res1 = "";
            for (int i = 0; i < count; i++) res1 += i;
            sw1.Stop();

            var sw2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++) sb.Append(i);
            string res2 = sb.ToString();
            sw2.Stop();

            Console.WriteLine($"Обычная конкатенация (+): {sw1.ElapsedMilliseconds} мс");
            Console.WriteLine($"StringBuilder: {sw2.ElapsedMilliseconds} мс");
            Console.WriteLine($"Разница: {sw1.ElapsedMilliseconds - sw2.ElapsedMilliseconds} мс");
        }
    }
}