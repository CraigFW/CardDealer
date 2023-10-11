using CardDealer.Enums;

namespace CardDealer.Classes
{
    public class GameOptions
    {
        public int NumberOfPlayers { get; set; }
        public int NumberOfDecks { get; set; }
        public int NumberOfCardsPerHand { get; set; }
        public GameMode Mode { get; set; }

        public GameOptions(int numberOfPlayers, int numberOfDecks, int numberOfCardsPerHand, GameMode gameMode)
        {
            NumberOfPlayers = numberOfPlayers;
            NumberOfDecks = numberOfDecks;
            NumberOfCardsPerHand = numberOfCardsPerHand;
            Mode = gameMode;
        }
    }
}
