using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue
    {
        Node first, last;

        public Queue()
        {
            first = last = null;
        }

        public void EnQueue(int data)
        {
            var newNode = new Node(data);

            if (first == null)
            {
                first = last = newNode;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }

        public Node DeQueue()
        {
            var actual = first;
            first = first.Next;

            return actual;
        }
    }
}
