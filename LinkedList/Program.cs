using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            linkedList.Head.Next = second;
            second.Next = third;

            LinkedListTraversal(linkedList);
        }

        private static void LinkedListTraversal(LinkedList linkedList)
        {
            Node actual = linkedList.Head;

            while (actual != null)
            {
                Console.WriteLine(actual.Data);
                actual = actual.Next;
            }
        }
    }
}
