using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Node
    {
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public int Data { get; set; }

        public Node(int data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }

    }
}
