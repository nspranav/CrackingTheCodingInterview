using System;
namespace Collections
{
    public class MyQueue<T>
    {
        private Node<T> Head {get; set;}
        private Node<T> Tail {get; set;}

        public void Add(T data){
            
        // If the tail is null that implies that the Head is also null and 
        // there are no elements in the queue
            if(Tail == null){
                Tail = new Node<T>(data);
                Head = Tail;
            }
            else{
                var v = new Node<T>(data);
                Tail.Next = v;
                Tail = v;
            }
        }

        public T Remove(){
            if(Head == null) 
                throw new System.Exception("Quesue is empty");
            var temp = Head;
            if(Head == Tail){
                Head = null;
                Tail = null;
            }else{
                Head = Head.Next;
                temp.Next = null;
            }
            return temp.Data;
        }

        public T Peek(){
            if(Head == null) throw new System.Exception("Queue is empty");

            return Head.Data;
        }

        public bool IsEmpty(){
            return Head == null;
        }

        public void PrintQueue(){
            var temp = Head;
            while(temp!=null){
                Console.WriteLine("In Queue "+temp.Data);
                temp = temp.Next;
            }
        }
    }   
}