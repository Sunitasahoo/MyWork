using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
   public class CircularLinkedLis<T>
    {
        Node<T> head = null;
        Node<T> tail = null;
        public void AddLast(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;
            if (head==null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                tail.next = newItem;
                tail = newItem;
                tail.next = head;
            }
        }
        public void AddFirst(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                newItem.next = head;
                head = newItem;
                tail.next = head;
            }
        }
        public void ReadAll()
        {
            Node<T> current = head;
            while(current.next!=head)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
            Console.WriteLine(current.next.data);
        }
        public void Remove()
        {

        }
    }
}
