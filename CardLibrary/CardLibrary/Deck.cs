using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class Deck
    {
        private Card[] _deck;

        public Deck()
        {
            _deck = new Card[52];
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    _deck[suitVal * 13 + (rankVal - 1)] = new Card((Suit)suitVal, (Rank)rankVal);
                }
            }
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 || cardNum < 52)
            {
                return _deck[cardNum];
            }
            else
            {
                throw new ArgumentOutOfRangeException("CardNumber", cardNum, "Number must be between 0 and 51.");
            }
        }


        public void Shuffle()
        {
            Card[] newDeck = new Card[52];
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
                newDeck[foundCard] = _deck[i];
                assigned[foundCard] = true;
            }

            newDeck.CopyTo(_deck, 0);
        }
    }
}
