using CardDealer.Enums;

namespace CardDealer.Classes
{
    public class Deck
    {
        public List<CardClass> Cards { get; set; }

        public CardClass DrawCard()
        {
            Random random = new Random();
            return this.Cards[random.Next(0, this.Cards.Count)];
        }

        public Deck SetOrderedDeck()
        {
            List<CardClass> cardClasses =
            new List<CardClass>() {
                new CardClass { CardId = 1, Suit = SuitType.Clubs, Name = CardName.Ace },
                new CardClass { CardId = 2, Suit = SuitType.Clubs, Name = CardName.Two },
                new CardClass { CardId = 3, Suit = SuitType.Clubs, Name = CardName.Three },
                new CardClass { CardId = 4, Suit = SuitType.Clubs, Name = CardName.Four },
                new CardClass { CardId = 5, Suit = SuitType.Clubs, Name = CardName.Five },
                new CardClass { CardId = 6, Suit = SuitType.Clubs, Name = CardName.Six },
                new CardClass { CardId = 7, Suit = SuitType.Clubs, Name = CardName.Seven },
                new CardClass { CardId = 8, Suit = SuitType.Clubs, Name = CardName.Eight },
                new CardClass { CardId = 9, Suit = SuitType.Clubs, Name = CardName.Nine },
                new CardClass { CardId = 10, Suit = SuitType.Clubs, Name = CardName.Ten },
                new CardClass { CardId = 11, Suit = SuitType.Clubs, Name = CardName.Jack },
                new CardClass { CardId = 12, Suit = SuitType.Clubs, Name = CardName.Queen },
                new CardClass { CardId = 13, Suit = SuitType.Clubs, Name = CardName.King },
                new CardClass { CardId = 14, Suit = SuitType.Diamonds, Name = CardName.Ace },
                new CardClass { CardId = 15, Suit = SuitType.Diamonds, Name = CardName.Two },
                new CardClass { CardId = 16, Suit = SuitType.Diamonds, Name = CardName.Three },
                new CardClass { CardId = 17, Suit = SuitType.Diamonds, Name = CardName.Four },
                new CardClass { CardId = 18, Suit = SuitType.Diamonds, Name = CardName.Five },
                new CardClass { CardId = 19, Suit = SuitType.Diamonds, Name = CardName.Six },
                new CardClass { CardId = 20, Suit = SuitType.Diamonds, Name = CardName.Seven },
                new CardClass { CardId = 21, Suit = SuitType.Diamonds, Name = CardName.Eight },
                new CardClass { CardId = 22, Suit = SuitType.Diamonds, Name = CardName.Nine },
                new CardClass { CardId = 23, Suit = SuitType.Diamonds, Name = CardName.Ten },
                new CardClass { CardId = 24, Suit = SuitType.Diamonds, Name = CardName.Jack },
                new CardClass { CardId = 25, Suit = SuitType.Diamonds, Name = CardName.Queen },
                new CardClass { CardId = 26, Suit = SuitType.Diamonds, Name = CardName.King },
                new CardClass { CardId = 27, Suit = SuitType.Hearts, Name = CardName.Ace },
                new CardClass { CardId = 28, Suit = SuitType.Hearts, Name = CardName.Two },
                new CardClass { CardId = 29, Suit = SuitType.Hearts, Name = CardName.Three },
                new CardClass { CardId = 30, Suit = SuitType.Hearts, Name = CardName.Four },
                new CardClass { CardId = 31, Suit = SuitType.Hearts, Name = CardName.Five },
                new CardClass { CardId = 32, Suit = SuitType.Hearts, Name = CardName.Six },
                new CardClass { CardId = 33, Suit = SuitType.Hearts, Name = CardName.Seven },
                new CardClass { CardId = 34, Suit = SuitType.Hearts, Name = CardName.Eight },
                new CardClass { CardId = 35, Suit = SuitType.Hearts, Name = CardName.Nine },
                new CardClass { CardId = 36, Suit = SuitType.Hearts, Name = CardName.Ten },
                new CardClass { CardId = 37, Suit = SuitType.Hearts, Name = CardName.Jack },
                new CardClass { CardId = 38, Suit = SuitType.Hearts, Name = CardName.Queen },
                new CardClass { CardId = 39, Suit = SuitType.Hearts, Name = CardName.King },
                new CardClass { CardId = 40, Suit = SuitType.Spades, Name = CardName.Ace },
                new CardClass { CardId = 41, Suit = SuitType.Spades, Name = CardName.Two },
                new CardClass { CardId = 42, Suit = SuitType.Spades, Name = CardName.Three },
                new CardClass { CardId = 43, Suit = SuitType.Spades, Name = CardName.Four },
                new CardClass { CardId = 44, Suit = SuitType.Spades, Name = CardName.Five },
                new CardClass { CardId = 45, Suit = SuitType.Spades, Name = CardName.Six },
                new CardClass { CardId = 46, Suit = SuitType.Spades, Name = CardName.Seven },
                new CardClass { CardId = 47, Suit = SuitType.Spades, Name = CardName.Eight },
                new CardClass { CardId = 48, Suit = SuitType.Spades, Name = CardName.Nine },
                new CardClass { CardId = 49, Suit = SuitType.Spades, Name = CardName.Ten },
                new CardClass { CardId = 50, Suit = SuitType.Spades, Name = CardName.Jack },
                new CardClass { CardId = 51, Suit = SuitType.Spades, Name = CardName.Queen },
                new CardClass { CardId = 52, Suit = SuitType.Spades, Name = CardName.King }
            };
            this.Cards = cardClasses;

            return this;
        }
        
    }
}
