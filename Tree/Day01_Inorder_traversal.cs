using System;

namespace DailyDsa.Tree
{
    internal class Day01_Inorder_traversal
    {
        internal class Node
        {
            public int Data;
            public Node? Left;
            public Node? Right;

            public Node(int data)
            {
                Data = data;
            }
        }

        internal static void Inorder(Node root)
        {
            if (root == null)
                return;

            Inorder(root.Left);
            Console.Write(root.Data + " ");
            Inorder(root.Right);
        }

        internal static void Run()
        {
            var root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);

            Console.WriteLine("Inorder Traversal:");
            Inorder(root);
        }
    }
}
