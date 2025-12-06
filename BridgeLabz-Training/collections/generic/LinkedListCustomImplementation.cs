using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections.generic
{

    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class SingleLinkedList
    {
        internal Node head;         //singly linked list has only head when its intantianted 

        internal void InsertFront(SingleLinkedList singleLL, int new_data)
        {
            Node new_node = new Node(new_data);      //new node created
            new_node.next = singleLL.head;          //next of this node is given to head
            singleLL.head = new_node;              //new node becomes the new head
        }

        internal void InsertBack(SingleLinkedList singleLL, int new_data)
        {
            Node new_node = new Node(new_data); 

            if (singleLL.head == null)
            {
                singleLL.head = new_node;
                return;
            }


            Node temp = singleLL.head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new_node;
            
        }

        internal void RemoveFront()
        {
            if(head == null)
            {
                Console.WriteLine("Cant remove, no element");
            }
            else
            {
                head = head.next;

            }
        }

        internal void RemoveBack()
        {
            if(head == null)
            {
                Console.WriteLine("Cant remove, no elements");
            }
            else
            {
                var temp = head;
                while(temp.next != null && temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }

        internal void Display()
        {
            Node temp = head;
           
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        internal void ReverseDisplay()
        {
            Node temp = head;

            List<int> elements = new List<int>();


            while (temp != null)
            {
                elements.Add(temp.data);
                temp = temp.next;
            }

            elements.Reverse();

            foreach(int i in elements)
            {
                Console.WriteLine(i);   
            }
        }

        internal void Search(int data)
        {
            var temp = head;

            bool found = false;

            int index = 1;
            
            while (temp != null)
            {
                if(temp.data == data)
                {
                    Console.WriteLine("element found at index " + index);
                    found = true;
                }
                temp = temp.next;
                index++;
            }

            if(found == false)
            {
                Console.WriteLine("No " + data + " found in the linked list");
                return;
            }
            else
            {
                return;
            }
        }
            
    }
  
    internal class LinkedListCustomImplementation
    {
        static void Main(string[] args)
        {
            SingleLinkedList sll = new SingleLinkedList();
            sll.InsertFront(sll, 3);
            sll.InsertFront(sll, 2);
            sll.InsertFront(sll, 1);
            sll.InsertBack(sll, 4);
            sll.InsertBack(sll, 5);
            sll.InsertBack(sll, 6);
            sll.RemoveBack();
            sll.RemoveFront();
            sll.Display();
            Console.WriteLine(" ");
            sll.ReverseDisplay();
            Console.WriteLine(" ");
            sll.Search(4);
        }
    }
}

