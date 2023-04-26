namespace BlackJack;

public class Card
{
    private string color;
    private string name;
    private int value;
    private int number;
    private string cardName;

    public string CardName
    {
        get { return cardName; }
    }

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
    public Card(string color, string name, int value)
    {
        this.color = color;
        this.name = name;
        this.value = value;
        this.number = 0; // standaard waarde
        this.cardName = $"{name} of {color}";

    }

    //GetCardName, die een kaartnaam teruggeeft met een optioneel nummerargument toegevoegd
    public string getCardName(int n2)
    {
        return $"{name} of {color} ({n2})";
    }

    //GetPoints, die een puntenaantal teruggeeft op basis van de naam van de kaart
    public int getPoints(string name)
    {
        if (name == this.name)
        {
            return this.value;
        }
        else
        {
            return 0;
        }
    }

    //ToString, die een tekenreeksrepresentatie van de kaart teruggeeft in het formaat "naam van kleur (waarde)
    public string toString()
    {
        return $"{cardName} ({value})";
    }
}