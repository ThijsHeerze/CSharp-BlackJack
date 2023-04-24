namespace BlackJack;

using System;

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
        this.number = 0; // default value
        this.cardName = $"{name} of {color}";

    }
	public string getCardName(int n2)
	{
        return $"{name} of {color} ({n2})";
    }
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
	public string toString()
	{
        return $"{cardName} ({value})";
    }
}

/*Er zijn vijf velden zoals gespecificeerd: name, color, value, number, en cardName.
Er zijn twee eigenschappen: CardName, die alleen een getter heeft om de cardName-veldwaarde terug te geven, en Value, die zowel een getter als een setter heeft om de value-veldwaarde te krijgen of instellen.
Er is één constructor die drie parameters verwacht: name, color en value. De waarden van deze parameters worden gebruikt om de overeenkomstige velden in te stellen. number wordt op 0 gezet als standaardwaarde.
Er zijn drie methoden: GetCardName, die een kaartnaam teruggeeft met een optioneel nummerargument toegevoegd; GetPoints, die een puntenaantal teruggeeft op basis van de naam van de kaart; en ToString, die een tekenreeksrepresentatie van de kaart teruggeeft in het formaat "naam van kleur (waarde)".
*/