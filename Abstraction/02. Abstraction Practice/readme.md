# Abstraction Practice

Let's work on a prototype card game that will eventually be added to Age of Dragons.

## Assignment

Finish the `DeckOfCards` class. The `Suits` and `Ranks` of each card have been provided for you as `static` (class) variables. You won't need to modify them, but you will need to use them.

1. [ ] Complete the constructor:
   1. [ ] Initialize a `private` empty list called `_cards`.
   2. [ ] Fill that empty list by calling the `CreateDeck` method within the constructor.
2. [ ] Complete the `CreateDeck()` method:
   1. [ ] Create a `(Rank, Suit)` **tuple** for all 52 cards in the deck and add them to the `_cards` list.

Order matters! The cards should be added to the list in the following order: all ranks of hearts, then diamonds, then clubs, and finally spades. Within each suit, the cards should be ordered from lowest rank (Ace) to highest rank (King).

3. [ ] Complete the `ShuffleDeck()` method:
   1. [ ] Use the [Random.Shuffle()](https://learn.microsoft.com/dotnet/api/system.random.shuffle) method to shuffle the `_cards` in the deck.
4. [ ] Complete the `DealCard()` method:
   1. [ ] Remove the first card off the top of the deck (top of the deck is the *end* of the list) and return it. If there are no cards left in the deck the method should instead return `null`.
