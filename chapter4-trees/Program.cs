using System;
using Trees;

namespace chapter4_trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            for (int i = 5; i < 10; i++)
            {
                tree.Insert(i);
            }
            for (int i = -5; i < 0; i++)
            {
                tree.Insert(i);
            }
            for (int i = 0; i < 5; i++)
            {
                tree.Insert(i);
            }
            Console.WriteLine("Inorder is");
            tree.PrintInOrder();
            Console.WriteLine("Pre order is");
            tree.PrintPreOrder();
            Console.WriteLine("POst order is");
            tree.PrintPostOrder();
        }
    }
}
