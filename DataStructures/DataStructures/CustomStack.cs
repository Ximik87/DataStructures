using System;
using DataStructures.Interfaces;

namespace DataStructures
{
    /// <summary>
    ///  Стек основанный на массиве элементов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomStack<T> : IStack<T>
    {
        private T[] _array;

        public int Count { get; private set; }

        public CustomStack()
        {
            _array = new T[4];
        }

        /// <summary>
        ///  Достать элемент, сложность  O(1)
        /// </summary>
        /// <returns></returns> 
        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            Count--;
            return _array[Count];
        }

        /// <summary>
        /// Добавить элемент, сложность  O(1)
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            CheckCapacity();
            _array[Count] = item;
            Count++;
        }

        /// <summary>
        /// Получить последний элемент,  сложность  O(1)
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return _array[Count];
        }
        
        private void CheckCapacity()
        {
            if (_array.Length == Count)
            {
                var _newArray = new T[Count * 2];
                Array.Copy(_array, _newArray, _array.Length);
                _array = _newArray;
            }
        }

    }
}
