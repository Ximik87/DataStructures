using System;

namespace DataStructures.Interfaces
{
    interface IStack<T>
    {
        int Count { get; }
        void Push(T item);
        /// <summary>
        ///  Достать элемент, сложность  O(1)
        /// </summary>
        /// <returns></returns>
        T Pop();
        T Peek();
    }
}
