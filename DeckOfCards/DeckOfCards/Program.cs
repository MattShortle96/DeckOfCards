using System;
using System.Collections.Generic;

namespace DeckOfCards

    //Created by Matthew Shortle
    //July 19, 2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var cards = new List<string> { "2d", "2s", "2c", "2h",
            "3d", "3s", "3c", "3h",
            "4d", "4s", "4c", "4h",
            "5d", "5s", "5c", "5h",
            "6d", "6s", "6c", "6h",
            "7d", "7s", "7c", "7h",
            "8d", "8s", "8c", "8h",
            "9d", "9s", "9c", "9h",
            "10d", "10s", "10c", "10h",
            "Jd", "Js", "Jc", "Jh",
            "Qd", "Qs", "Qc", "Qh",
            "Kd", "Ks", "Kc", "Kh",
            "Ad", "As", "Ac", "Ah",};

           var shuffledDeck = new List<string>(52);

           for(int i = 0; i < 52; i++)
           {
            string card = cards[random.Next(0, cards.Count)];
            cards.Remove(card);
            shuffledDeck.Add(card);

           }
            Console.WriteLine(string.Join(System.Environment.NewLine, shuffledDeck));

        }
    }
}
