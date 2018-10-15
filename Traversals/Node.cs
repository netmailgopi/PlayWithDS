 using System;

namespace Traversals
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        /// <summary>
        /// Constructor inits Value
        /// </summary>
        /// <param name="val"></param>
        public Node(int val)
        {
            this.Value = val;
        }

        public static void Main()
        {
            Node root = new Node(100)
            {
                Left = new Node(80),
                Right = new Node(120)
            };

            root.Left.Left = new Node(75);
            root.Left.Right = new Node(85);

            root.Right.Left = new Node(115);
            root.Right.Right = new Node(125);

            Console.Write("PreOrder");
            PrintDFSPreOrder(root);
            Console.WriteLine();
            Console.Write("InOrder");
            PrintDFSInOrder(root);
            Console.WriteLine();
            Console.Write("PostOrder");
            PrintDFSPostOrder(root);
            Console.WriteLine();

            Console.WriteLine(FindMax(root));
            Console.ReadLine();
        }

        /// <summary>
        /// Finds Max value in the binary tree
        /// </summary>
        /// <param name="current"></param>
        /// <param name="CurrentMax"></param>
        /// <returns>MaxValue</returns>
        public static int FindMax(Node current, int CurrentMax = 0)
        {
            if (current == null) return CurrentMax;
            if (current.Value > CurrentMax) CurrentMax = current.Value;
            CurrentMax = Math.Max(FindMax(current.Left, CurrentMax), FindMax(current.Right, CurrentMax));
            return CurrentMax;
        }

        /// <summary>
        /// Finds max sum across all levels of the binary tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns>evel#</returns>
        public int FindMaxSum(Node root)
        {
            var Level = 1;
            var current = root;
            while (current != null)
            {

            }
            return 0;
        }

        /// <summary>
        /// Creates a mirror image of the tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns>Root of the mirror tree</returns>
        public Node MirrorTree(Node root)
        {
            //Perform BFS and swap nodes instead of printing. 
            return null;
        }

        /// <summary>
        /// Inorder traversal of binary tree
        /// </summary>
        /// <param name="current"></param>
        public static void PrintDFSInOrder(Node current)
        {
            if (current != null)
            {
                PrintDFSInOrder(current.Left);
                Console.Write(current.Value + " ");
                PrintDFSInOrder(current.Right);
            }
        }

        /// <summary>
        /// Preorder traversal of binary tree
        /// </summary>
        /// <param name="current"></param>
        public static void PrintDFSPreOrder(Node current)
        {
            if (current != null)
            {
                Console.Write(current.Value + " ");
                PrintDFSInOrder(current.Left);
                PrintDFSInOrder(current.Right);
            }
        }

        /// <summary>
        /// Postorder traversal of binary tree
        /// </summary>
        /// <param name="current"></param>
        public static void PrintDFSPostOrder(Node current)
        {
            if (current != null)
            {
                PrintDFSInOrder(current.Left);
                PrintDFSInOrder(current.Right);
                Console.Write(current.Value + " ");
            }
        }
    }
}
