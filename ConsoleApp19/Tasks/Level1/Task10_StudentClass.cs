using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task10_StudentClass : ITask
    {
        public string Title => "Простой класс «Студент»";
        public string Description => "Создать класс Student с полями Name, Age, AverageGrade и методом Print().";
        public string[] Requirements => new[] { "Создать отдельный класс Student", "Использовать свойства" };

        public void Run()
        {
            var students = new[]
            {
                new Student("Иван", 19, 4.5),
                new Student("Мария", 20, 4.9),
                new Student("Пётр", 18, 3.8),
            };

            foreach (var st in students)
                st.Print();
        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double AverageGrade { get; set; }

            public Student(string name, int age, double averageGrade)
            {
                Name = name;
                Age = age;
                AverageGrade = averageGrade;
            }

            public void Print()
            {
                Console.WriteLine($"{Name}, {Age} лет, средний балл: {AverageGrade:F2}");
            }
        }
    }
}