namespace BlackJack;

/*
public class Player
{
	//string name { get; set; }
    //string Rank { get; set; }
    //int hitPoints { get; set; }
    private readonly List<Card> hand;

    public Player()
	{
        
    }

    //Adds a Card object to the player's hand.
    public void AddCardToHand(Card card)
    {
        hand.Add(card);
    }
    
    //Calculates the total value of the player's hand, taking into account the value of aces.
    /*public int GetHandValue()
    {
        this.Deck = deck;
        var value = 0;
        var numAces = 0;

        foreach (var card in hand)
        {
            if (card.Rank == Rank.Ace)
            {
                numAces++;
            }
            // || = OR
            else if (card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King)
            {
                value += 10;
            }
            else
            {
                value += (int)card.Rank;
            }
        }

        // Handle aces
        for (var i = 0; i < numAces; i++)
        {
            if (value + 11 > 21)
            {
                value += 1;
            }
            else
            {
                value += 11;
            }
        }

        return value;
    }
    
    //Returns true if the player's hand value exceeds 21.
    public bool IsBroken()
    {
        return GetHandValue() > 21;
    }*/

//Returns true if the player has a blackjack (an ace and a face card or a 10).
/*public bool HasBlackjack()
{
    string Deck;
    if (hand.Count == 2)
    {
        var firstCard = hand[0];
        var secondCard = hand[1];

        // && = AND
        if ((firstCard.Deck == Deck.Ace && (secondCard.Deck == Deck.boer || secondCard.Deck == Deck.Queen || secondCard.Deck == Deck.King))
            || (secondCard.Deck == Deck.Ace && (firstCard.Deck == Deck.Jack || firstCard.Rank == Deck.Queen || firstCard.Rank == Deck.King)))
        {
            return true;
        }
    }
    return false;
}

//Returns a string representation of the player's hand.
public string HandToString()
{
    var handString = "";

    foreach (var card in hand)
    {
        handString += card + " ";
    }

    return handString.Trim();
}

public void getPlayer()
{

}

public void setPlayer()
{

}    
}*/