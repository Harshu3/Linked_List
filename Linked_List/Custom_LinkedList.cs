using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Custom_LinkedList
    {
        public Node head;

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} node is added into linkedlist", newNode.data);
            }
            else
            {
                Node temp = GetLastNode();
                temp.next = newNode;
                Console.WriteLine("{0} node is added into linkedlist", newNode.data);
            }
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            else
            {
                Node temp = head;
                Console.WriteLine("\nNodes are:");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n");
            }
        }

        public Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void Insert(int position, int data)
        {
            Node newNode = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            else if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node temp = new Node(data);
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.WriteLine("Previous node is null");
                }
            }
        }
    }
}
