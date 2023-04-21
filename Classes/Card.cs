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
}

/*string[] cards = {
    schoppen{2, 3, 4, 5, 6, 7, 8, 9, 10, 'boer', 'vrouw', 'heer', 'aas' },
    klaver{2, 3, 4, 5, 6, 7, 8, 9, 10, 'boer', 'vrouw', 'heer', 'aas'},
    harten{2, 3, 4, 5, 6, 7, 8, 9, 10, 'boer', 'vrouw', 'heer', 'aas'},
    ruiten{2, 3, 4, 5, 6, 7, 8, 9, 10, 'boer', 'vrouw', 'heer', 'aas'};
}