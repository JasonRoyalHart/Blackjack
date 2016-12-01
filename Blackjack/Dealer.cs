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
        }



        public void DealCards(Deck deck, Game game)
        {
            DealOut(deck, game);
            DealOut( deck, game);

        }
    }
}
