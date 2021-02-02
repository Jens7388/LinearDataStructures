using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack<T> : LinearDataStructure<T>
    {
        //private T[] array;

        public Stack(int initialLength) : base(initialLength: initialLength)
        {
            length = initialLength;
           // array = new T[length];
        }

        public void Push(Stack<T> stack, T item)
        {
            stack.Insert(item, 0);
        }

        public virtual void Pop(Stack<T> stack)
        {
            stack.Remove(0);
        }
    }
}
