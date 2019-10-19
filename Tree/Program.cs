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

            /*
               The left subtree of a node contains only nodes with keys lesser than the node’s key.
               The right subtree of a node contains only nodes with keys greater than the node’s key.
               The left and right subtree each must also be a binary search tree.
               There must be no duplicate nodes.
            */
            var binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(8);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(1);
            binarySearchTree.Insert(6);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(7);
            binarySearchTree.Insert(10);
            binarySearchTree.Insert(14);
            binarySearchTree.Insert(13);

            int searchFor = 7;
            Console.WriteLine($"{searchFor} exists in BST: {binarySearchTree.Search(searchFor)}");
            searchFor = 17;
            Console.WriteLine($"{searchFor} exists in BST: {binarySearchTree.Search(searchFor)}");
        }
    }
}
