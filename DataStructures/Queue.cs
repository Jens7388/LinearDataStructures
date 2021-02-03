using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Queue<T>: LinearDataStructure<T>
    {
        public Queue(int initialLength) : base(initialLength: initialLength)
        {
            length = initialLength;
        }

        public virtual void Push(T item)
        {
            Insert(item, Count);
        }

        public virtual void Pop()
        {
            Remove(0);
        }

        public virtual void Inverse()
        {
            int i = 0;
            int j = Count - 1;
            while(j > i)
            {
                (Items[i], Items[j]) = (Items[j], Items[i]);
                i++;
                j--;
            }
        }
    }
}