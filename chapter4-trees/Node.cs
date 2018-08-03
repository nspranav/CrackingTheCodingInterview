namespace Trees{
    public class Node<T>{
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T value){
            this.Value = value;
            Left = null;
            Right = null;
        }
    }
}