using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Rules
    {

        public void ShowRules()
        {
            Console.WriteLine(" THE DEAL");
            Console.WriteLine("---------\n");
            Console.WriteLine("If the player is dealt a card with the value of 10 along with");
            Console.WriteLine("an ace during the deal, the player has 'blackjack'. They automaticlly");
            Console.WriteLine("win 150% return, and their turn is over. Before the turn starts the dealer checks");
            Console.WriteLine("their face down card, and if they have blackjack, everyone loses and");
            Console.WriteLine("the turn is over.");
            Console.WriteLine("");
            Console.WriteLine(" THE TURN");
            Console.WriteLine("----------\n");
            Console.WriteLine("The first player on the left decides wether they are going to 'hit'");
            Console.WriteLine("(ask for another card), or stay (not ask for another card). This will");
            Console.WriteLine("be based on how close they are to 21. The dealer must keep drawing cards");
            Console.WriteLine("until they are at or above 17, then they must stop. ");
            Console.WriteLine("");
            Console.WriteLine("SETTLING UP");
            Console.WriteLine("------------");
            Console.WriteLine("The round is over once every player (including the dealer) has ");
            Console.WriteLine("played their turn. If the player loses, their entire bet is");
            Console.WriteLine("collected and never returned. Regular player wins pay out 1:1,");
            Console.WriteLine("blackjacks pat out 150% and each hand of a split pays 1:1,");
            Console.WriteLine("even if the split resulted in a blackjack.");
            Console.WriteLine("");
            Console.WriteLine("SHUFFLING");
            Console.WriteLine("----------");
            Console.WriteLine("");
            Console.WriteLine("After each round, the cards are collected and set aside by the");
            Console.WriteLine("dealer into a discard pile. Cards will continue to be drawn from");
            Console.WriteLine("the shoe until the dealer reaches a marked point, at which time");
            Console.WriteLine("they will shuffle the discards back into the main deck, cut the");
            Console.WriteLine("deck, insert the mark back into the shoe, and resume play.");
            Console.WriteLine("");

        }

        public void DisplayRules()
        {
 
            bool chosen = false;
            while (chosen == false)
            {
                Console.WriteLine("Would you like to see the rules?");
                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "y":
                    case "yes":
                        ShowRules();
                        chosen = true;
                        break;
                    case "n":
                    case "no":
                        Console.WriteLine("Ok, no rules for you!");
                        chosen = true;
                        break;
                    default:
                        Console.WriteLine("Please answer yes or no.");
                        break;
                }

            }
        }
    }
}
