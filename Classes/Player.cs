namespace BlackJack;


public class Player
{
    private Hand hand = new Hand();
    private string Name;

    public Player(string name)
    {
        Name = name;
    }

    public void AddCardToHand(Card card)
    {
        hand.AddCard(card);
    }

    //deze functie vraagt of je een kaart wilt of niet en returned de waarde
    public bool WantsToHit()
    {
        Console.Write("{0}, do you want to hit (y/n)? ", Name);
        string input = Console.ReadLine();

        return input.ToLower() == "y";
    }

    //returned de hand
    public Hand GetHand()
    {
        return hand;
    }

    //returned de naam
    public string GetName()
    {
        return Name;
    }
}