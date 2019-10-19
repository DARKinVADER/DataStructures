using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class BinarySearchTree : BinaryTree
    {
        public void Insert(int data)
        {
            Node actual = Root;
            Root = InsertNode(data, actual);
        }

        public bool Search(int data)
        {
            Node actual = Root;

            while (actual != null)
            {
                if (actual.Data == data)
                    return true;
                if (actual.Data > data)
                    actual = actual.Left;
                else
                    actual = actual.Right;
            }

            return false;
        }

        private Node InsertNode(int data, Node actual)
        {
            if (actual == null)
            {
                return new Node(data);
            }
            if (actual.Data == data)
            {
                return actual;
            }
            if (actual.Data > data)
            {
                var leftNode = InsertNode(data, actual.Left);
                if (actual.Left == null)
                {
                    actual.Left = leftNode;
                }
                return actual;
            }
            else
            {
                var rightNode = InsertNode(data, actual.Right);
                if (actual.Right == null)
                {
                    actual.Right = rightNode;
                }
                return actual;
            }
        }
    }
}
