using System;
using System.Collections.Generic;

namespace DeckOfCards

    //Created by Matthew Shortle
    //July 19, 2021
    //Modified: September 29, 2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var cards = new List<string> { "3c", "Js", "2d", "10h", "Kh", "8s", "Ac", "4h" };

            var sortDeck = new List<string>(8);

           for(int i = 0; i < 8; i++)
           {
            string card = cards[random.Next(0, cards.Count)];
            cards.Remove(card);
            sortDeck.Add(card);

           }
            Console.WriteLine(string.Join(System.Environment.NewLine, sortDeck));

        }
    }
}
