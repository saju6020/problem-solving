// See https://aka.ms/new-console-template for more information
using LinkedList;

SingleLinkList<int> singleLinkList = new SingleLinkList<int>();
Node<int> node1 = new Node<int>(5);
Node<int> node2 = new Node<int>(10);
Node<int> node3 = new Node<int>(15);

singleLinkList.AddNode(node1);
singleLinkList.AddNode(node2);
singleLinkList.AddNode(node3);

var temp = singleLinkList.Head;

while(temp != null)
{
    Console.WriteLine(temp.Data);
    temp = temp.Next;
}




