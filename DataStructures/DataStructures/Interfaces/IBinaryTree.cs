using System;

namespace DataStructures.Interfaces
{
    interface IBinaryTree<T>
        where T : IComparable
    {
        void Add(T item);
        bool Find(T item);
        void Remove(T item);
    }
}
