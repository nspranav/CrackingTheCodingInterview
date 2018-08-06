using System;

namespace Trees{
    public class BinaryTree
    {
        private Node<int> Root;

        public void Insert(int value){
            Create(ref Root,value);
        }
        private void Create(ref Node<int> current, int value) 
        {
            if(current == null){
                current = new Node<int>(value);
                return;
            }
            else if(current.Value < value)
            {
                Create(ref current.Right,value);
            }
            else if(current.Value > value){
                Create(ref current.Left,value);
            }
            else{
                Console.WriteLine("Duplicate");
                return;
            }
        }

        public void PrintInOrder(){
            PrintNodesInOrder(Root);
        }

        public void PrintPreOrder(){
            PrintNodesPreOrder(Root);
        }

        public void PrintPostOrder(){
            PrintNodesPostOrder(Root);
        }

        private void PrintNodesPostOrder(Node<int> current){
            if(current!=null){
                
                PrintNodesPostOrder(current.Left);
                PrintNodesPostOrder(current.Right);
                Console.WriteLine(current.Value);
            }
        }

        private void PrintNodesPreOrder(Node<int> current){
            if(current!=null){
                Console.WriteLine(current.Value);
                PrintNodesPreOrder(current.Left);
                PrintNodesPreOrder(current.Right);
            }
        }

        private void PrintNodesInOrder(Node<int> current){
            if(current!=null){
                PrintNodesInOrder(current.Left);
                Console.WriteLine(current.Value);
                PrintNodesInOrder(current.Right);
            }
            return;
        }
    }
}