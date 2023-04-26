namespace BlackJack;


public class Hand
{
    private List<Card> cardArr;
    private int nextToDeal;

    public int numCards { get; set; }

    public Hand()
    {
        cardArr = new List<Card>();
        //houdt bij welke kaart de volgende is om uitgedeeld te worden
        nextToDeal = 0;

        //houdt het aantal kaarten in de hand bij
        numCards = 0;
    }

    //toont alle kaarten in hand
    public void display()
    {
        Console.WriteLine("Kaarten in hand:");
        foreach (Card card in cardArr)
        {
            Console.WriteLine(card.ToString());
        }
    }

    //telt punten op van de kaarten in je hand en returnt de totale waarde als int
    public int getPoints()
    {
        int points = 0;
        foreach (Card card in cardArr)
        {
            points += this.getPoints();
        }
        return points;
    }

    //geeft een list van nieuwe kaarten terug, als er nog kaarten zijn om uit te delen
    public List<Card> hit()
    {
        List<Card> newCards = new List<Card>();
        if (nextToDeal < numCards)
        {
            newCards.Add(cardArr[nextToDeal]);
            nextToDeal++;
        }
        return newCards;
    }
}