using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task30_BankAccount : ITask
    {
        public string Title => "BankAccount + свой Exception";
        public string Description => "Реализовать банковский счет с собственным исключением.";
        public string[] Requirements => new[] { "Класс BankAccount", "Свой InsufficientFundsException", "Withdraw бросает исключение" };

        public void Run()
        {
            var account = new BankAccount(100m);
            Console.WriteLine($"Баланс: {account.Balance}");

            account.Deposit(50m);
            Console.WriteLine($"После пополнения: {account.Balance}");

            account.Withdraw(70m);
            Console.WriteLine($"После снятия 70: {account.Balance}");

            try
            {
                account.Withdraw(200m);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}. Текущий баланс: {ex.CurrentBalance}");
            }
        }
    }

    public class InsufficientFundsException : Exception
    {
        public decimal CurrentBalance { get; }
        public InsufficientFundsException(string message, decimal balance) : base(message)
        {
            CurrentBalance = balance;
        }
    }

    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Сумма должна быть больше нуля");
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Сумма должна быть больше нуля");
            if (amount > Balance)
                throw new InsufficientFundsException("Недостаточно средств", Balance);
            Balance -= amount;
        }
    }
}