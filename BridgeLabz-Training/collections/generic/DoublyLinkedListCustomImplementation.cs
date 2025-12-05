using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections.generic
{

    internal class DNode
    {
        internal int data;
        internal DNode next;
        internal DNode prev;
        internal DNode(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }

    internal class DoublyLinkedList
    {
        internal DNode head;

        internal void InsertFront(int new_data)
        {
            DNode new_node = new DNode(new_data);

            if (head == null)
            {
                
                head = new_node;
            }
            else
            {
                new_node.next = head;
                head.prev = new_node;
                head = new_node;
            }
        }

        internal void InsertBack(int new_data)
        {
            DNode new_node = new DNode(new_data);

            var temp = head;

            if(head == null)
            {
                head = new_node;
            }
            else
            {
               
                while(temp.next != null)
                {

                    temp = temp.next;
             
                }

                temp.next = new_node;
                new_node.prev = temp;
            }
        }

        internal void RemoveFront()
        {
            if(head == null)
            {
                Console.WriteLine("Cant remove, no element in linked list");
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
                Console.WriteLine("cant remove, no element in linked list");
            }
            else
            {
                var temp = head;
                while(temp.next.next != null)
                {
                    temp = temp.next;
                }

                temp.next.prev = null;
                temp.next = null;
            }
        }

        internal void RemoveByData(int data)
        {
            var temp = head;

            while (temp != null)
            {
                if(temp.data == data)
                {
                    temp.prev.next = temp.next;
                    temp.next.prev = temp.prev;

                    return;
                }

                temp = temp.next;
            }
        }

        internal void Display()
        {

            var temp = head;

            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }

    internal class DoublyLinkedListCustomImplementation
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.InsertFront(2);
            dll.InsertFront(1);
            dll.InsertFront(0);
            dll.InsertBack(3);
            dll.InsertBack(4);
            dll.InsertBack(5);
            dll.InsertBack(6);
            dll.RemoveBack();
            dll.RemoveFront();
            dll.RemoveByData(4);
            dll.Display();
            
        }
    }
}
