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

        public virtual void Push(Queue<T> queue, T item)
        {
            queue.Insert(item, queue.Count);
        }

        public virtual void Pop(Queue<T> queue)
        {
            queue.Remove(0);
        }
    }
}
