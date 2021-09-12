// using System;
// using System.Collections.Generic;

// namespace DeckOfCards
// {
//     class Deck
//     {
//         public List<Card> cards;
//         public Deck()
//         {
//             cards = new List<Card>();
//             string[] suit = {"spades", "hearts", "clubs", "diamonds"};
//             string[] stringV = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
//             for (int i = 1; i<=13; i++){
//                 for(int j = 0; j<4; j++){
//                     cards.Add(new Card(stringV[i-1],suit[j], i));
//                 }
//             }            
//         }
//         public void Shuffle()
//         {
//             Random rand = new Random();
//             for(int i = 0; i<cards.Count; i++){
//                 Card CurrentIndex = cards[i];
//                 int randomIndex = rand.Next(0,cards.Count);
//                 cards[i] = cards[randomIndex];
//                 cards[randomIndex] = CurrentIndex;
//             }
//         }
//         public void Reset()
//         {
//             cards = null;
//             cards = new List<Card>();
//             string[] suit = {"spades", "hearts", "clubs", "diamonds"};
//             string[] stringV = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
//             for (int i = 1; i<=13; i++){
//                 for(int j = 0; j<4; j++){
//                     cards.Add(new Card(stringV[i-1],suit[j], i));
//                 }
//             } 
//         }
//         public Card topCard;
//         // public Card Deal()
//         // {
//         //     topCard = new Card();
//         //     topCard = cards.RemoveAt(0);
//         //     // return topCard;
//         // }
//         public void SeeCards()
//         {
//             for(int i = 0; i<cards.Count;i++){
//                 Console.WriteLine($"{cards[i].StringVal} of {cards[i].Suit}, Card value: {cards[i].Val}");
//             }
//         }
//     }
// }
