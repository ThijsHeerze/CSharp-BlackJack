using BlackJack;
using System;
using System.Collections.Generic;

public class Hand
{
    private List<Card> cardArr;
    private int nextToDeal;

    public int numCards { get; set; }

    public Hand()
    {
        cardArr = new List<Card>();
        nextToDeal = 0;
        numCards = 0;
    }

    public void display()
    {
        Console.WriteLine("Cards in hand:");
        foreach (Card card in cardArr)
        {
            Console.WriteLine(card.ToString());
        }
    }

    public int getPoints()
    {
        int points = 0;
        foreach (Card card in cardArr)
        {
            points += card.getPoints();
        }
        return points;
    }

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

/*De Hand klasse heeft twee private velden: cardArr, een lijst van Card objecten, en nextToDeal, een integer die bijhoudt welke kaart de volgende is om uitgedeeld te worden.
Er is ook één publieke eigenschap, numCards, een integer die het aantal kaarten in de hand bijhoudt. Deze heeft een getter en setter.
De constructor van Hand initialiseert cardArr, nextToDeal en numCards.
De display methode toont alle kaarten in de hand in de console.
De getPoints methode telt de punten van elke kaart in de hand op en retourneert de totale waarde als integer.
De hit methode geeft een lijst van nieuwe kaarten terug, als er nog kaarten beschikbaar zijn om uit te delen.*/