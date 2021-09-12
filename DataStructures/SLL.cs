using System;

namespace DataStructures
{
    public class SllNode
    {
        public int Value;
        public SllNode Next;
        public SllNode(int value) 
        {
            Value = value;
            Next = null;
        }
    }
    public class SinglyLinkedList
    {
        public SllNode Head;
        public SllNode Tail;
        public SinglyLinkedList() 
        {
            Head = null;
            Tail = null;
        }
        // SLL methods go here. As a starter, we will show you how to add a node to the list.
        public void Add(int value) 
        {
            SllNode newNode = new SllNode(value);
            Tail = newNode;
            if(Head == null) 
            {
                Head = newNode;
            } 
            else
            {
                SllNode runner = Head;
                while(runner.Next != null) {
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }
        public void Remove()
        {
            if (Head == null){
                Console.WriteLine("Nothing is in the list to remove");
            }
            else if (Head == Tail){
                Head = Head.Next;
                Tail = Tail.Next;
            }
            SllNode runner = Head;
            while (runner != null)
            {
                if (runner.Next == Tail){
                    runner.Next = runner.Next.Next;
                    Tail = runner;
                }
                runner = runner.Next;
            }
        }
        public void Display()
        {
            SllNode runner = Head;
            while (runner != null)
            {
                Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
        }
    }
}