using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.Welcome();
            game.GetPlayers();
            game.MakePlayers();
            Deck orderedDeck = new Deck();
            Deck deck = new Deck();
            orderedDeck.InitializeDeck();
            orderedDeck.Shuffle();
            orderedDeck.DisplayDeck();
            Console.WriteLine(orderedDeck.cards.Count());
            Console.ReadKey();


        }
    }
}
