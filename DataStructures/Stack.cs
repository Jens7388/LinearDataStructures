using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Stack<T> : LinearDataStructure<T>
    {

        public Stack(int initialLength) : base(initialLength: initialLength)
        {
            length = initialLength;
        }

        public virtual void Push(T item)
        {
            Insert(item, 0);
        }

        public virtual void Pop()
        {
            Remove(0);
        }
    }
}
