using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree();

            binaryTree.Root = new Node(1);
            binaryTree.Root.Left = new Node(2);
            binaryTree.Root.Right = new Node(3);
            binaryTree.Root.Left.Left = new Node(4);
        }
    }
}
