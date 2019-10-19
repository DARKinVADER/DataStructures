using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    abstract class HashTableAbstract
    {
        Node[] nodes;

        public HashTableAbstract(int size)
        {
            this.nodes = new Node[size];
        }

        abstract public Node Search(Node node);
        abstract public void Insert(Node node);
    }
}
