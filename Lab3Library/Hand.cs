using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Library
{
    public class Hand
    {
        protected List<Card> _cards = new List<Card>();
        public virtual void AddCard(Card card)
        {
            _cards.Add(card);
        }
        public virtual void Print(int x, int y)
        {
            for (int i = 0; i < _cards.Count; i++)
            {
                _cards[i].Print(x, y);
                x += 9;
            }
        }
    }
}
