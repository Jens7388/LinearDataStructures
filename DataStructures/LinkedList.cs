using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList<T> : LinearDataStructure<Node<T>>
    {
        private bool isEmpty;

        public LinkedList(int initialLength) : base (initialLength: initialLength)
        {
            length = initialLength;
        }

        public virtual void ReplaceFirst(Node<T> newNode)
        {
            if(IsEmpty)
            {

            }
            else
            {
                Items[0] = newNode;
            }
        }

        public virtual void ReplaceRest(LinkedList<T> newList)
        {
            if(IsEmpty)
            {

            }
            else
            {
                int j = 0;
                for(int i = 1; i < Count - 1; i++)
                {
                    Items[i] = newList.Items[j];
                }
            }
        }

        public virtual bool IsEmpty
        {
            get
            {
                return Count == 0;
            }
            set
            {
                isEmpty = value;
            }
        }    
    }
}
