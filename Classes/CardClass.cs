using CardDealer.Enums;

namespace CardDealer.Classes
{
    public class CardClass
    {
        public int CardId { get; set; }
        public SuitType Suit { get; set; }
        public CardName Name { get; set; }
        public string NameString
        {
            get
            {
                return Enum.GetName(typeof(CardName), Name);
            }
        }
        public int Value
        {
            get
            {
                int _value;
                if (Name == CardName.Ace)
                {
                    _value = 1;
                }
                else if (Name == CardName.Jack || Name == CardName.Queen || Name == CardName.King)
                {
                    _value = 10;
                }
                else
                {
                    _value = (int)Name;
                }   
                return _value;
            }
        }
    }
}
