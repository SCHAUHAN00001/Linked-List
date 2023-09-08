using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        public class Node
        {
            public int element;
            public Node Next;
            public Node(int e, Node n)
            {
                element = e;
                Next = n;
            }
        }
        class LinkedList
        {
            private Node head;
            private Node tail;
            private int size;
            public LinkedList()
            {
                head = null;
                tail = null;
                size = 0;
            }
            public int length()
            {
                return size;
            }
            public bool isEmpty()
            {
                return size == 0;
            }
            public void addLast(int e)
            {
                Node newest = new Node(e, null);
                if (isEmpty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    tail.Next = newest;
                    tail = newest;


                }
                size = size + 1;
            }
            public void addFirst(int e)
            {
                Node newest = new Node(e, null);
                if (isEmpty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    newest.Next = head;
                    head = newest;
                }
                size = size + 1;
            }
            public void addAnywhere(int e, int position)
            {
                Node newest = new Node(e, null);
                Node p = head;
                int i = 1;
                while (i < position - 1)
                {
                    p = p.Next;
                    i = i + 1;
                }
                newest.Next = p.Next;
                p.Next = newest;
                size = size + 1;

            }
            public int removeFirst()
            {
                if (isEmpty())
                {
                    Console.WriteLine("List is empty");
                    return -1;
                }
                int e = head.element;
                head = head.Next;
                size = size - 1;
                if (isEmpty())
                {
                    tail = null;
                }
                return e;
            }
            public int removeLast()
            {
                if (isEmpty())
                {
                    Console.WriteLine("List is empty");
                    return -1;

                }
                Node p = head;
                int i = 1;
                while (i < length() - 1)
                {
                    p = p.Next;
                    i = i + 1;

                }
                tail = p;
                p = p.Next;
                int e = p.element;
                tail.Next = null;
                size = size - 1;
                return e;

            }
            public int removeAnywhere(int position)
            {
                Node p = head;
                int i = 1;
                while (i < position - 1)
                {
                    p = p.Next;
                    i = i + 1;
                }
                int e = p.Next.element;
                p.Next = p.Next.Next;
                size = size - 1;
                return e;

            }
            public int Searching(int key)
            {
                Node p = head;
                int index = 0;
                while (p != null)
                {
                    if (p.element == key)
                    {
                        return index;
                    }
                    p = p.Next;
                    index++;

                }
                return -1;
            }
            public void InsertSortedList(int e)
            {
                Node newest = new Node(e, null);
                if (isEmpty())
                {
                    head = newest;


                }
                else
                {
                    Node p = head;
                    Node q = head;
                    while(p != null && p.element < e) 
                    {
                        q = p;
                        p= p.Next;
                    }
                    if (p == head)
                    {
                        newest.Next = head;
                        head = newest;
                    }
                    else
                    {
                        newest.Next = q.Next;
                        q.Next = newest;
                       
                    }
                }
                size = size + 1;
            }
            public void display()
            {
                Node p = head;
                while (p != null)
                {
                    Console.WriteLine(p.element);
                    p = p.Next;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Creating LinkList: ");
            linkedList.addLast(1);
            linkedList.addLast(2);
            linkedList.addLast(3);
            linkedList.addLast(4);
            linkedList.addLast(5);
            linkedList.display();
            Console.WriteLine("Size: " + linkedList.length());
            Console.WriteLine("Adding 15 in first position: ");

            linkedList.addFirst(15);
            linkedList.display();
            Console.WriteLine("Size: " + linkedList.length());
            Console.WriteLine("Add 55 on 6 position: ");


            linkedList.addAnywhere(55, 6);

            linkedList.display();
            Console.WriteLine("Size: " + linkedList.length());
            Console.WriteLine("Removing first element: ");

            linkedList.removeFirst();
            linkedList.display();
            Console.WriteLine("Size: " + linkedList.length());
            Console.WriteLine("Removing last element: ");



            linkedList.removeLast();
            linkedList.display();
            Console.WriteLine("Size: " + linkedList.length());
            Console.WriteLine("Removing element on position 3");



            linkedList.removeAnywhere(3);

            linkedList.display();
            Console.WriteLine("Size: " + linkedList.length());
            Console.WriteLine("Searching element 2:  ");
            Console.WriteLine("index: " + linkedList.Searching(2));
            linkedList.display();
            Console.WriteLine("Size: " + linkedList.length());
            LinkedList linkedList1 = new LinkedList();
            Console.WriteLine("Creating a new sorted linklist using unsorted element: (5,6,9,1,2) ");

            linkedList1.InsertSortedList(5);
            linkedList1.InsertSortedList(6);
            linkedList1.InsertSortedList(9);
            linkedList1.InsertSortedList(1);
            linkedList1.InsertSortedList(2);
            linkedList1.display();
            Console.WriteLine("Size: " + linkedList1.length());

            Console.ReadLine();
        }

    }
}
