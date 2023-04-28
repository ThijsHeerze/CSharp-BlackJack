namespace BlackJack;

public class Dealer
{
    private Deck deck = new Deck();
    private Hand hand = new Hand();

    public void ShuffleDeck()
    {
        deck.Shuffle();
    }

    //functie die de kaarten deelt en toevoegd aan de hand en laat FaceValue "unknown"
    public void DealCards(Player[] players)
    {
        foreach (Player player in players)
        {
            Card card = deck.Deal();
            player.AddCardToHand(card);
        }

        Card dealerCard = deck.Deal();
        hand.AddCard(dealerCard);

        foreach (Player player in players)
        {
            Card card = deck.Deal();
            player.AddCardToHand(card);
        }

        dealerCard = deck.Deal();
        dealerCard.FaceValue = "Unknown";
        hand.AddCard(dealerCard);
    }

    //functie voor de speler(s) beurt en voor de dealers beurt
    public void Play(Player[] players)
    {
        while (true)
        {
            bool allPlayersStand = true;

            foreach (Player player in players)
            {
                if (player.GetHand().GetTotalValue() < 21 && player.WantsToHit())
                {
                    Card card = deck.Deal();
                    player.AddCardToHand(card);
                    Console.WriteLine("{0} drew {1} of {2}", player.GetName(), card.FaceValue, card.Suit);
                    allPlayersStand = false;
                }
            }

            if (allPlayersStand)
            {
                break;
            }
        }

        Console.WriteLine("Dealer's turn:");

        while (hand.GetTotalValue() < 17)
        {
            Card card = deck.Deal();
            hand.AddCard(card);
            Console.WriteLine("Dealer drew {0} of {1}", card.FaceValue, card.Suit);
        }

        Console.WriteLine("Dealer stands.");
    }

    //deze functie zorgt ervoor dat je kunt achterhalen wie de winnaar is
    public string DetermineWinner(Player[] players)
    {
        string winner = "";
        int highestTotalValue = 0;

        foreach (Player player in players)
        {
            int totalValue = player.GetHand().GetTotalValue();

            if (totalValue > highestTotalValue && totalValue <= 21)
            {
                highestTotalValue = totalValue;
                winner = player.GetName();
            }
        }

        if (hand.GetTotalValue() > highestTotalValue && hand.GetTotalValue() <= 21)
        {
            winner = "Dealer";
        }

        return winner;
    }

    //functie die laat zien welke kaarten de dealer heeft en welke kaarten jij in je hand hebt
    public void ShowHands(Player[] players)
    {
        Console.WriteLine("Dealer's hand:");

        foreach (Card card in hand.GetCards())
        {
            Console.WriteLine("{0} of {1}", card.FaceValue, card.Suit);
        }
        Console.WriteLine();

        foreach (Player player in players)
        {
            Console.WriteLine("{0}'s hand:", player.GetName());

            foreach (Card card in player.GetHand().GetCards())
            {
                Console.WriteLine("{0} of {1}", card.FaceValue, card.Suit);
            }
            Console.WriteLine();
        }
    }
}