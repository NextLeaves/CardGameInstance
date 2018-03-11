using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class Cards : CollectionBase
    {
        public void AddCard(Card card)
        {
            if (!this.Contains(card))
                List.Add(card);
        }

        public void RemoveCard(Card card)
        {
            if (this.Contains(card))
                List.Remove(card);
        }

        public Card this[int index]
        {
            get { return List[index] as Card; }
            set { List[index] = value; }
        }

        public void CopyTo(Cards targetCards, int startIndex)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        public bool Contains(Card card) => InnerList.Contains(card);
    }
}
