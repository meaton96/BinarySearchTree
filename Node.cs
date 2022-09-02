using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Node<T> where T : IComparable<T>
    {
        private readonly T? data;
        private readonly Node<T>? left, right;

        public Node(T data) { 
            this.data = data;
            left = right = null;
        }
        public Node(T data, Node<T> left) : this(data)
        {
            this.left = left;
        }
        public Node(T data, Node<T> left, Node<T> right) : this(data, left)
        {
            this.right = right;
        }

        public T Data { get { return data; } } 
        public Node<T> Left { get { return left; } }
        public Node<T> Right { get { return right; } }
    }
}
