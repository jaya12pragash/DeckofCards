using System;
using System.Collections.Generic;
using System.Text;
using DeckofCards.Cards;

namespace DeckofCards.Extensions
{
    public class CardDeckSorter
    {
        /// <summary>
        /// Sorts a standard deck of 52 (or any number, really) playing cards in ascending order.
        /// </summary>
        /// <param name="deck">Collection to be sorted</param>
        /// <param name="comparison">Definition of ascending order, which varies by game and geography</param>
        public static void Sort(List<ICard> deck, Comparison<ICard> comparison)
        {
            if (comparison == null)
                return;
            else
            deck?.Sort(comparison);
        }
       
    }
}
