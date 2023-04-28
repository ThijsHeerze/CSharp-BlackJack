namespace BlackJack;

public class Deck
{
    private List<Card> cards = new List<Card>();


    public Deck()
    {
        //array voor suits
        string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        //array voor faceValues
        string[] faceValues = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        foreach (string suit in suits)
        {
            for (int i = 0; i < faceValues.Length; i++)
            {
                int value = i + 1;
                if (i >= 9)
                {
                    value = 10;
                }
                if (i == 0)
                {
                    value = 11;
                }
                Card card = new Card(suit, faceValues[i], value);
                cards.Add(card);
            }
        }
    }

    //functie om de kaarten te kunnen schudden
    public void Shuffle()
    {
        Random random = new Random();

        for (int i = cards.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }

    //functie om kaarten te delen
    public Card Deal()
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}