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

        internal void Display()
        {
            Node temp = head;
           
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
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
            sll.Display();
        }
    }
}

