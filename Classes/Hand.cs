namespace CardDealer.Classes
{
    public class Hand
    {
        public int HandTotal { get; set; }
        public int HandNumber { get; set; }
        public int HandSize { get; set; }
        public List<CardClass> Cards { get; set; } = new();
    }
}
