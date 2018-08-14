using System;
namespace Trees
{
    public class BinarySearchTree
    {
        private Node<int> Root;

        public void Insert(int value){
            Create(ref Root,value);
        }

        private void Create(ref Node<int> current, int value){
            if(current == null){
                current = new Node<int>(value);
            }
            else if(current.Value<=value){
                Create(ref current.Right,value);
            }
            else{
                Create(ref current.Left,value);
            }
        }

        public void PrintInOrder(){
            PrintInOrder(Root);
        }

        private void PrintInOrder(Node<int> current){
            if(current!=null){
                PrintInOrder(current.Left);
                Console.WriteLine(current.Value);
                PrintInOrder(current.Right);
            }
        }        
    }
}