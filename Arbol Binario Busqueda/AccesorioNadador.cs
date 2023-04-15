using System;

namespace Binary_Search_Tree
{
    public class Object : IComparable<Object>
    {
        public string Id { get; set; }

        public int CompareTo(Object other)
        {
            return Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}