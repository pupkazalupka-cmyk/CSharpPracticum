using System;
using System.Collections.Generic;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task24_Animals : ITask
    {
        public string Title => "ООП: Animal → Dog/Cat/Bird";
        public string Description => "Построить иерархию животных и продемонстрировать полиморфизм.";
        public string[] Requirements => new[] { "Абстрактный класс Animal", "Наследники Dog, Cat, Bird", "List<Animal> и вызов MakeSound()" };

        public void Run()
        {
            var animals = new List<Animal>
            {
                new Dog("Шарик"),
                new Cat("Мурка"),
                new Bird("Кеша")
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
                animal.MakeSound();
                if (animal is Bird bird) bird.Fly();
                Console.WriteLine();
            }
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        protected Animal(string name) => Name = name;
        public abstract void MakeSound();
        public override string ToString() => $"Животное: {Name}";
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void MakeSound() => Console.WriteLine("Гав-гав!");
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void MakeSound() => Console.WriteLine("Мяу!");
    }

    public class Bird : Animal
    {
        public Bird(string name) : base(name) { }
        public override void MakeSound() => Console.WriteLine("Чик-чирик!");
        public void Fly() => Console.WriteLine("*Летит*");
    }
}