using System;
using System.Collections.Generic;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task28_PointEquality : ITask
    {
        public string Title => "Equals / GetHashCode для Point";
        public string Description => "Переопределить Equals и GetHashCode для класса Point(x, y).";
        public string[] Requirements => new[] { "Переопределить Equals и GetHashCode", "Реализовать IEquatable<Point>", "Проверить в HashSet<Point>" };

        public void Run()
        {
            var p1 = new Point(1, 2);
            var p2 = new Point(1, 2);
            var p3 = new Point(3, 4);

            Console.WriteLine($"p1 == p2? {p1.Equals(p2)}");
            Console.WriteLine($"p1 == p3? {p1.Equals(p3)}");

            var set = new HashSet<Point> { p1, p2, p3 };
            Console.WriteLine($"Уникальных точек в HashSet: {set.Count} (ожидается 2)");
        }
    }

    public class Point : IEquatable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) { X = x; Y = y; }

        public bool Equals(Point other)
        {
            if (other is null) return false;
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object? obj) => Equals(obj as Point);

        public override int GetHashCode() => (X * 397) ^ Y;
    }
}