using System;
using DataStructures.Interfaces;

namespace DataStructures
{
    public class CustomBinaryTree<T> : IBinaryTree<T>
        where T : IComparable
    {
        public BinaryNode<T> Root { get; private set; }

        public void Add(T item)
        {
            if (Root == null)
            {
                Root = new BinaryNode<T>(item);
            }
            else
            {
                var node = Root;
                while (node != null)
                {
                    if (IsGreater(item, node.Value))
                    {
                        if (node.Right == null)
                        {
                            node.Right = new BinaryNode<T>(item);
                            break;
                        }
                        else
                        {
                            node = node.Right;
                        }
                    }

                    if (IsLess(item, node.Value))
                    {
                        if (node.Left == null)
                        {
                            Root.Left = new BinaryNode<T>(item);
                            break;
                        }
                        else
                        {
                            node = node.Left;
                        }
                    }

                    if (IsEqual(item, node.Value))
                        break;
                }
            }

        }

        private bool IsGreater(T first, T second)
        {
            return first.CompareTo(second) == 1;
        }

        private bool IsLess(T first, T second)
        {
            return first.CompareTo(second) == -1;
        }

        private bool IsEqual(T first, T second)
        {
            return first.CompareTo(second) == 0;
        }

        public bool Find(T item)
        {          
            var node = Root;
            while (node != null)
            {
                if (IsGreater(item, node.Value))
                {
                    if (node.Right == null)
                    {
                        return false;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }

                if (IsLess(item, node.Value))
                {
                    if (node.Left == null)
                    {
                        return false;
                    }
                    else
                    {
                        node = node.Left;
                    }
                }

                if (IsEqual(item, node.Value))
                    return true;
            }

            return false;
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }
    }

    public class BinaryNode<T>
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
