using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        public List<Card> cards;
        public int numberOfCards;

        public Deck()
        {
            numberOfCards = 52;
        }
        public void InitializeDeck()
        {
                   
            for (int value = 0; value < 13; value++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    Card theCard = new Card();
                    switch (suit)
                    {
                        case 0:
                            theCard.suit = "Hearts";
                            break;
                        case 1:
                            theCard.suit = "Diamonds";
                            break;
                        case 2:
                            theCard.suit = "Clubs";
                            break;
                        case 3:
                            theCard.suit = "Spades";
                            break;
                    }
                    if (value > 10)
                    {
                        theCard.value = 10;
                    }
                    else
                    {
                        theCard.value = value;
                    }
                    if (value == 1)
                    {
                        theCard.alternateValue = 11;
                    }
                    else
                    {
                        theCard.alternateValue = 0;
                    }

                    if (value > 1 && value < 10)
                    {
                        theCard.name = value.ToString();
                    }
                    else if (value == 11) {
                        theCard.name = "Jack";
                    }
                    else if (value == 12)
                    {
                        theCard.name = "Queen";
                    }
                    else if (value == 13)
                    {
                        theCard.name = "King";
                    }
                    else if (value == 1)
                    {
                        theCard.name = "Ace";
                    }
                    }
                }


            }
        public void Shuffle()
        {
            List<Card> cards = new List<Card>();
            Random cardShuffler = new Random();


        }
    }

    }

