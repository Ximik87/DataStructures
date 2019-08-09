using System;

namespace DataStructures.Interfaces
{
    interface ILinkedList<T>
    {
        int Count { get; }
        void Add(T item);
        void Remove(T item);
        void Clear();
    }
}
