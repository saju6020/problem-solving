// See https://aka.ms/new-console-template for more information
using BST;

Console.WriteLine("Hello, World!");

Node root = new Node(7);
BST.BST.InsertNode(root,3);
BST.BST.InsertNode(root, 5);
BST.BST.InsertNode(root, 2);
BST.BST.InsertNode(root, 1);
BST.BST.InsertNode(root, 4);

BST.BST.InsertNode(root, 6);

BST.BST.InsertNode(root, 7);

Console.WriteLine(BST.BST.GetHeight(root));
