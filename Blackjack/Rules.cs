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
            Console.WriteLine("You are dealt two cards. Both are face up.");
            Console.WriteLine("The dealer is also dealt two cards. One is face up and one is face down.");
            Console.WriteLine("Cards 2-10 are worth their face value. All face cards are worth 10. Ace is worth 1 or 11.");
            Console.WriteLine("On your turn you may hit, stay, double, or split.");
            Console.WriteLine("The goal is to beat the dealer's hand while not going over 21.");
        }

        public void DisplayRules()
        {
            Console.WriteLine("Would you like to see the rules?");
            string choice = Console.ReadLine().ToLower();
            bool chosen = false;
            while (chosen == false)
            {
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
