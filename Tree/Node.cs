﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
            Left = Right = null;
        }

        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
