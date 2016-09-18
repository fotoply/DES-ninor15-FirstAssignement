namespace DES_ninor15.Task7
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
            NextNode = null;
        }

        public bool HasNext
        {
            get { return NextNode != null; }
        }

        public LinkedListNode<T> NextNode { get; set; }
        public T Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}