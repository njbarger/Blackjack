using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Library
{
    public class Card
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }
        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
        }
        public void Print(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.White;
            string tempSuit;
            switch (Suit)
            {
                case CardSuit.Spades:
                    Console.ForegroundColor = ConsoleColor.Black;
                    tempSuit = "♠";
                    break;
                case CardSuit.Hearts:
                    Console.ForegroundColor = ConsoleColor.Red;
                    tempSuit = "♥";
                    break;
                case CardSuit.Clubs:
                    Console.ForegroundColor = ConsoleColor.Black;
                    tempSuit = "♣";
                    break;
                case CardSuit.Diamonds:
                    Console.ForegroundColor = ConsoleColor.Red;
                    tempSuit = "♦";
                    break;
                default:
                    tempSuit = "";
                    break;
            }
            switch (Face)
            {
                case CardFace.Ace:
                    Console.CursorLeft = x;
                    Console.WriteLine(" A     ");
                    Console.CursorLeft = x;
                    Console.WriteLine("       ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine("       ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     A ");
                    break;
                case CardFace.AceAs1:
                    Console.CursorLeft = x;
                    Console.WriteLine(" A     ");
                    Console.CursorLeft = x;
                    Console.WriteLine("       ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine("       ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     A ");
                    break;

                case CardFace.Two:
                    Console.CursorLeft = x;
                    Console.WriteLine(" 2     ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"       ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     2 ");
                    break;

                case CardFace.Three:
                    Console.CursorLeft = x;
                    Console.WriteLine(" 3     ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     3 ");
                    break;

                case CardFace.Four:
                    Console.CursorLeft = x;
                    Console.WriteLine(" 4     ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"       ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     4 ");
                    break;

                case CardFace.Five:
                    Console.CursorLeft = x;
                    Console.WriteLine(" 5     ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     5 ");
                    break;

                case CardFace.Six:
                    Console.CursorLeft = x;
                    Console.WriteLine(" 6     ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     6 ");
                    break;

                case CardFace.Seven:
                    Console.CursorLeft = x;
                    Console.WriteLine($" 7 {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     7 ");
                    break;

                case CardFace.Eight:
                    Console.CursorLeft = x;
                    Console.WriteLine($" 8 {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit} 8 ");
                    break;

                case CardFace.Nine:
                    Console.CursorLeft = x;
                    Console.WriteLine($" 9 {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit}{tempSuit}{tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit} 9 ");
                    break;

                case CardFace.Ten:
                    Console.CursorLeft = x;
                    Console.WriteLine($" 10{tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit}{tempSuit}{tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"  {tempSuit}{tempSuit}{tempSuit}  ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}10 ");
                    break;

                case CardFace.Jack:
                    Console.CursorLeft = x;
                    Console.WriteLine(" J     ");
                    Console.CursorLeft = x;
                    Console.WriteLine("       ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine("       ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     J ");
                    break;

                case CardFace.Queen:
                    Console.CursorLeft = x;
                    Console.WriteLine(" Q     ");
                    Console.CursorLeft = x;
                    Console.WriteLine("       ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine("       ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     Q ");
                    break;

                case CardFace.King:
                    Console.CursorLeft = x;
                    Console.WriteLine(" K     ");
                    Console.CursorLeft = x;
                    Console.WriteLine("       ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine("       ");
                    Console.CursorLeft = x;
                    Console.WriteLine("     K ");
                    break;

                case CardFace.Backside:
                    tempSuit = "☺";
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = x;
                    Console.WriteLine($" {tempSuit} {tempSuit} {tempSuit} ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"{tempSuit} {tempSuit} {tempSuit} {tempSuit}");
                    Console.CursorLeft = x;
                    Console.WriteLine($" {tempSuit} {tempSuit} {tempSuit} ");
                    Console.CursorLeft = x;
                    Console.WriteLine($"   {tempSuit}   ");
                    break;

                default:
                    break;
            }
            Console.ResetColor();

        }
        public void Print()
        {
            Console.BackgroundColor = ConsoleColor.White;
            string tempSuit;
            switch (Suit)
            {
                case CardSuit.Spades:
                    Console.ForegroundColor = ConsoleColor.Red;
                    tempSuit = "♠";
                    break;
                case CardSuit.Hearts:
                    Console.ForegroundColor = ConsoleColor.Red;
                    tempSuit = "♥";
                    break;
                case CardSuit.Clubs:
                    Console.ForegroundColor = ConsoleColor.Black;
                    tempSuit = "♣";
                    break;
                case CardSuit.Diamonds:
                    Console.ForegroundColor = ConsoleColor.Black;
                    tempSuit = "♦";
                    break;
                default:
                    tempSuit = "";
                    break;
            }
            int y = 5;
            switch (Face)
            {
                case CardFace.Ace:
                    Console.CursorLeft = y;
                    Console.WriteLine(" A     ");
                    Console.CursorLeft = y;
                    Console.WriteLine("       ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine("       ");
                    Console.CursorLeft = y;
                    Console.WriteLine("     A ");
                    break;

                case CardFace.Two:
                    Console.CursorLeft = y;
                    Console.WriteLine(" 2     ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"       ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine("     2 ");
                    break;

                case CardFace.Three:
                    Console.CursorLeft = y;
                    Console.WriteLine(" 3     ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine("     3 ");
                    break;

                case CardFace.Four:
                    Console.CursorLeft = y;
                    Console.WriteLine(" 4     ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"       ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine("     4 ");
                    break;

                case CardFace.Five:
                    Console.CursorLeft = y;
                    Console.WriteLine(" 5     ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine("     5 ");
                    break;

                case CardFace.Six:
                    Console.CursorLeft = y;
                    Console.WriteLine(" 6     ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine("     6 ");
                    break;

                case CardFace.Seven:
                    Console.CursorLeft = y;
                    Console.WriteLine($" 7 {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine("     7 ");
                    break;

                case CardFace.Eight:
                    Console.CursorLeft = y;
                    Console.WriteLine($" 8 {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit} 8 ");
                    break;

                case CardFace.Nine:
                    Console.CursorLeft = y;
                    Console.WriteLine($" 9 {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit}{tempSuit}{tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit} 9 ");
                    break;

                case CardFace.Ten:
                    Console.CursorLeft = y;
                    Console.WriteLine($" 10{tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit}{tempSuit}{tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit} {tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"  {tempSuit}{tempSuit}{tempSuit}  ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}10 ");
                    break;

                case CardFace.Jack:
                    Console.CursorLeft = y;
                    Console.WriteLine(" J     ");
                    Console.CursorLeft = y;
                    Console.WriteLine("       ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine("       ");
                    Console.CursorLeft = y;
                    Console.WriteLine("     J ");
                    break;

                case CardFace.Queen:
                    Console.CursorLeft = y;
                    Console.WriteLine(" Q     ");
                    Console.CursorLeft = y;
                    Console.WriteLine("       ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine("       ");
                    Console.CursorLeft = y;
                    Console.WriteLine("     Q ");
                    break;

                case CardFace.King:
                    Console.CursorLeft = y;
                    Console.WriteLine(" K     ");
                    Console.CursorLeft = y;
                    Console.WriteLine("       ");
                    Console.CursorLeft = y;
                    Console.WriteLine($"   {tempSuit}   ");
                    Console.CursorLeft = y;
                    Console.WriteLine("       ");
                    Console.CursorLeft = y;
                    Console.WriteLine("     K ");
                    break;

                default:
                    break;
            }

        }
    }
}
