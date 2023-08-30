using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Library
{
    public class BlackjackCard : Card
    {
        public int Value { get; set; }
        public BlackjackCard(CardFace face, CardSuit suit, bool scoreOver21 = false) : base(face, suit)
        {
            if (face is CardFace.Jack ||
                face is CardFace.Queen ||
                face is CardFace.King)
            {
                Value = 10;
            }
            else if (face is CardFace.Ace)
            {
                Value = 11;
            }
            else if (face is CardFace.AceAs1)
            {
                Value = 1;
            }
            else
            {
                Value = (int)face + 1;
            }
        }
    }
}
