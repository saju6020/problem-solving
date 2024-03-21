using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SingleLinkList<T>
    {
        protected Node<T>? head;        

        internal Node<T>? currentNode;

        public Node<T> Head { get { return head;} }

        public void AddNode(Node<T> node)
        {
            if(head == null)
            {
                head = node;
                currentNode = head;               
            }
            else
            {
                while( currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = node;
            }
        }

        public void InsertInFront(Node<T> node)
        {
            node.Next = head;
            head = node;
        }
      
    }
}
