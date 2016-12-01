using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        public List<Card> cards = new List<Card>();
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

                    if (value > 0 && value < 10)
                    {
                        theCard.name = (value+1).ToString();
                    }
                    else if (value == 10) {
                        theCard.name = "Jack";
                    }
                    else if (value == 11)
                    {
                        theCard.name = "Queen";
                    }
                    else if (value == 12)
                    {
                        theCard.name = "King";
                    }
                    else if (value == 0)
                    {
                        theCard.name = "Ace";
                    }
                    if (value > 9)
                    {
                        theCard.value = 10;
                    }
                    else
                    {
                        theCard.value = value + 1;
                    }
                    if (theCard.value == 1)
                    {
                        theCard.alternateValue = 11;
                    }
                    else
                    {
                        theCard.alternateValue = 0;
                    }

                    cards.Add(theCard);
                }
            
                }


            }
        public void Shuffle()
        {
            List<Card> shuffledCards = new List<Card>();
            Random cardShuffler = new Random();
            for (int value = 0; value < 52; value++)
            {
                int selectedCard = cardShuffler.Next(0, cards.Count());
                shuffledCards.Add(cards[selectedCard]);
                cards.RemoveAt(selectedCard);
            }
            cards = shuffledCards;


        }
        public void DisplayDeck()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine("{0} {1} {2}", card.name, card.suit, card.value);
            }
        }
    }

    }

