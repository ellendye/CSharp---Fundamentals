using System;

namespace DataStructures
{
    public class TNode
    {
        public int Value;
        public TNode Next;
        public TNode(int value) 
        {
            Value = value;
            Next = null;
        }
    }


    public class Tries
    {
        public TNode Head;
        public Tries()
        {
            Head = null;
        }
        public void Add(string word)
        {

        }
        public bool Contains(string word)
        {

        }
        public string[] Autocomplete(string prefix)
        {
            
        }
    }
}