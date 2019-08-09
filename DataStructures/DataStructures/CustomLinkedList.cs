using System;
using DataStructures.Interfaces;

namespace DataStructures
{
    public class CustomLinkedList<T> : ILinkedList<T>
    {
        private int _count;
        private Node<T> _head;
        private Node<T> _tail;

        public int Count => _count;

        public void Add(T item)
        {
            var newItem = new Node<T>(item);

            if (_head == null)
            {
                _head = newItem;
            }
            else
            {
                _tail.Next = newItem;
            }
            _tail = newItem;
            _count++;
        }

        public void Remove(T item)
        {
            var tt = new Node<T>(item);

            var current = _head;
            Node<T> prev = null;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (prev != null)
                    {
                        prev.Next = current.Next;
                        if (current.Next == null)
                        {
                            _tail = prev;
                        }

                    }
                    else
                    {
                        _head = _head.Next;
                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }

                    _count--;
                    break;

                }

                prev = current;
                current = current.Next;
            }

        }

        public void Clear()
        {
            _count = 0;
            _head = null;
            _tail = null;
        }
    }

    class Node<T>
    {
        public T Value { get; private set; }
        public Node<T> Next { get; set; }
        public Node(T item)
        {
            Value = item;
        }

        public override string ToString()
        {
            return $"Value: {Value}";
        }
    }

}
