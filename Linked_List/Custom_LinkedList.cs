﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class Custom_LinkedList
    {
        public Node head;

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} node is added into linkedlist", newNode.data);
            }
            else
            {
                newNode.next = head;
                head = newNode;
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
    }
}
