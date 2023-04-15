namespace Binary_Search_Tree
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> right { get; set; }
        public Node<T> left { get; set; }

        public Node()
        {
            right = null;
            left = null;
            Data = default;
        }

        ~Node()
        {
            Data = default;
        }
    }
}