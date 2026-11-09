using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task26_DiscountStrategy : ITask
    {
        public string Title => "Паттерн «Стратегия» (скидки)";
        public string Description => "Реализовать калькулятор скидок через паттерн «Стратегия».";
        public string[] Requirements => new[] { "Интерфейс IDiscountStrategy", "Реализации: NoDiscount, VipDiscount, PromoDiscount", "Класс PriceCalculator" };

        public void Run()
        {
            var price = 1000m;

            var calcNo = new PriceCalculator(new NoDiscount());
            var calcVip = new PriceCalculator(new VipDiscount());
            var calcPromo = new PriceCalculator(new PromoDiscount());

            Console.WriteLine($"Базовая цена: {price}");
            Console.WriteLine($"Без скидки: {calcNo.Calculate(price)}");
            Console.WriteLine($"VIP (10%): {calcVip.Calculate(price)}");
            Console.WriteLine($"Промо (20%): {calcPromo.Calculate(price)}");
        }
    }

    public interface IDiscountStrategy
    {
        decimal Apply(decimal price);
    }

    public class NoDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price;
    }

    public class VipDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price * 0.9m;
    }

    public class PromoDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price * 0.8m;
    }

    public class PriceCalculator
    {
        private readonly IDiscountStrategy _strategy;
        public PriceCalculator(IDiscountStrategy strategy) => _strategy = strategy;
        public decimal Calculate(decimal price) => _strategy.Apply(price);
    }
}