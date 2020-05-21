using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    public class Node
    {
        public object data = null;
        public Node next = null;
    }
    public class Node<T>
    {
        public T data = default(T);
        public Node<T> next = null;
    }
    public class NodeDouble<T> : Node<T>
    {
        public NodeDouble<T> next = null;
        public NodeDouble<T> prev = null;
    }
}
