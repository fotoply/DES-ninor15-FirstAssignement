using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace DES_ninor15.Task7
{
    public class SingleLinkedList<T>
    {
        private List<LinkedListNode<T>> InternalList = new List<LinkedListNode<T>>();

        public LinkedListNode<T> First
        {
            get { return InternalList[0]; }
        }

        public LinkedListNode<T> Last
        {
            get { return InternalList[InternalList.Count - 1]; }
        }

        public void Add(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            if (Count != 0)
            {
                Last.NextNode = newNode;
            }

            InternalList.Add(newNode);
        }

        public void Remove(T element)
        {
            foreach (LinkedListNode<T> enumeratedElement in InternalList)
            {
                if (enumeratedElement.Value.Equals(element))
                {
                    Remove(enumeratedElement);
                }
            }
        }

        public void Remove(LinkedListNode<T> node)
        {
            LinkedListNode<T> pointsAt = node.NextNode;
            if (InternalList.IndexOf(node) != 0)
            {
                LinkedListNode<T> previous = InternalList[InternalList.IndexOf(node) - 1];
                previous.NextNode = pointsAt;
            }
            InternalList.Remove(node);
        }

        public void Clear()
        {
            InternalList.Clear();
        }

        public IEnumerator<LinkedListNode<T>> GetEnumerator()
        {
            return InternalList.GetEnumerator();
        }

        public int Count
        {
            get { return InternalList.Count; }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            if (InternalList.Count != 0)
            {
                builder.Append("LinkedList: [");

                foreach (LinkedListNode<T> node in InternalList)
                {
                    builder.Append(node);
                    builder.Append(", ");
                }
                if (builder.Length > 4)
                {
                    builder.Remove(builder.Length - 2, 2);
                }
            }
            builder.Append("]");

            return builder.ToString();
        }
    }
}