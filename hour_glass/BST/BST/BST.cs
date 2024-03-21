using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BST
    {       
        public static Node InsertNode(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;

                if (data < root.Data)
                {
                    cur = InsertNode(root.Left, data);
                    root.Left = cur;

                }
                else
                {
                    cur = InsertNode(root.Right,data);
                    root.Right = cur;
                }
            }

            return root;
        }

        public static int GetHeight(Node root)
        {
            if(root == null)
            {
                return -1;
            }
            else
            {
                int lheight = GetHeight(root.Left);
                int rheight = GetHeight(root.Right);

                if(lheight > rheight)
                {
                    return lheight + 1;
                }
                else
                {
                    return rheight + 1;
                }
            }
        }
    }
}
