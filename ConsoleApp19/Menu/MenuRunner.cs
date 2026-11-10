using ConsoleApp19.Tasks.Level1;
using ConsoleApp19.Tasks.Level2;
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
                Console.WriteLine("2. Уровень 2 — Средний (задания 16–34)");
                Console.WriteLine("3. Выход");
                Console.Write("\nВыберите уровень: ");

                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    Level1Menu();
                }
                else if (choice == "2")
                {
                    Level2Menu();
                }
                else if (choice == "3" || choice == "q" || choice == "0")
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
                if (choice == "0" || choice == "q") break;

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
                    Console.WriteLine($"Задание: {task.Title}");
                    Console.WriteLine($"Описание: {task.Description}");
                    foreach (var req in task.Requirements) Console.WriteLine($" - {req}");
                    Console.WriteLine("--------------------------------------------------");
                    task.Run();
                    Console.WriteLine("\nНажмите Enter для возврата...");
                    Console.ReadLine();
                }
            }
        }

        private void Level2Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Уровень 2: Средний ---");
                Console.WriteLine("16. Методы расширения для string");
                Console.WriteLine("17. StringBuilder vs конкатенация");
                Console.WriteLine("18. TryParse vs try/catch");
                Console.WriteLine("19. Свой стек/очередь");
                Console.WriteLine("20. Обобщения: Swap, Max");
                Console.WriteLine("21. enum дни недели");
                Console.WriteLine("22. params-метод + перегрузка");
                Console.WriteLine("23. Nullable-типы, ??, ?.");
                Console.WriteLine("24. ООП: Animal → Dog/Cat/Bird");
                Console.WriteLine("25. Интерфейс IShape + сортировка");
                Console.WriteLine("26. Паттерн «Стратегия» (скидки)");
                Console.WriteLine("27. IComparable / IComparer для Student");
                Console.WriteLine("28. Equals / GetHashCode для Point");
                Console.WriteLine("29. Паттерн «Фабрика» (уведомления)");
                Console.WriteLine("30. BankAccount + свой Exception");
                Console.WriteLine("31. IDisposable + using");
                Console.WriteLine("32. Свойства с валидацией");
                Console.WriteLine("33. LINQ: сотрудники");
                Console.WriteLine("34. LINQ: группировка слов");
                Console.WriteLine("0. Назад");
                Console.Write("\nВыберите задание: ");

                var choice = Console.ReadLine();
                if (choice == "0" || choice == "q") break;

                Common.ITask task = null;
                if (choice == "16") task = new Task16_StringExtensions();
                else if (choice == "17") task = new Task17_StringBuilderVsConcat();
                else if (choice == "18") task = new Task18_TryParseVsTryCatch();
                else if (choice == "19") task = new Task19_MyStackQueue();
                else if (choice == "20") task = new Task20_Generics();
                else if (choice == "21") task = new Task21_EnumDays();
                else if (choice == "22") task = new Task22_ParamsOverload();
                else if (choice == "23") task = new Task23_Nullable();
                else if (choice == "24") task = new Task24_Animals();
                else if (choice == "25") task = new Task25_Shapes();
                else if (choice == "26") task = new Task26_DiscountStrategy();
                else if (choice == "27") task = new Task27_StudentSorting();
                else if (choice == "28") task = new Task28_PointEquality();
                else if (choice == "29") task = new Task29_NotificationFactory();
                else if (choice == "30") task = new Task30_BankAccount();
                else if (choice == "31") task = new Task31_DisposableFile();
                else if (choice == "32") task = new Task32_Temperature();
                else if (choice == "33") task = new Task33_LinqEmployees();
                else if (choice == "34") task = new Task34_LinqWordGroups();

                if (task != null)
                {
                    Console.Clear();
                    Console.WriteLine($"Задание: {task.Title}");
                    Console.WriteLine($"Описание: {task.Description}");
                    foreach (var req in task.Requirements) Console.WriteLine($" - {req}");
                    Console.WriteLine("--------------------------------------------------");
                    task.Run();
                    Console.WriteLine("\nНажмите Enter для возврата...");
                    Console.ReadLine();
                }
            }
        }
    }
}