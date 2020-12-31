using DeckofCards.Ranks;
using DeckofCards.Suits;

namespace DeckofCards.Cards
{
    public class StandardCard : CardBase
    {
        public StandardCard(ISuit suit, IRank rank) : base(suit, rank)
        {
        }
    }
}
