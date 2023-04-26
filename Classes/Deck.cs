namespace BlackJack;

public class Deck
{
    public List<Card> cards;

    public Deck()
    {
        cards = new List<Card>();

        cards.Add(new Card("harten", "2", 2));
        cards.Add(new Card("harten", "3", 3));
        cards.Add(new Card("harten", "4", 4));
        cards.Add(new Card("harten", "5", 5));
        cards.Add(new Card("harten", "6", 6));
        cards.Add(new Card("harten", "7", 7));
        cards.Add(new Card("harten", "8", 8));
        cards.Add(new Card("harten", "9", 9));
        cards.Add(new Card("harten", "10", 10));
        cards.Add(new Card("harten", "boer", 10));
        cards.Add(new Card("harten", "vrouw", 10));
        cards.Add(new Card("harten", "heer", 10));
        cards.Add(new Card("harten", "aas", 11));

        cards.Add(new Card("ruiten", "2", 2));
        cards.Add(new Card("ruiten", "3", 3));
        cards.Add(new Card("ruiten", "4", 4));
        cards.Add(new Card("ruiten", "5", 5));
        cards.Add(new Card("ruiten", "6", 6));
        cards.Add(new Card("ruiten", "7", 7));
        cards.Add(new Card("ruiten", "8", 8));
        cards.Add(new Card("ruiten", "9", 9));
        cards.Add(new Card("ruiten", "10", 10));
        cards.Add(new Card("ruiten", "boer", 10));
        cards.Add(new Card("ruiten", "vrouw", 10));
        cards.Add(new Card("ruiten", "heer", 10));
        cards.Add(new Card("ruiten", "aas", 11));

        cards.Add(new Card("schoppen", "2", 2));
        cards.Add(new Card("schoppen", "3", 3));
        cards.Add(new Card("schoppen", "4", 4));
        cards.Add(new Card("schoppen", "5", 5));
        cards.Add(new Card("schoppen", "6", 6));
        cards.Add(new Card("schoppen", "7", 7));
        cards.Add(new Card("schoppen", "8", 8));
        cards.Add(new Card("schoppen", "9", 9));
        cards.Add(new Card("schoppen", "10", 10));
        cards.Add(new Card("schoppen", "boer", 10));
        cards.Add(new Card("schoppen", "vrouw", 10));
        cards.Add(new Card("schoppen", "heer", 10));
        cards.Add(new Card("schoppen", "aas", 11));

        cards.Add(new Card("klaver", "2", 2));
        cards.Add(new Card("klaver", "3", 3));
        cards.Add(new Card("klaver", "4", 4));
        cards.Add(new Card("klaver", "5", 5));
        cards.Add(new Card("klaver", "6", 6));
        cards.Add(new Card("klaver", "7", 7));
        cards.Add(new Card("klaver", "8", 8));
        cards.Add(new Card("klaver", "9", 9));
        cards.Add(new Card("klaver", "10", 10));
        cards.Add(new Card("klaver", "boer", 10));
        cards.Add(new Card("klaver", "vrouw", 10));
        cards.Add(new Card("klaver", "heer", 10));
        cards.Add(new Card("klaver", "aas", 11));
    }
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
    public Card Deal()
    {
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}

/*public Card Deal()
{
    if (nextToDeal >= cardArr.Length)
    {
        return null; // out of cards
    }

    Card card = cardArr[nextToDeal];
    nextToDeal++;
    return card;
}*/