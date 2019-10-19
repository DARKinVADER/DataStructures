using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class BinaryTree
    {
        public Node Root { get; set; }

        //Algorithm Inorder(tree)
        //   1. Traverse the left subtree, i.e., call Inorder(left-subtree)
        //   2. Visit the root.
        //   3. Traverse the right subtree, i.e., call Inorder(right-subtree)
        public void DepthFirstTraversalsInOrderTraversal(Node root)
        {
            if (root == null) return;

            if (root.Left != null)
            {
                DepthFirstTraversalsInOrderTraversal(root.Left);
            }

            Console.WriteLine($"{root.Data}");

            if (root.Right != null)
            {
                DepthFirstTraversalsInOrderTraversal(root.Right);
            }
        }

        //Algorithm Preorder(tree)
        //1. Visit the root.
        //2. Traverse the left subtree, i.e., call Preorder(left-subtree)
        //3. Traverse the right subtree, i.e., call Preorder(right-subtree)
        public void DepthFirstTraversalsPreOrderTraversal(Node root)
        {
            if (root == null) return;

            Console.WriteLine($"{root.Data}");

            if (root.Left != null)
            {
                DepthFirstTraversalsPreOrderTraversal(root.Left);
            }

            if (root.Right != null)
            {
                DepthFirstTraversalsPreOrderTraversal(root.Right);
            }
        }

        //Algorithm Postorder(tree)
        //1. Traverse the left subtree, i.e., call Postorder(left-subtree)
        //2. Traverse the right subtree, i.e., call Postorder(right-subtree)
        //3. Visit the root.
        public void DepthFirstTraversalsPostOrderTraversal(Node root)
        {
            if (root == null) return;

            if (root.Left != null)
            {
                DepthFirstTraversalsPostOrderTraversal(root.Left);
            }

            if (root.Right != null)
            {
                DepthFirstTraversalsPostOrderTraversal(root.Right);
            }
            Console.WriteLine($"{root.Data}");
        }

        public void BreadFirstTraversalsLevelOrderTraversal(Node root)
        {
            Queue<Node> nodes = new Queue<Node>();
            Node actual;

            nodes.Enqueue(root);

            while (nodes.TryDequeue(out actual))
            {
                Console.WriteLine($"{actual.Data}");
                if (actual.Left != null)
                    nodes.Enqueue(actual.Left);
                if (actual.Right != null)
                    nodes.Enqueue(actual.Right);
            }
        }
    }
}
