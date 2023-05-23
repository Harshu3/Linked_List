using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure program!");
            Console.WriteLine("Removing first node from LinkedList!");
            Custom_LinkedList custom_LinkedList = new Custom_LinkedList();
            custom_LinkedList.AddLast(56);
            custom_LinkedList.AddLast(30);
            custom_LinkedList.AddLast(70);
            custom_LinkedList.Display();
            custom_LinkedList.RemoveFirst();
            custom_LinkedList.Display();
        }
    }
}