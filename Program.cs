using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleLinkedListTailGenerics<string> linkedList = new SimpleLinkedListTailGenerics<string>();
            //DoubleLinkedList<string> linkedList = new DoubleLinkedList<string>();
            CircularLinkedLis<string> linkedList = new CircularLinkedLis<string>();
            linkedList.AddLast("1");
            linkedList.AddLast("2");
            linkedList.AddLast("3");
            linkedList.AddLast("4");
            linkedList.AddFirst("First");
            linkedList.ReadAll();
            Console.WriteLine("----------------------");
            //linkedList.ReadReverse();
            Console.WriteLine("----------------------");

            SimpleLinkedListTailGenerics<int> linkedListint = new SimpleLinkedListTailGenerics<int>();
            linkedListint.AddLast(1);
            linkedListint.AddLast(2);
            linkedListint.AddLast(3);
            linkedListint.AddLast(4);
            linkedListint.AddFirst(0);
            linkedListint.ReadAll();
            Console.ReadLine();
        }
    }
}
