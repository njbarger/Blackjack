using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Lab3Library;

namespace Week3Lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Deck newDeck = new Deck();
            bool dontQuit = true;

            Console.SetWindowSize(125, 40);

            //grab a handle to the console
            
            while (dontQuit)
            {
                ResizeCheck();
                Console.Clear();
                Console.SetCursorPosition(50, 7);
                Console.WriteLine($"Welcome.");
                Menu();
                int selection = ReadInt();
                switch (selection)
                {
                    default:
                        {

                            Console.CursorLeft = 50;
                            Console.WriteLine("Invalid selection, try again");
                            break;
                        }
                    case 1:
                        {
                            bool tryAgain = true;
                            BlackjackGame newGame = new BlackjackGame();
                            newGame.StartGame();
                            while (tryAgain)
                            {
                                ResizeCheck();
                                newGame.PlayRound();
                                bool badInput = true;
                                while (badInput)
                                {
                                    Console.SetCursorPosition(45, 27);
                                    Console.WriteLine("Would you like to continue?");
                                    Console.SetCursorPosition(31, 28);
                                    Console.WriteLine("(Players with no money will be thrown out for choosing to be poor.)");
                                    Console.CursorLeft = 47;
                                    Console.WriteLine("1: Yes \t 2: No");

                                    int playAgainOption = ReadInt();
                                    switch (playAgainOption)
                                    {
                                        default:
                                            {
                                                Console.CursorLeft = 50;
                                                Console.WriteLine("Invalid selection, try again.");
                                                break;
                                            }
                                        case 1:
                                            {
                                                badInput = false;
                                                Console.Clear();
                                                break;
                                            }
                                        case 2:
                                            {
                                                tryAgain = false;
                                                badInput = false;
                                                Console.Clear();
                                                break;
                                            }
                                    }
                                }
                                
                            }
                            break;
                            
                        }
                    case 2:
                        {
                            Console.Clear();
                            newDeck.Shuffle();
                            int x = 0;
                            int y = 0;
                            for (int i = 0; i < 52; i++)
                            {
                                Card card = newDeck.Deal();
                                if (x > 110)
                                {
                                    x = 0;
                                    y += 9;
                                }
                                card.Print(x, y);
                                x += 9;
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            ResizeCheck();
                            Console.Clear();
                            newDeck.Shuffle();
                            BlackjackHand playerHand = new BlackjackHand();
                            BlackjackHand dealerHand = new BlackjackHand(true);
                            playerHand.AddCard(newDeck.Deal());
                            playerHand.AddCard(newDeck.Deal());
                            dealerHand.AddCard(newDeck.Deal());
                            dealerHand.AddCard(newDeck.Deal());
                            Console.SetCursorPosition(50, 5);
                            Console.WriteLine("-----Dealer-----");
                            dealerHand.Print(50, 7);
                            Console.SetCursorPosition(50, 17);
                            Console.WriteLine("-----Player----");
                            playerHand.Print(50, 19);
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            dontQuit = false;
                            break;
                        }
                }
            }
        }
        public static void Menu()
        {
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("----------Make your selection----------\n");
            Console.CursorLeft = 50;
            Console.WriteLine("1: BlackJack");
            Console.CursorLeft = 50;
            Console.WriteLine("2: Shuffle and Show Deck");
            Console.CursorLeft = 50;
            Console.WriteLine("3: Sample Hands");
            Console.CursorLeft = 50;
            Console.WriteLine("4: Exit");
        }
        
        public static int ReadInt()
        {
            int selection;
            Console.CursorLeft = 50;
            Console.Write("___\b\b");

            ResizeCheck();

            string input = Console.ReadLine();
            while (!int.TryParse(input, out selection))
            {
                Console.Clear();
                Menu();
                Console.WriteLine("\n");
                Console.CursorLeft = 50;
                Console.WriteLine("Invalid input, try again.");
                Console.CursorLeft = 50;
                Console.Write("___\b\b");
                input = Console.ReadLine();
            }
            ResizeCheck();
            return selection;

        }
        public static void ResizeCheck()
        {
            if (Console.WindowWidth != 125 || Console.WindowHeight != 40)
            {
                Console.SetWindowSize(125, 40);
            }
        }
    }
}
