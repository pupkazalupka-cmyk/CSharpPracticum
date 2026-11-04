using ConsoleApp19.Tasks.Level1;
using System;

namespace ConsoleApp19.Menu
{
    public class MenuRunner
    {
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Практикум по C# ===");
                Console.WriteLine("1. Уровень 1 — Базовый (задания 1–15)");
                Console.WriteLine("2. Выход");
                Console.Write("\nВыберите уровень: ");

                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    Level1Menu();
                }
                else if (choice == "2" || choice == "q" || choice == "0")
                {
                    break;
                }
            }
        }

        private void Level1Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Уровень 1: Базовый ---");
                Console.WriteLine("1. Hello, World");
                Console.WriteLine("2. Переменные");
                Console.WriteLine("3. Калькулятор");
                Console.WriteLine("4. Чётное/нечётное");
                Console.WriteLine("5. Таблица умножения");
                Console.WriteLine("6. Сумма от 1 до N");
                Console.WriteLine("7. Массив и статистика");
                Console.WriteLine("8. Переворот строки");
                Console.WriteLine("9. Подсчёт гласных");
                Console.WriteLine("10. Класс Студент");
                Console.WriteLine("11. Исключение DivideByZero");
                Console.WriteLine("12. Список List");
                Console.WriteLine("13. Словарь");
                Console.WriteLine("14. Факториал");
                Console.WriteLine("15. Git");
                Console.WriteLine("0. Назад");
                Console.Write("\nВыберите задание: ");

                var choice = Console.ReadLine();
                if (choice == "0" || choice == "q")
                    break;
                Common.ITask task = null;
                if (choice == "1") task = new Task01_HelloWorld();
                else if (choice == "2") task = new Task02_Primitives();
                else if (choice == "3") task = new Task03_Calculator();
                else if (choice == "4") task = new Task04_EvenOdd();
                else if (choice == "5") task = new Task05_MultiplicationTable();
                else if (choice == "6") task = new Task06_SumToN();
                else if (choice == "7") task = new Task07_ArrayStats();
                else if (choice == "8") task = new Task08_ReverseString();
                else if (choice == "9") task = new Task09_VowelCount();
                else if (choice == "10") task = new Task10_StudentClass();
                else if (choice == "11") task = new Task11_TryCatchDivide();
                else if (choice == "12") task = new Task12_ListBasics();
                else if (choice == "13") task = new Task13_DictionaryBasics();
                else if (choice == "14") task = new Task14_Factorial();
                else if (choice == "15") task = new Task15_GitBasics();
                if (task != null)
                {
                    Console.Clear();
                    Console.WriteLine("==================================================");
                    Console.WriteLine($"Задание: {task.Title}");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Описание:");
                    Console.WriteLine($"  {task.Description}");
                    Console.WriteLine("\nТребования:");
                    foreach (var req in task.Requirements)
                        Console.WriteLine($"  - {req}");
                    Console.WriteLine("--------------------------------------------------");

                    task.Run();
                    Console.WriteLine("\nНажмите Enter для возврата...");
                    Console.ReadLine();
                }
            }
        }
    }
}