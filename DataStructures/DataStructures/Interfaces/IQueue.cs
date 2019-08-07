using System;

namespace DataStructures.Interfaces
{
    interface IQueue<T>
    {
        int Count { get; }
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    }
}
