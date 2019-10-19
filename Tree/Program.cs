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
            binaryTree.Root.Left.Right = new Node(5);

            Console.WriteLine("InOrder Traversal");
            binaryTree.DepthFirstTraversalsInOrderTraversal(binaryTree.Root);
            Console.WriteLine("PreOrder Traversal");
            binaryTree.DepthFirstTraversalsPreOrderTraversal(binaryTree.Root);
            Console.WriteLine("PostOrder Traversal");
            binaryTree.DepthFirstTraversalsPostOrderTraversal(binaryTree.Root);

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

            Console.WriteLine("BSTk");

            int searchFor = 7;
            Console.WriteLine($"{searchFor} exists in BST: {binarySearchTree.Exists(searchFor)}");
            searchFor = 17;
            Console.WriteLine($"{searchFor} exists in BST: {binarySearchTree.Exists(searchFor)}");

            searchFor = 7;
            Console.WriteLine($"{searchFor} found in BST: {binarySearchTree.Search(binarySearchTree.Root, searchFor) != null}");
            searchFor = 17;
            Console.WriteLine($"{searchFor} found in BST: {binarySearchTree.Search(binarySearchTree.Root, searchFor) != null}");

            Console.WriteLine("InOrder Traversal");
            binarySearchTree.DepthFirstTraversalsInOrderTraversal(binarySearchTree.Root);
            Console.WriteLine("PreOrder Traversal");
            binarySearchTree.DepthFirstTraversalsPreOrderTraversal(binarySearchTree.Root);
            Console.WriteLine("PostOrder Traversal");
            binarySearchTree.DepthFirstTraversalsPostOrderTraversal(binarySearchTree.Root);

        }
    }
}
