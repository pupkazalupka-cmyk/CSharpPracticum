using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task32_Temperature : ITask
    {
        public string Title => "Свойства с валидацией (Temperature)";
        public string Description => "Класс Temperature с валидацией в set.";
        public string[] Requirements => new[] { "Свойство Celsius с проверкой", "Бросать ArgumentOutOfRangeException", "Вычисляемое свойство Fahrenheit" };

        public void Run()
        {
            var t = new Temperature();

            try
            {
                t.Celsius = 25;
                Console.WriteLine($"Температура: {t.Celsius}°C = {t.Fahrenheit}°F");

                t.Celsius = -300; // Ошибка
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }

    public class Temperature
    {
        private double _celsius;

        public double Celsius
        {
            get => _celsius;
            set
            {
                if (value < -273.15)
                    throw new ArgumentOutOfRangeException(nameof(value), "Температура не может быть ниже абсолютного нуля!");
                _celsius = value;
            }
        }

        public double Fahrenheit => _celsius * 9 / 5 + 32;
    }
}