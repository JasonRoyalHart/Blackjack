using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Game
    {
        public int numberOfPlayers;
        public List<Player> playerList = new List<Player>();
        public bool gameOver;

        public void Welcome()
        {
            Console.WriteLine("Welcome to Blackjack!");
            Console.WriteLine("A team one production.");
            Rules rules = new Rules();
            rules.DisplayRules();
        }
        public void GetPlayers()
        {
            bool chosen = false;
            while (!chosen)
            {
                Console.WriteLine("How many players? (1-8)");
                string players = Console.ReadLine();
                switch (players)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                        Console.WriteLine("Setting to {0} players.", players);
                        chosen = true;
                        numberOfPlayers = Convert.ToInt32(players);
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 8.");
                        break;
                }

            }

        }

        public void MakePlayers()
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Player newPlayer = new Player();
                playerList.Add(newPlayer);
                Console.WriteLine("Player {0}, what is your name?",i+1);
                playerList[i].Name = Console.ReadLine();
            }
        }

        public void DealerLoop(Dealer dealer, Deck deck)
        {
            bool dealerHitting = true;
            while (dealerHitting)
            {
                if (dealer.AddCards() < 17)
                {
                    dealer.DealSelf(deck);
                    bool dealerBusted = dealer.CheckForBust(this);
                    if (dealerBusted)
                    {
                        Console.WriteLine("The dealer busted!");
                        dealerHitting = false;
                        gameOver = true;
                    }
                }
                else
                {
                    dealerHitting = false;
                }
                dealer.DisplayHand();
            }
        }
        public void GameLoop(Dealer dealer, Deck deck)
        {
            bool allStay = false;
            while (!allStay)
            {

                foreach (Player currentPlayer in playerList)
                {
                    bool stay = false;
                    if (!currentPlayer.lost)
                    {
                        while (!stay)
                            {
                            currentPlayer.DisplayHand();
                            Console.WriteLine("{0}, your current score is {1}, choose hit or stay.", currentPlayer.Name, currentPlayer.AddCards());
                            string playerChoice = Console.ReadLine().ToLower();
                            switch (playerChoice)
                            {
                                case "hit":
                                    currentPlayer.Hit(this, dealer, deck);
                                    break;
                                case "stay":
                                    stay = true;
                                    currentPlayer.Stay();
                                    break;
                                default:
                                    Console.WriteLine("Please enter hit or stay.");
                                    break;

                            }
                            bool busted = currentPlayer.CheckForBust(this);
                            if (busted)
                                {
                                    stay = true;
                                }
                            allStay = true;
                   }
                    }
                }
            }
        }
        public void CompareScores(Dealer dealer, Game game)
        {
            int dealerScore = dealer.AddCards();
            Console.WriteLine("The dealer's final score is {0}",dealerScore);
            if (dealerScore > 21)
            {
                Console.WriteLine("The dealer busted.");
                foreach (Player player in game.playerList)
                {
                    if (!player.lost)
                    {
                        Console.WriteLine("{0} wins with a score of {1}!",player.Name, player.AddCards());
                    }
                    else
                    {
                        Console.WriteLine("{0} busted and loses.",player.Name);
                    }
                }
            }
            else
            {
                foreach (Player scorePlayer in game.playerList)
                {
                    int playerScore = scorePlayer.AddCards();
                    Console.WriteLine("{0}'s final score is {1}", scorePlayer.Name, playerScore);

                    {
                        if (playerScore <= 21)
                        {
                            if (playerScore > dealerScore)
                            {
                                Console.WriteLine("{0} wins!\n", scorePlayer.Name);
                            }
                            else if (playerScore == dealerScore)
                            {
                                Console.WriteLine("{0} pushes.\n", scorePlayer.Name);
                            }
                            else
                            {
                                Console.WriteLine("{0} loses.\n", scorePlayer.Name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("{0} busted and lost.\n", scorePlayer.Name);
                        }
                    }
                }
            }
        }

}
}
