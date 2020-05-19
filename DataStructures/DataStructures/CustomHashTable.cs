using DataStructures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// Хэш таблица, на бакетах, но это не точно
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomHashTable<T> : IHashTable<T>
    {
        private Item<T>[] _items;
        private int _size = 8;

        public CustomHashTable()
        {
            _items = new Item<T>[_size];
        }

        /// <summary>
        /// Добавление элемента, сложность  O(1)
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            var index = GetHash(item);
            if (_items[index] == null)
            {
                _items[index] = new Item<T>(index);
                _items[index].Nodes.Add(item);
            }
            else
            {
                _items[index].Nodes.Add(item);
            }
        }

        public bool Find(T item)
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        private int GetHash(T item)
        {
            return item.GetHashCode() % _size;
        }
    }

    class Item<T>
    {
        public int Key { get; }
        public List<T> Nodes { get; set; }

        public Item(int key)
        {
            Key = key;
            Nodes = new List<T>();
        }

    }
}
