using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Library
{
    public static class CardFactory
    {
        public static Card CreateCard(CardFace face, CardSuit suit)
        {
            Card card = new Card(face, suit);
            return card;
        }
        public static Card CreateBlackjackCard(CardFace face, CardSuit suit)
        {
            BlackjackCard blackjackCard = new BlackjackCard(face, suit);
            return blackjackCard;
        }
    }
}
