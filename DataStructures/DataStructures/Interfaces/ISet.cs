using System;

namespace DataStructures.Interfaces
{
    interface ISet<T>
    {
        int Count { get; }
        void Add(T item);
        void Remove(T item);
    }
}
