using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure program!");
            Console.WriteLine("Adding nodes in sequence as given");
            Custom_LinkedList custom_LinkedList = new Custom_LinkedList();
            custom_LinkedList.AddFirst(70);
            custom_LinkedList.AddFirst(30);
            custom_LinkedList.AddFirst(56);
            custom_LinkedList.Display();
        }
    }
}