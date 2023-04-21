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
}