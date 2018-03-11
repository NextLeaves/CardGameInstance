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

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        private Card()
        {

        }

        public override string ToString() => string.Format($"The {rank} of {suit}.");
    }
}
