using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinaryTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public Node<T> Add(T data)
        {
            if (root == null)
            {
                root = new Node<T>(data);
                return root;
            }

            

        }
        private Node<T> RecursiveAdd(Node<T> node, T data)
        {
            if (node == null)
                throw new NullReferenceException();
            if (node.Left == null)
            {
                Node<T> newNode = new Node<T>(data);
                return newNode;
            }
            if (node.Right == null)
            {
                Node<T> newNode = new Node<T>(data);
                node.Right = newNode;
                return newNode;
            }
        }
    }
}
