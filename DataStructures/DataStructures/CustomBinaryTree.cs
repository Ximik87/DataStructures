using System;
using DataStructures.Interfaces;

namespace DataStructures
{
    public class CustomBinaryTree<T> : IBinaryTree<T>
        where T : IComparable
    {
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public bool Find(T item)
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }
    }

    class BinaryNode<T>
    {
        public T Value { get; set; }
        public BinaryNode<T> Left { get; set; }
        public BinaryNode<T> Right { get; set; }
        public BinaryNode(T value)
        {
            Value = value;
        }
    }
}
