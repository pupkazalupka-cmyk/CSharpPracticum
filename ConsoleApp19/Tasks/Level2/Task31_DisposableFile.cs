using System;
using System.IO;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task31_DisposableFile : ITask
    {
        public string Title => "IDisposable + using";
        public string Description => "Реализовать IDisposable для класса, работающего с файлом.";
        public string[] Requirements => new[] { "Класс FileWriter с StreamWriter", "Реализовать Dispose()", "Использовать using" };

        public void Run()
        {
            string path = "test_file.txt";

            // Демонстрация классического using
            using (var writer = new FileWriter(path))
            {
                writer.Write("Строка 1\n");
            } // Здесь автоматически вызывается Dispose()

            // Демонстрация using-декларации (C# 8+)
            using var writer2 = new FileWriter(path);
            writer2.Write("Строка 2\n");

            Console.WriteLine("Файл записан. Проверьте папку bin/Debug.");
        }
    }

    public class FileWriter : IDisposable
    {
        private StreamWriter _writer;

        public FileWriter(string path)
        {
            _writer = new StreamWriter(path, append: true);
        }

        public void Write(string text)
        {
            _writer.WriteLine(text);
        }

        public void Dispose()
        {
            _writer?.Dispose();
            Console.WriteLine("FileWriter закрыт (Dispose).");
        }
    }
}