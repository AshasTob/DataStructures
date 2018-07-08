namespace DataStructures.DataStructures
{
    public class StackLinkedList<Type>: Stack<Type>
    {
        public Node<Type> Head { get; set; }

        public void Push(Type newHead)
        {
            var newHeadNode = new Node<Type>(newHead)
            {
                Next = Head
            };
            Head = newHeadNode;
        }

        public Type Pop()
        {
            Node<Type> toReturn = Head;
            Head = Head.Next;
            return toReturn.Data;
        }

        public override string ToString()
        {
            var iterator = Head;
            var result = "";
            while (iterator != null)
            {
                result += iterator.Data.ToString();
                iterator = iterator.Next;
            }
            return result;
        }
    }
}
