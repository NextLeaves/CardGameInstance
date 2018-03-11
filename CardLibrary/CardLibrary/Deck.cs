using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class Deck
    {
        private Cards _cards;

        public Deck()
        {
            _cards =  new Cards();
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    _cards.AddCard(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        public Deck(bool useTrumps,Suit trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Deck(bool useTrumps,Suit trump,bool isAceHigh) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
            Card.isAceHigh = isAceHigh;
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 || cardNum < 52)
            {
                return _cards[cardNum];
            }
            else
            {
                throw new ArgumentOutOfRangeException("CardNumber", cardNum, "Number must be between 0 and 51.");
            }
        }


        public void Shuffle()
        {
            Cards newCards = new Cards();
            bool[] assigned = new bool[52];
            Random itemRandom = new Random();
            for (int i = 0; i < 52; i++)
            {
                int foundCard = 1;
                bool founded = false;
                while (!founded)
                {
                    foundCard = itemRandom.Next(52);
                    if (!assigned[foundCard])
                        founded = true;
                }
                newCards.AddCard(_cards[foundCard]);
                assigned[foundCard] = true;
            }

            newCards.CopyTo(_cards, 0);
        }
    }
}
