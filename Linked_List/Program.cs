using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure program!");
            Console.WriteLine("Appending LinkedList!");
            Custom_LinkedList custom_LinkedList = new Custom_LinkedList();
            custom_LinkedList.Append(56);
            custom_LinkedList.Append(30);
            custom_LinkedList.Append(70);
            custom_LinkedList.Display();
        }
    }
}