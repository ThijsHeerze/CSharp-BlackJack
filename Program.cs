namespace BlackJack;

internal class Program
{
    string answer = "ja";
    static void Main(string[] args)
    {
        Console.WriteLine("Dealer: Wilt u een spel BlackJack starten?");
        Console.WriteLine("ja of nee?");
        string answer = Console.ReadLine();
        while (answer == "ja")
        {
            Deck deck = new Deck();
            deck.Shuffle();
            Deck card = new Deck();
            deck.Deal();
            Hand hand = new Hand();
            hand.display();
        }
    }
}
/*public class BlackjackGame
{
private readonly Deck _deck;
private readonly Player _player;
private readonly Dealer _dealer;
private bool _isGameOver;

public BlackjackGame()
{
_deck = new Deck();
_player = new Player();
_dealer = new Dealer();
_isGameOver = false;
}

public void StartGame()
{
Console.WriteLine("Welcome to Blackjack!");

// Shuffle the deck
_deck.Shuffle();

// Deal two cards to the player
_player.AddCardToHand(_deck.DealCard());
_player.AddCardToHand(_deck.DealCard());

// Deal two cards to the dealer
_dealer.AddCardToHand(_deck.DealCard());
_dealer.AddCardToHand(_deck.DealCard());

Console.WriteLine("Player hand: " + _player.HandToString());
Console.WriteLine("Dealer hand: " + _dealer.HandToString(true)); // Hide one of the dealer's cards

// Check for blackjack
if (_player.HasBlackjack())
{
Console.WriteLine("Blackjack! You win!");
_isGameOver = true;
return;
}

// Player's turn
while (!_isGameOver)
{
Console.Write("Do you want to hit (H) or stand (S)? ");
var input = Console.ReadLine().ToLower();

if (input == "h")
{
   var card = _deck.DealCard();
   _player.AddCardToHand(card);
   Console.WriteLine("Player draws: " + card);
   Console.WriteLine("Player hand: " + _player.HandToString());

   if (_player.IsBust())
   {
       Console.WriteLine("Bust! You lose.");
       _isGameOver = true;
   }
}
else if (input == "s")
{
   Console.WriteLine("Player stands.");
   _isGameOver = true;
}
else
{
   Console.WriteLine("Invalid input. Please enter H or S.");
}
}

// Dealer's turn
if (!_player.IsBust())
{
Console.WriteLine("Dealer's turn.");
Console.WriteLine("Dealer hand: " + _dealer.HandToString(false));

while (_dealer.GetHandValue() < 17)
{
   var card = _deck.DealCard();
   _dealer.AddCardToHand(card);
   Console.WriteLine("Dealer draws: " + card);
   Console.WriteLine("Dealer hand: " + _dealer.HandToString(false));
}

if (_dealer.IsBust())
{
   Console.WriteLine("Dealer busts! You win!");
}
else
{
   var playerValue = _player.GetHandValue();
   var dealerValue = _dealer.GetHandValue();

   if (playerValue > dealerValue)
   {
       Console.WriteLine("You win!");
   }
   else if (dealerValue > playerValue)
   {
       Console.WriteLine("Dealer wins.");
   }
   else
   {
       Console.WriteLine("It's a tie.");
   }
}
}

Console.WriteLine("Press any key to start a new game.");
Console.ReadKey();
Console.WriteLine();
StartGame(); // Start a new game
}
}*/