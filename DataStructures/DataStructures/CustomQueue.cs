using System;
using DataStructures.Interfaces;

namespace DataStructures
{
    /// <summary>
    ///  Очередь на основе замкнутого массива
    ///  Например 5,-,-,1,2,3,4
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
            if (_size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

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
            CheckCapacity();
            _array[_tail] = item;
            _tail++;
            _size++;
        }

        /// <summary>
        /// Получить элемент не доставая из очереди. Сложность O(1)
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            
            return _array[_head];
        }

        private void CheckCapacity()
        {
            if (_array.Length == _size)
            {
                var _newArray = new T[_size * 2];
                Array.Copy(_array, _newArray, _array.Length);
                _array = _newArray;
            }
        }
    }

}
