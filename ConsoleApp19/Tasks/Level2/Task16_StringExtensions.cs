using System;
using System.Linq;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task16_StringExtensions : ITask
    {
        public string Title => "Методы расширения для string";
        public string Description => "Написать extension-методы для string и продемонстрировать их.";
        public string[] Requirements => new[] { "Реализовать в статическом классе StringExtensions", "Методы: IsPalindrome, WordCount, ReverseString" };

        public void Run()
        {
            string text1 = "А роза упала на лапу Азора";
            string text2 = "Привет мир, как дела";
            string text3 = "abc";

            Console.WriteLine($"Строка: {text1}");
            Console.WriteLine($"Палиндром? {text1.IsPalindrome()}");
            Console.WriteLine($"Слов: {text2.WordCount()}");
            Console.WriteLine($"Перевернутая: {text3.ReverseString()}");
        }
    }

    public static class StringExtensions
    {
        public static bool IsPalindrome(this string str)
        {
            var clean = new string(str.ToLower().Where(char.IsLetter).ToArray());
            var reversed = new string(clean.Reverse().ToArray());
            return clean == reversed;
        }

        public static int WordCount(this string str)
        {
            return str.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ReverseString(this string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}