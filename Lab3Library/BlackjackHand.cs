using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Library
{
    public class BlackjackHand : Hand
    {
        public bool HasAce { get; set; } = false;
        public int Bet { get; set; }
        public int Wallet { get; set; }
        public int Score { get; private set; }
        public bool IsDealerAfterDeal { get; set; } = false;
        public bool IsDealer { get; set; } = false;
        public BlackjackHand(bool isDealer = false)
        {
            IsDealer = isDealer;
        }
        public override void AddCard(Card card)
        {

            BlackjackCard blackjackCard = new BlackjackCard(card.Face, card.Suit);
            Score += blackjackCard.Value;
            base.AddCard(blackjackCard);

            if (blackjackCard.Face == CardFace.Ace)
            {
                HasAce = true;
            }
            if (Score > 21 && HasAce)
            {
                for (int i = 0; i < _cards.Count; i++)
                {
                    if(_cards[i].Face == CardFace.Ace )
                    {
                        BlackjackCard aceAs1 = new BlackjackCard(CardFace.AceAs1, card.Suit);
                        _cards[i] = aceAs1;
                        Score -= 10;
                    }
                }
            }

        }
        public void ClearHand()
        {
            if (_cards.Count != 0)
            {
                _cards.Clear();
                HasAce = false;
                Score = 0;
            }
        }
        public override void Print(int x, int y)
        {
            int spacer = 4;
            if(_cards.Count > 2) // Moves hand to the left after more than 2 cards.
            {
                x -= spacer * (_cards.Count - 2);
            }
            if (IsDealer)
            {
                
                for (int i = 0; i < _cards.Count; i++)
                {
                    if (i == 0)
                    {
                        Card temp;
                        temp = _cards[i];
                        _cards[i] = CardFactory.CreateCard(CardFace.Backside, temp.Suit);
                        _cards[i].Print(x, y);
                        _cards[i] = temp;
                    }
                    else
                        _cards[i].Print(x, y);
                    x += 9;
                }
            }
            else if (IsDealerAfterDeal)
            {

                base.Print(x, y);
                Console.WriteLine();
                Console.SetCursorPosition(x + 5, y + 6);
                Console.Write($"Score: {Score}");
            }
            else
            {
                base.Print(x, y);
                Console.WriteLine();
                Console.SetCursorPosition(x-1, y+6);
                Console.Write($"Score: {Score}  Wallet: ${Wallet}");
            }
        }
    }
}
