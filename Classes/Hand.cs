namespace BlackJack;


public class Hand
{
    private List<Card> cards = new List<Card>();

    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    //functie om de totale waarde op te halen en returned de totale waarde
    public int GetTotalValue()
    {
        int totalValue = 0;
        int numberOfAces = 0;

        foreach (Card card in cards)
        {
            if (card.Value == 11)
            {
                numberOfAces++;
            }

            totalValue += card.Value;
        }

        while (numberOfAces > 0 && totalValue > 21)
        {
            totalValue -= 10;
            numberOfAces--;
        }

        return totalValue;
    }

    //returned cards
    public List<Card> GetCards()
    {
        return cards;
    }
}