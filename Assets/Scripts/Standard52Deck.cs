using System;
using System.Collections.Generic;
using UnityEngine;

public class Standard52Deck
{
    List<Card> deck = new List<Card>();

    enum Ranks
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    enum Suits
    {
        Hearts,
        Spades,
        Clubs,
        Diamonds,
    }

    class Card
    {
        readonly Ranks rank;
        readonly Suits suit;

        public Card(Ranks rank, Suits suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{rank} of {suit}";
        }
    }

    IEnumerable<Card> GetSortedCardsBySuits()
    {
        var rankCount = Enum.GetValues(typeof(Ranks));
        var suitCount = Enum.GetValues(typeof(Suits));
        var deckCount = rankCount.Length * suitCount.Length;

        var index = 0;
        var rankIteration = 0;

        while (index < deckCount)
        {
            var rank = (Ranks)(index % 13);
            if (rank == 0 && index != 0)
            {
                rankIteration++;
            }
            var suit = (Suits)(rankIteration);

            index++;
            yield return new Card(rank, suit);
        }
    }

    void CreateSortedCards()
    {
        foreach (var card in GetSortedCardsBySuits())
        {
            deck.Add(card);
        }
    }

    void Start()
    {
        CreateSortedCards();
    }
}