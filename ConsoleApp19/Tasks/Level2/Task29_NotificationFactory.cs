using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task29_NotificationFactory : ITask
    {
        public string Title => "Паттерн «Фабрика» (уведомления)";
        public string Description => "Реализовать фабрику уведомлений.";
        public string[] Requirements => new[] { "Интерфейс INotification", "Реализации Email, Sms, Push", "NotificationFactory.Create" };

        public void Run()
        {
            var email = NotificationFactory.Create(NotificationType.Email);
            email.Send("Привет по почте!");

            var sms = NotificationFactory.Create(NotificationType.Sms);
            sms.Send("Привет по SMS!");

            var push = NotificationFactory.Create(NotificationType.Push);
            push.Send("Пуш-уведомление!");
        }
    }

    public enum NotificationType { Email, Sms, Push }

    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"Email отправлен: {message}");
    }

    public class SmsNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"SMS отправлено: {message}");
    }

    public class PushNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"Push отправлен: {message}");
    }

    public static class NotificationFactory
    {
        public static INotification Create(NotificationType type)
        {
            return type switch
            {
                NotificationType.Email => new EmailNotification(),
                NotificationType.Sms => new SmsNotification(),
                NotificationType.Push => new PushNotification(),
                _ => throw new ArgumentException("Неизвестный тип уведомления")
            };
        }
    }
}