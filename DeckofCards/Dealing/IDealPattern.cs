using System.Collections.Generic;
using DeckofCards.Cards;
using DeckofCards.Decks;

namespace DeckofCards.Dealing
{
    public interface IDealPattern
    {
        IEnumerable<IEnumerable<ICard>> Deal(IDeck deck, DealingOptions options);
    }
}
