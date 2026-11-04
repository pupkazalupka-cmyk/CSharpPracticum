using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level1
{
    public class Task15_GitBasics : ITask
    {
        public string Title => "Git: локальный репозиторий";
        public string Description => "Создать локальный репозиторий, сделать первый коммит, проверить историю.";
        public string[] Requirements => new[] { "Инициализировать репозиторий: git init", "Добавить .gitignore" };

        public void Run()
        {
            Console.WriteLine("Это git-задание. В коде не выполняется.");
            Console.WriteLine("Выполните команды в терминале:");
            Console.WriteLine();
            Console.WriteLine("  git init");
            Console.WriteLine("  git add .gitignore");
            Console.WriteLine("  git commit -m \"feat: task 15 - initial commit\"");
            Console.WriteLine("  git log --graph --oneline --all");
        }
    }
}