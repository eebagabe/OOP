using System.Runtime.InteropServices;

namespace ObjectOriented.Abstraction.AbstractionPractice;

public class DeckOfCards
{
    public static readonly string[] Suits = ["Hearts", "Diamonds", "Clubs", "Spades"];
    public static readonly string[] Ranks =
    [
        "Ace",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "Jack",
        "Queen",
        "King",
    ];

    private List<(string Rank, string Suit)> _cards;

    public DeckOfCards()
    {
        _cards = [];
        CreateDeck();
    }

    public void CreateDeck()
    {
        foreach (var suit in Suits)
        {
            foreach (var rank in Ranks)
            {
                _cards.Add((rank, suit));
            }
        }
    }

    public void ShuffleDeck()
    {
        Random.Shared.Shuffle(CollectionsMarshal.AsSpan(_cards));
    }

    public (string Rank, string Suit)? DealCard()
    {
        if (_cards.Count == 0)
        {
            return null;
        }

        var card = _cards[^1];
        _cards.RemoveAt(_cards.Count - 1);
        return card;
    }

    // don't touch below this line
    public override string ToString()
    {
        return $"The deck has {_cards.Count} cards";
    }
}
