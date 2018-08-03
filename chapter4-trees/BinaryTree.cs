using System;

namespace Trees{
    public class BinaryTree
    {
        private Node<int> Root {get; set;}

        public void Insert(Node<int> current, int value){
            Create(Root,value);
        }
        private void Create(Node<int> current, int value) 
        {
            if(current == null){
                current = new Node<int>(value);
                return;
            }
            else if(current.Value < value)
            {
                Create(current.Right,value);
            }
            else if(current.Value > value){
                Create(current.Left,value);
            }
            else{
                Console.WriteLine("Duplicate");
                return;
            }
        }

        public void PrintInOrder(){
            PrintNodes(Root);
        }

        private void PrintNodes(Node<int> current){
            if(current)
        }
    }
}