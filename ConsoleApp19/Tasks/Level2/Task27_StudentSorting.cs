using System;
using System.Collections.Generic;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task27_StudentSorting : ITask
    {
        public string Title => "IComparable / IComparer<T> для Student";
        public string Description => "Научить Student сортироваться по баллу и по имени.";
        public string[] Requirements => new[] { "IComparable<Student> по среднему баллу", "IComparer<Student> по имени", "Продемонстрировать обе сортировки" };

        public void Run()
        {
            var students = new List<Student>
            {
                new Student("Иван", 4.5),
                new Student("Анна", 4.9),
                new Student("Пётр", 3.8)
            };

            Console.WriteLine("По среднему баллу (убывание):");
            students.Sort(); // Использует IComparable
            foreach (var s in students) Console.WriteLine(s);

            Console.WriteLine("\nПо имени (алфавит):");
            students.Sort(new ByNameComparer()); // Использует IComparer
            foreach (var s in students) Console.WriteLine(s);
        }
    }

    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public double AverageGrade { get; set; }

        public Student(string name, double avg) { Name = name; AverageGrade = avg; }

        public int CompareTo(Student? other)
        {
            if (other == null) return 1;
            return other.AverageGrade.CompareTo(AverageGrade); // Сортировка по убыванию
        }

        public override string ToString() => $"{Name}: {AverageGrade}";
    }

    public class ByNameComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x == null || y == null) return 0;
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }
}