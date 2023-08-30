using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Library
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>();
        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    _cards.Add(CardFactory.CreateBlackjackCard((CardFace)j, (CardSuit)i));
                }
            }
        }
        public void Shuffle()
        {
            Random rng = new Random();
            for (int i = _cards.Count - 1; i > 0; i--)
            {
                int rnd = rng.Next(i+ 1);
                Card temp = _cards[i];
                _cards[i] = _cards[rnd];
                _cards[rnd] = temp;
            }
        }
        public Card Deal()
        {
            if (_cards.Count == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        this._cards.Add(CardFactory.CreateBlackjackCard((CardFace)j, (CardSuit)i));
                    }
                }
                Shuffle();
            }
            Card draw = _cards[0];
            _cards.RemoveAt(0);
            return draw;
        }
        
        
    }
}
