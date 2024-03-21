using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        private T _data;

        public T Data { get { return _data; } private set { _data = value; } }
        public Node<T>? Next { get; set; }

        public Node(T data) {
            this._data = data;
            Next = null;           

        }
    }

    public class DNode<T>
    {
        private T _data;

        public T Data { get { return _data; } private set { _data = value; } }

        public DNode<T>? Next { set; get; }

        public DNode<T>? Previous { set; get; }

        public DNode(T data) 
        { 
            this._data = data;
            this.Next = null;
            this.Previous = null;
        }
    }
}
