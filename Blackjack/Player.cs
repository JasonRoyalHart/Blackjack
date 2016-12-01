using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Player
    {
        public string Name;
        public int Money;
        public bool turnOver;
        public bool lost;
        public bool staying;
        public List<Card> hand = new List<Card>();

        public Player()
        {
            turnOver = false;
            lost = false;
        }
        public virtual void DisplayHand()
        {
            Console.WriteLine("\n{0}'s hand:", Name);
            foreach (Card myCard in hand)
            {
                Console.WriteLine(myCard.name + " of " + myCard.suit);
            }
            Console.WriteLine("");
        }

        public void Hit(Game game, Dealer dealer, Deck deck)
        {
            Console.WriteLine("{0} hits.", Name);
            Card dealtCard = deck.cards[0];
            hand.Add(dealtCard);
            deck.cards.RemoveAt(0);
            Console.WriteLine("\nYou are dealt a {0} of {1}", dealtCard.name, dealtCard.suit);
         }
        public void Stay()
        {
            Console.WriteLine("You stay.");
            staying = true;
        }

        public int AddCards()
        {
            int total = 0;
            foreach (Card card in hand)
            {
                if (card.name == "Ace")
                {
                    if ((total+11) > 21)
                    {
                        total += card.alternateValue;
                    }
                    else
                    {
                        total += card.value;
                    }
                }
                else
                {
                    total += card.value;
                }
                }
            return total;
        }
        public bool CheckForBust(Game game)
        {
            if (AddCards() > 21)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} busted!", Name);
                Console.ResetColor();
                turnOver = true;
                lost = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
