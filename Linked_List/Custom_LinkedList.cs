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

        public void SearchNode(int input)
        {
            if (head == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            else
            {
                Node temp = head;
                bool isPresent = false;
                while (temp != null)
                {
                    if (temp.data == input)
                    {
                        Console.WriteLine("{0} node is present", input);
                        isPresent = true;
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                if (!isPresent)
                {
                    Console.WriteLine("{0} node is not present", input);
                }
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
    }
}
