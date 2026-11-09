using System;
using ConsoleApp19.Common;

namespace ConsoleApp19.Tasks.Level2
{
    public class Task19_MyStackQueue : ITask
    {
        public string Title => "Свой стек/очередь на массиве";
        public string Description => "Реализовать MyStack<T> и MyQueue<T> на массиве.";
        public string[] Requirements => new[] { "Стек: Push, Pop, Peek", "Очередь: Enqueue, Dequeue, Peek", "Расширение массива при переполнении" };

        public void Run()
        {
            var stack = new MyStack<int>();
            stack.Push(1); stack.Push(2); stack.Push(3);
            Console.WriteLine($"Стек (Peek): {stack.Peek()}, (Pop): {stack.Pop()}, Размер: {stack.Count}");

            var queue = new MyQueue<string>();
            queue.Enqueue("A"); queue.Enqueue("B"); queue.Enqueue("C");
            Console.WriteLine($"Очередь (Peek): {queue.Peek()}, (Dequeue): {queue.Dequeue()}, Размер: {queue.Count}");

            try { new MyStack<int>().Pop(); }
            catch (InvalidOperationException) { Console.WriteLine("Поймано исключение: стек пуст!"); }
        }
    }

    public class MyStack<T>
    {
        private T[] _items = new T[2];
        public int Count { get; private set; }

        public void Push(T item)
        {
            if (Count == _items.Length) Array.Resize(ref _items, _items.Length * 2);
            _items[Count++] = item;
        }

        public T Pop()
        {
            if (Count == 0) throw new InvalidOperationException("Стек пуст");
            return _items[--Count];
        }

        public T Peek()
        {
            if (Count == 0) throw new InvalidOperationException("Стек пуст");
            return _items[Count - 1];
        }
    }

    public class MyQueue<T>
    {
        private T[] _items = new T[2];
        private int _head = 0;
        public int Count { get; private set; }

        public void Enqueue(T item)
        {
            if (Count == _items.Length) Array.Resize(ref _items, _items.Length * 2);
            _items[(_head + Count) % _items.Length] = item;
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0) throw new InvalidOperationException("Очередь пуста");
            var item = _items[_head];
            _head = (_head + 1) % _items.Length;
            Count--;
            return item;
        }

        public T Peek()
        {
            if (Count == 0) throw new InvalidOperationException("Очередь пуста");
            return _items[_head];
        }
    }
}
}