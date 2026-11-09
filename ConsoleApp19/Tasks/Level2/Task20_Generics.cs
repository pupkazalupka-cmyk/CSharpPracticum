using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task20_Generics : ITask
    {
        public string Title => "Обобщения: Swap<T>, Max<T>";
        public string Description => "Написать обобщенные методы для обмена значениями и поиска максимума.";
        public string[] Requirements => new[] { "Swap<T>(ref T a, ref T b)", "Max<T>(T a, T b) where T : IComparable<T>" };

        public void Run()
        {
            int a = 5, b = 10;
            Swap(ref a, ref b);
            Console.WriteLine($"Swap int: a={a}, b={b}");
            Console.WriteLine($"Max int: {Max(5, 10)}");

            string s1 = "Apple", s2 = "Banana";
            Console.WriteLine($"Max string: {Max(s1, s2)}");
            Console.WriteLine($"Max double: {Max(3.14, 2.71)}");
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}