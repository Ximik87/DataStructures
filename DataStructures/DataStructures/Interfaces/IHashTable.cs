using System;

namespace DataStructures.Interfaces
{
    interface IHashTable<T>
    {
        void Add(T item);
        void Remove(T item);
        bool Find(T item);
    }
}
