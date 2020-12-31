using DeckofCards.Ranks;
using DeckofCards.Suits;

namespace DeckofCards.Cards
{
    public interface ICard
    {
        IRank Rank { get; }
        ISuit Suit { get; }
    }
}
