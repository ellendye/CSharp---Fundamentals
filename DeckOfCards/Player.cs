using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player 
    {
        public string Name;
        public List<Card> hand;
        public Player(string name)
        {
            hand = new List<Card>();
            Name = name;
        }
        public void Draw(Card card)
        {
            hand.Add(card);
        }
        public void SeeHand()
        {
            Console.WriteLine($"{Name}'s hand");
            for (int i = 0; i<hand.Count; i++)
            {
                Console.WriteLine($"{hand[i].StringVal} of {hand[i].Suit}");
            }
        }
        public Card Discard(int index)
        {
            if (index >= hand.Count){
                return null;
            }
            Card discard = hand[index];
            hand.RemoveAt(index);
            return discard;
        }
    }
}