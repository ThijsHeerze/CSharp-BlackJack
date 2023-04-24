using System;
using static System.Formats.Asn1.AsnWriter;
using System.Reflection.Emit;
using BlackJack;

public class Dealer 
{
    private Card[] cardArr;
    private int nextToDeal;
    public Dealer(Card[] cardArr)
    {
        this.cardArr = cardArr;
        this.nextToDeal = 0;

        Shuffle shuffle = new Shuffle();
        Shuffle.Shuffle();
        Deal deal = new Deal();
        Deal.ShuffleFunctie();
    }

    public void NewGame()
	{
       
    }
}

/*In deze klasse zijn cardArr en nextToDeal beide private fields. cardArr is een array van Card objecten die de kaarten bevatten die door de dealer worden gedeeld. nextToDeal houdt bij welke kaart de volgende is om te worden gedeeld.

De constructor van de klasse neemt een array van Card objecten als argument en initialiseert cardArr en nextToDeal.

De Deal() methode retourneert de volgende kaart in de array cardArr, en verhoogt vervolgens nextToDeal zodat de volgende keer de volgende kaart kan worden geretourneerd. Als er geen kaarten meer over zijn om te delen, retourneert de methode null.*/