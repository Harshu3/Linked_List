using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure program!");
            Console.WriteLine("Insert node into LinkedList!");
            Custom_LinkedList custom_LinkedList = new Custom_LinkedList();
            custom_LinkedList.AddLast(56);
            custom_LinkedList.AddLast(70);
            custom_LinkedList.Display();
            custom_LinkedList.Insert(2, 30);
            Console.WriteLine("After 30 node is added into linked list");
            custom_LinkedList.Display();
        }
    }
}