using System;

namespace Collections
{
    public class Stack<T>
    {
        private Node<T> Top {get; set;}

        public void Push(T data){
            if(Top == null){
                Top = new Node<T>(data);
            }else{
                var n = new Node<T>(data);
                n.Next = Top;
                Top = n;
            }
        }

        public T Pop(){
            if(Top == null) throw new Exception("Stack is empty");
            var temp = Top;
            Top = Top.Next;
            temp.Next =null;
            return temp.Data;
        }

        public T Peek(){
            if(Top == null) throw new Exception("Stack is empty");
            return Top.Data;
        }

        public bool isEmpty(){
            return Top == null;
        }

        public void PrintStack(){
            var v= Top;
            while(v!=null){
                Console.WriteLine("Element "+ v.Data);
                v = v.Next;
            }
        }
    }
}