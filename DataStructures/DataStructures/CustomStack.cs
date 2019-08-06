using System;
using DataStructures.Interfaces;

namespace DataStructures
{
    public class CustomStack<T> : IStack<T>
    {
        private T[] _array;
        int _index;

        public int Count => _index;

        /// <summary>
        /// Достать элемент, сложность  O(1)
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (_index == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            _index--;
            return _array[_index];
        }

        /// <summary>
        /// Добавить элемент, сложность  O(1)
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            _array[_index] = item;
            _index++;
        }

        /// <summary>
        /// Получить последний элемент,  сложность  O(1)
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (_index == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return _array[_index];
        }

        public CustomStack()
        {
            _array = new T[4];
        }
    }
}
