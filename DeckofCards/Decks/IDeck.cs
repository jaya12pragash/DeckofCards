﻿using System.Collections.Generic;
using DeckofCards.Cards;
using DeckofCards.Dealing;

namespace DeckofCards.Decks
{
    public interface IDeck
    { 
        void Shuffle(int iterations = 1);
        void Cut(int iterations = 1);
        List<ICard> Cards { get; }
        IEnumerable<IEnumerable<ICard>> Deal(DealingOptions options = null);
        ICard Draw();
    }
}
