using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {
        protected T _data;
        public Node(T data)
        {
            _data = data;
        }
    }
}
