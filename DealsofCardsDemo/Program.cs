using System;
using System.Linq;
using System.Collections.Generic;
using DeckofCards.Decks;
using DeckofCards.Dealing;
using DeckofCards.Extensions;

namespace DealsofCardsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CreateDeck");
            Console.WriteLine();
            var deck = new StandardDeck(); //or whatever deck you pick

            var beforeSorting = from u in deck.Cards
                                let r = u.Rank
                                let s = u.Suit
                                select new
                                {
                                    RankName = r.Name,
                                    RankSymbol = r.Symbol,
                                    RankValue = r.Value
                                };
            Console.WriteLine("Listing Decks of before Shuffle the Cards");

            foreach (var results in beforeSorting)
            {
                Console.WriteLine("{0},{1},{2}", results.RankName, results.RankSymbol, results.RankValue);
            }


            deck.Shuffle(); //shuffle the cards for one iteration

            var afterSorting = from u in deck.Cards
                               let r = u.Rank
                               let s = u.Suit
                               select new
                               {
                                   RankName = r.Name,
                                   RankSymbol = r.Symbol,
                                   RankValue = r.Value
                               };
            Console.WriteLine();

            Console.WriteLine("Listing Decks of After Shuffle the Cards");
            foreach (var results in afterSorting)
            {
                Console.WriteLine("{0},{1},{2}", results.RankName, results.RankSymbol, results.RankValue);
            }
            Console.WriteLine();
            Console.WriteLine("Sorting the Cards by Suit");
            Console.WriteLine();

            var sortedCards = from sortCards in deck.Cards
                              orderby sortCards.Suit descending
                              select sortCards;
            CardDeckSorter.Sort(deck.Cards, null);

            var sortBySuit = from u in deck.Cards
                             let r = u.Rank
                             let s = u.Suit
                             select new
                             {
                                 RankName = r.Name,
                                 RankSymbol = r.Symbol,
                                 RankValue = r.Value
                             };
            foreach (var resultsSuit in sortBySuit)
            {
                Console.WriteLine("{0},{1},{2}", resultsSuit.RankName, resultsSuit.RankSymbol, resultsSuit.RankValue);
            }
            Console.WriteLine();

            Console.WriteLine("DealCards with Dealing Options");
            Console.WriteLine();


            var options = new DealingOptions
            {
                Groups = 1,
                CardsPerGroup = 52,
                AsEvenPiles = false
            };
            deck.Deal(options); //deal out the cards with some options as IEnumerable<IEnumberable<ICard>>

            Console.WriteLine("-----------Program End--------------");
            Console.Read();
        }
    }
}
