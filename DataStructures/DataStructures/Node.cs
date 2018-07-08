namespace DataStructures.DataStructures
{
    public class Node<Type>
    {
        public Type Data { get; set; }
        public Node<Type> Next { get; set; }

        public Node(Type data)
        {
            Data = data;
        }

        public Node()
        {
        }
    }
}
