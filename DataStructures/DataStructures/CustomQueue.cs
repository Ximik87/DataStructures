using System;
using DataStructures.Interfaces;

namespace DataStructures
{
    public class CustomQueue<T> : IQueue<T>
    {
        private int _size;
        private int _head;
        private int _tail;
        T[] _array = new T[4];

        public int Count => _size;

        /// <summary>
        /// Достать элемент, сложность O(1)
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            T removed = _array[_head];
            _head++;
            _size--;
            return removed;
        }

        /// <summary>
        /// Положить элемент, сложность O(1)
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            _array[_tail] = item;
            _tail++;
            _size++;
        }
    }

}
