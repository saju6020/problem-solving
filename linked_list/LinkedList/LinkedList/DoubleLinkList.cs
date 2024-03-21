using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class DoubleLinkList<T>
    {

        protected T data;
        public T Data { get { return data; } private set { data = value; } }

        public DNode<T>? Head { get; set; }

        protected DNode<T>? currentNode { get; set; }

        public void AddNode(DNode<T> node)
        {
            if(this.Head == null)
            {
                this.Head = node;
                currentNode = node;
            }
            else
            {
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = node;
                node.Previous = currentNode;
            }
        }

        public void InsertInFront(DNode<T> node)
        {
            node.Next = this.Head;

            if(this.Head != null)
            {
                Head.Previous = node;
            }
            
            this.Head = node;
        }
    }
}
