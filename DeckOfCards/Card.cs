using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    interface IRandomizable
    {
        void Randomize();
    }
    public class Card
    {
        public string StringVal;
        public string Suit;
        public int Val;
        public Card(string stringVal, string suit, int val)
        {
            StringVal = stringVal;
            Suit = suit;
            Val = val;
        }
    }
    public class Deck : IRandomizable
    {
        private List<Card> cards;
        public Deck()
        {
            cards = new List<Card>();
            populateDeck();
        }
        private void populateDeck()
        {
            string[] suits = {"Spade", "Heart", "Diamond", "Club"};
            string[] stringV = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            for(int i = 0; i<suits.Length; i++){
                for(int j = 0; j < 13; j++){
                    cards.Add(new Card(stringV[j], suits[i], j+1));
                    // Console.WriteLine($"{stringV[j]} {suits[i]} {j+1}");
                }
            }
        }
        public void SeeCards()
        {
            foreach(Card card in cards){
                Console.WriteLine($"{card.Suit} of {card.StringVal} - value {card.Val}");
            }
        }
        public void Randomize()
        {
            Random rand = new Random();
            for(int i = 0; i<cards.Count; i++){
                Card CurrentIndex = cards[i];
                int randomIndex = rand.Next(0,cards.Count);
                cards[i] = cards[randomIndex];
                cards[randomIndex] = CurrentIndex;
            }
        }
        public Card Deal()
        {
            Card topCard = cards[0];
            cards.RemoveAt(0);
            Console.WriteLine($"Card dealt: {topCard.Suit} of {topCard.StringVal}");
            return topCard;
        }
        public void Reset()
        {
            cards = null;
            cards = new List<Card>();
            populateDeck();
        }
    }
}