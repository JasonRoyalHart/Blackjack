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
            Dealer dealer = new Dealer();
            game.Welcome();
            game.GetPlayers();
            game.MakePlayers();
            Deck orderedDeck = new Deck();
            Deck deck = new Deck();
            orderedDeck.InitializeDeck();
            orderedDeck.Shuffle();
//            orderedDeck.DisplayDeck();
//            Console.WriteLine(orderedDeck.cards.Count());

            dealer.DealCards(orderedDeck, game);
            //            Player myPlayer = new Player();
            //            foreach (Player myPlayer in game.playerList)
            //            {
            //                myPlayer.DisplayHand();
            //            }

            //            dealer.DisplayHand();

            game.GameLoop(dealer, orderedDeck);
            Console.ReadKey();
        }
    }
}
