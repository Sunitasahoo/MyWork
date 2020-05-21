using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
   public class DoubleLinkedList<T>
    {
        NodeDouble<T> head = null;
        NodeDouble<T> tail = null;
        public void AddLast(T data)
        {
            NodeDouble<T> newItem = new NodeDouble<T>();
            newItem.data = data;
            if (head==null)
            {
                head = newItem;
                tail = head;
            }
            else
            {
                tail.next = newItem;
                newItem.prev = tail;
                tail = newItem;
            }
        }
        public void AddFirst(T data)
        {
            NodeDouble<T> newItem = new NodeDouble<T>();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                newItem.next = head;
                head.prev = newItem;
                head = newItem;
            }
        }
        public void ReadAll()
        {
            NodeDouble<T> current = head;
            while(current.next!=null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }
        public void ReadReverse()
        {
            NodeDouble<T> current = tail;
            while (current.prev != null)
            {
                Console.WriteLine(current.data);
                current = current.prev;
            }
            Console.WriteLine(current.data);
        }
        public void Remove()
        {

        }
    }
}
