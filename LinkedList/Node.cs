using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        private int data;
        private Node next;

        public Node(int data)
        {
            this.data = data;
            Next = null;
        }

        public Node Next { get => next; set => next = value; }
        public int Data { get => data; set => data = value; }
    }
}
