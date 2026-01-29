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
        internal static void PreOrder(Node root)
        {
            if(root == null) return;
            Console.Write(root.Data + " ");
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        internal static void PostOrder(Node root)
        {
            if (root == null) return;
            PostOrder(root.Right);
            PostOrder(root.Left);
            Console.Write(root.Data + " ");
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

            Console.WriteLine("PreOrder Traversal:");
            PreOrder(root);

            Console.WriteLine("PostOrder Traversal:");
            PostOrder(root);
        }
    }
}
