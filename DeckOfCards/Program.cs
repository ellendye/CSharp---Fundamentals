using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck standard = new Deck();
            standard.Randomize();
            // standard.SeeCards();
            // standard.Reset();
            standard.SeeCards();
            Player ellen = new Player("Ellen");
            ellen.Draw(standard.Deal());
            ellen.Draw(standard.Deal());
            ellen.Draw(standard.Deal());
            ellen.SeeHand();
            Console.WriteLine(ellen.Discard(6));
            ellen.SeeHand();
            Console.WriteLine(ellen.Discard(0));
            ellen.SeeHand();

        }
    }
}
