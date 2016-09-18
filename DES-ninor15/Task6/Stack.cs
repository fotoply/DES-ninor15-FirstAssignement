using System.Collections.Generic;

namespace DES_ninor15.Task6
{
    public class Stack
    {
        private List<char> InternalList;

        public Stack()
        {
            this.InternalList = new List<char>();
        }

        public void Push(char x)
        {
            InternalList.Add(x);
        }

        public char Pop()
        {
            char lastChar = Peek();
            InternalList.RemoveAt(InternalList.Count - 1);
            return lastChar;
        }

        public char Peek()
        {
            return InternalList[InternalList.Count - 1];
        }

        public bool IsEmpty
        {
            get { return InternalList.Count == 0; }
        }

        public int Size
        {
            get { return InternalList.Count; }
        }
    }
}