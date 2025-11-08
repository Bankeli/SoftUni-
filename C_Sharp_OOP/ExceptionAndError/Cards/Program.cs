namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cardsData = Console.ReadLine()
                 .Split(",", StringSplitOptions.RemoveEmptyEntries);
            var deck = new List<Card>();

            foreach (var cardData in cardsData)
            {
                var parts = cardData.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var face = parts[0];
                var suit = parts[1];

                try
                {
                    var card = new Card(face, suit);
                    deck.Add(card);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(string.Join(" ",deck));





        }

        public class Card
        {
            private static string[] validFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            private static string[] validSuit = { "S", "H", "D", "C" };
            public Card(string face, string suit)
            {
                Face = face;
                Suit = suit;
                this.ValidateSuit(suit);
                this.ValidateFace(face);
            }

            public string Face { get; private set; }
            public string Suit { get; private set; }

            public override string ToString()
            {
                string suitSymbol = string.Empty;
                switch (this.Suit)
                {
                    case "S":
                        this.Suit = "\u2660";
                        break;
                    case "H":
                        this.Suit = "\u2665";
                        break;
                    case "D":
                        this.Suit = "\u2666";
                        break;
                    case "C":
                        this.Suit = "\u2663";
                        break;
                }
                return $"[{this.Face}{this.Suit}]";
            }

            private void ValidateSuit(string suit)
            {
                if (!validSuit.Contains(suit))
                    throw new Exception("Invalid card!");
            }
            private void ValidateFace(string face)
            {
                if (!validFaces.Contains(face))
                    throw new Exception("Invalid card!");
            }

        }
    }
}
