using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure program!");
            Console.WriteLine("Creating a simple LinkedList");
            Custom_LinkedList custom_LinkedList = new Custom_LinkedList();
            custom_LinkedList.AddLast(56);
            custom_LinkedList.AddLast(30);
            custom_LinkedList.AddLast(70);
            custom_LinkedList.Display();
        }
    }
}