namespace DeckofCards.Ranks
{
    public interface IRank
    {
        int Value { get; }
        string Symbol { get; }
        string Name { get; }
    }
}
