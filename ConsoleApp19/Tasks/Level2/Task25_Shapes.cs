using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task25_Shapes : ITask
    {
        public string Title => "Интерфейс IShape + сортировка фигур";
        public string Description => "Реализовать интерфейс фигур и отсортировать их по площади.";
        public string[] Requirements => new[] { "IShape с Area() и Perimeter()", "Классы Circle, Rectangle, Triangle", "Сортировка по площади" };

        public void Run()
        {
            var shapes = new List<IShape>
            {
                new Rectangle(4, 5),
                new Circle(3),
                new Triangle(3, 4, 5),
                new Rectangle(2, 2),
                new Circle(1)
            };

            Console.WriteLine("До сортировки:");
            foreach (var s in shapes) Console.WriteLine($"{s.GetType().Name}: Площадь = {s.Area():F2}");

            shapes.Sort((a, b) => a.Area().CompareTo(b.Area()));

            Console.WriteLine("\nПосле сортировки по площади:");
            foreach (var s in shapes) Console.WriteLine($"{s.GetType().Name}: Площадь = {s.Area():F2}");
        }
    }

    public interface IShape
    {
        double Area();
        double Perimeter();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;
        public double Area() => Math.PI * Radius * Radius;
        public double Perimeter() => 2 * Math.PI * Radius;
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double w, double h) { Width = w; Height = h; }
        public double Area() => Width * Height;
        public double Perimeter() => 2 * (Width + Height);
    }

    public class Triangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c) { A = a; B = b; C = c; }
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public double Perimeter() => A + B + C;
    }
}