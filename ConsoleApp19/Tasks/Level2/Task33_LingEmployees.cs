using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task33_LinqEmployees : ITask
    {
        public string Title => "LINQ: сотрудники";
        public string Description => "LINQ-запросы по списку сотрудников.";
        public string[] Requirements => new[] { "Топ-3 по зарплате", "Средняя зарплата по отделу", "Сотрудники старше 30" };

        public void Run()
        {
            var employees = new List<Employee>
            {
                new Employee("Иван", 25, 50000, "IT"),
                new Employee("Мария", 32, 70000, "HR"),
                new Employee("Пётр", 40, 90000, "IT"),
                new Employee("Анна", 28, 60000, "Finance"),
                new Employee("Сергей", 35, 80000, "IT"),
                new Employee("Ольга", 45, 100000, "HR")
            };

            Console.WriteLine("Топ-3 по зарплате:");
            var top3 = employees.OrderByDescending(e => e.Salary).Take(3);
            foreach (var e in top3) Console.WriteLine($"{e.Name}: {e.Salary}");

            Console.WriteLine("\nСредняя зарплата по отделам:");
            var avgByDept = employees.GroupBy(e => e.Department)
                                     .Select(g => new { Dept = g.Key, Avg = g.Average(e => e.Salary) });
            foreach (var d in avgByDept) Console.WriteLine($"{d.Dept}: {d.Avg:F0}");

            Console.WriteLine("\nСотрудники старше 30:");
            var over30 = employees.Where(e => e.Age > 30);
            foreach (var e in over30) Console.WriteLine($"{e.Name} ({e.Age} лет)");
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, int age, decimal salary, string dept)
        {
            Name = name; Age = age; Salary = salary; Department = dept;
        }
    }
}