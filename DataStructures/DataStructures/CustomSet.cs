using System;
using System.Collections.Generic;

namespace DataStructures
{
    /// <summary>
    ///  Множество элементов (уникальных)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomSet<T> : Interfaces.ISet<T>
    {
        private readonly List<T> _items = new List<T>();

        public int Count => _items.Count;

        /// <summary>
        ///  Добавить элемент в множество (Set)
        ///  проверить на отсутствие дубликата при добавлении
        ///  Сложность O(N)
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            foreach (var current in _items)
            {
                if (current.Equals(item))
                    return;
            }

            _items.Add(item);
        }

        /// <summary>
        /// Удалить элемент из множества, сложность O(N)
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}
