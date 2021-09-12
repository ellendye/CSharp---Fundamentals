using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList x = new SinglyLinkedList();
            x.Add(1);
            x.Add(9);
            x.Add(8);
            x.Add(4);
            x.Add(2);
            x.Display();
            x.Remove();
            Console.WriteLine("-----");
            x.Display();
            x.Remove();
            x.Remove();
            x.Remove();
            x.Remove();
            x.Remove();

            x.Add(532);
            Console.WriteLine("-----");
            x.Display();
        }
    }
}
