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
            Deck deck = new Blackjack.Deck();
            deck.InitializeDeck();
            Console.ReadKey();


        }
    }
}
