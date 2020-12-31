using DeckofCards.Ranks;
using DeckofCards.Suits;

namespace DeckofCards.Cards
{
    public abstract class CardBase : ICard
    {
        public IRank Rank { get; }
        public ISuit Suit { get; }

        protected CardBase(ISuit suit, IRank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
