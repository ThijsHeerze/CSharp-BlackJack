namespace BlackJack;

using System;

public class Card
{
	private string color { get; set; }
	private string name { get; set; }
	private int value { get; set; }

	public Card(string color, string name, int value)
	{
		this.color = color;
		this.name = name;
		this.value = value;

	}
	public void getCardName(string name)
	{

	}
	public void getPoints(string name, int value)
	{

	}
	public void toString(string color, string name, int value)
	{

	}
}