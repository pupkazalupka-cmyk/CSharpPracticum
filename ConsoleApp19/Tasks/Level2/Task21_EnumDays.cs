using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task21_EnumDays : ITask
    {
        public string Title => "enum дни недели";
        public string Description => "Описать дни недели через enum и определить тип дня.";
        public string[] Requirements => new[] { "enum DayOfWeek", "Метод IsWeekend", "Метод GetRussianName" };

        public void Run()
        {
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine($"{day} - {GetRussianName(day)} - {(IsWeekend(day) ? "Выходной" : "Рабочий")}");
            }
        }

        public static bool IsWeekend(DayOfWeek day) => day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;

        public static string GetRussianName(DayOfWeek day)
        {
            return day switch
            {
                DayOfWeek.Monday => "Понедельник",
                DayOfWeek.Tuesday => "Вторник",
                DayOfWeek.Wednesday => "Среда",
                DayOfWeek.Thursday => "Четверг",
                DayOfWeek.Friday => "Пятница",
                DayOfWeek.Saturday => "Суббота",
                DayOfWeek.Sunday => "Воскресенье",
                _ => "Неизвестно"
            };
        }
    }

    public enum DayOfWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}