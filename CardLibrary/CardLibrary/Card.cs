using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class Card
    {
        public Suit suit { get; }
        public Rank rank { get; }

        public static bool useTrumps = false;
        public static Suit trump = Suit.Club;
        public static bool isAceHigh = true;

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        private Card()
        {

        }

        public static bool operator ==(Card card1, Card card2) => (card1.suit == card2.suit && card1.rank == card2.rank);

        public static bool operator !=(Card card1, Card card2) => !(card1 == card2);

        public static bool operator >(Card card1,Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank > card2.rank);
                    }                    
                }
                else
                {                    
                        return (card1.rank > card2.rank);
                }                    
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator >=(Card card1,Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                        return true;
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return card1.rank >= card2.rank;
                    }
                }
                else
                    return (card1.rank >= card2.rank);
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <(Card card1, Card card2) => !(card1 >= card2);

        public static bool operator <=(Card card1, Card card2) => !(card1 > card2);

        public override string ToString() => string.Format($"The {rank} of {suit}.");
    }
}
