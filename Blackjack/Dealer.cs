using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Dealer : Player
    {

        //        public List<Card> hand = new List<Card>();
        public Dealer()
        {
            Name = "Dealer";
        }
        public void DealOut(Deck deck, Game game)
        {
            for (int value = 0; value < game.numberOfPlayers; value++)
            {
                Card dealtCard = deck.cards[0];
                game.playerList[value].hand.Add(dealtCard);
                deck.cards.RemoveAt(0);
            }
            Card dealerCard = deck.cards[0];
            hand.Add(dealerCard);
            deck.cards.RemoveAt(0);
        }

        public void DealSelf(Deck deck)
        {
            Card dealerCard = deck.cards[0];
            hand.Add(dealerCard);
            deck.cards.RemoveAt(0);
            Console.WriteLine("The dealer deals itself a {0} of {1}",dealerCard.name, dealerCard.suit);
        }

        public void DealCards(Deck deck, Game game)
        {
            DealOut(deck, game);
            DealOut(deck, game);

        }

        public void DisplayHiddenHand()
        {
            Console.WriteLine("{0}'s hand:", Name);
            foreach (Card myCard in hand)
            {
                if (myCard != hand[0])
                {
                    Console.WriteLine(myCard.name + " of " + myCard.suit);
                }
                else
                {
                    Console.WriteLine("A face down card.");
                }
                }
            Console.WriteLine("");
        }

    }
}
