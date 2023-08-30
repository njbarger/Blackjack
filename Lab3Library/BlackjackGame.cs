using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab3Library
{
    public class BlackjackGame
    {
        BlackjackHand _dealer;
        BlackjackHand _player;
        BlackjackHand _player2;
        BlackjackHand _player3;
        Deck _deck;
        int _playerCount;

        List<BlackjackHand> players = new List<BlackjackHand>();

        public void StartGame()
        {
            _deck = new Deck();
            _dealer = new BlackjackHand(true);
            _player = new BlackjackHand();
            _player2 = new BlackjackHand();
            _player3 = new BlackjackHand();
            //AskForPlayerCount();
            Console.Clear();
        }
        public void PlayRound()
        {
            for (int i = 0; i < _playerCount; i++)
            {
                if (players[i].Wallet <= 0)
                {
                    players.RemoveAt(i);
                    _playerCount--;
                    i--;
                }
            }
            if (_playerCount == 0)
            {
                AskForPlayerCount();
            }
            _dealer.ClearHand();
            _player.ClearHand();
            _player2.ClearHand();
            _player3.ClearHand();

            _dealer.IsDealer = true;
            _dealer.IsDealerAfterDeal = false;
            _deck.Shuffle();

            

            DealInitialCards();
            //Console.Clear();

            //DrawTable();
            foreach (BlackjackHand hand2 in players)
            {

                PlaceBet(hand2);
            }
            foreach (BlackjackHand hand in players)
            {
                PlayersTurn(hand);
            }
            DealersTurn();
            Console.Clear();
            DrawTable();
            foreach (BlackjackHand hand1 in players)
            {
                DeclareWinner(hand1);
            }
            Console.ReadKey();
            DrawTable();

        }
        public void AskForPlayerCount()
        {
            int selection;
            bool valid = true;
            
            while (valid)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 13);
                Console.WriteLine("How many players? (up to 3)");
                Console.CursorLeft = 55;
                Console.Write("_____\b\b\b");
                string input = Console.ReadLine();
                while (!int.TryParse(input, out selection))
                {
                    Console.WriteLine("\n");
                    Console.CursorLeft = 50;
                    Console.WriteLine("Invalid input, try again.");
                    Console.CursorLeft = 50;
                    Console.Write("___\b\b");
                    input = Console.ReadLine();
                }
                switch (selection)
                {
                    default:
                        {
                            Console.WriteLine("Invalid selection, try again.");
                            break;
                        }
                    case 1:
                        {
                            _playerCount = 1;
                            players.Add(_player);
                            _player.Wallet = 100;
                            valid = false;
                            break;
                        }
                    case 2:
                        {
                            _playerCount = 2;
                            players.Add(_player);
                            _player.Wallet = 100;
                            players.Add(_player2);
                            _player2.Wallet = 100;
                            valid = false;
                            break;
                        }
                    case 3:
                        {
                            _playerCount = 3;
                            players.Add(_player);
                            _player.Wallet = 100;
                            players.Add(_player2);
                            _player2.Wallet = 100;
                            players.Add(_player3);
                            _player3.Wallet = 100;
                            valid = false;
                            break;
                        }

                }
                
            }
        }
        public void DealInitialCards()
        {
            if (players.Contains(_player) && _playerCount == 1)
            {
                _player.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                _player.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();
            }
            else if (players.Contains(_player2) && _playerCount == 1)
            {
                _player2.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                _player2.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();
            }
            else if (players.Contains(_player3) && _playerCount == 1)
            {
                _player3.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                _player3.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();
            }
            else if (players.Contains(_player) && players.Contains(_player2) && _playerCount == 2)
            {
                _player.AddCard(_deck.Deal());
                _player2.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();

                _player.AddCard(_deck.Deal());
                _player2.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();
            }
            else if (players.Contains(_player) && players.Contains(_player3) && _playerCount == 2)
            {
                _player.AddCard(_deck.Deal());
                _player3.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();

                _player.AddCard(_deck.Deal());
                _player3.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();
            }
            else if (players.Contains(_player2) && players.Contains(_player3) && _playerCount == 2)
            {
                _player2.AddCard(_deck.Deal());
                _player3.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();

                _player2.AddCard(_deck.Deal());
                _player3.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();
            }
            else if (players.Contains(_player) && players.Contains(_player2) && players.Contains(_player3))
            {
                _player.AddCard(_deck.Deal());
                _player2.AddCard(_deck.Deal());
                _player3.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();

                _player.AddCard(_deck.Deal());
                _player2.AddCard(_deck.Deal());
                _player3.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
                DrawTable();
            }
        }

        public void CheckPlayerAndMoveCursor(BlackjackHand currentPlayer, int spacer = 0)
        {
            if (currentPlayer == _player)
            {
                Console.SetCursorPosition(42, 26 + spacer);
            }
            else if (currentPlayer == _player2)
            {
                Console.SetCursorPosition(10, 19 + spacer);
            }
            else if (currentPlayer == _player3)
            {
                Console.SetCursorPosition(80, 19 + spacer);
            }
        }
        public void PlayersTurn(BlackjackHand currentPlayer)
        {
            List<BlackjackHand> players = new List<BlackjackHand>();

            int selection;
            bool scoreUnder21 = true;
            while (scoreUnder21 && currentPlayer.Score < 21)
            {
                CheckPlayerAndMoveCursor(currentPlayer);
                Console.Write("Would you like to hit or stand?");
                CheckPlayerAndMoveCursor(currentPlayer, 2);
                Console.WriteLine("1: Hit \t2: Stand");
                CheckPlayerAndMoveCursor(currentPlayer, 3);
                Console.Write("_____\b\b\b");
                string input = Console.ReadLine();
                while (!int.TryParse(input, out selection))
                {
                    CheckPlayerAndMoveCursor(currentPlayer, 5);
                    Console.WriteLine("Invalid input, try again.");
                    CheckPlayerAndMoveCursor(currentPlayer, 6);
                    Console.Write("___\b\b");
                    input = Console.ReadLine();
                }
                switch (selection)
                {
                    default:
                        {
                            Console.WriteLine("Invalid selection, try again.");
                            break;
                        }
                    case 1:
                        {
                            currentPlayer.AddCard(_deck.Deal());
                            DrawTable();
                            break;
                        }
                    case 2:
                        {
                            scoreUnder21 = false;
                            break;
                        }
                }
            }
        }
        public void DealersTurn()
        {

                _dealer.IsDealer = false;
                _dealer.IsDealerAfterDeal = true;
            while (_dealer.Score < 17)
            {
                _dealer.AddCard(_deck.Deal());
                DrawTable();
                Thread.Sleep(175);
            }
        }

        public void DeclareWinner(BlackjackHand currentPlayer)
        {
            if (currentPlayer.Score > 21)
            {
                CheckPlayerAndMoveCursor(currentPlayer, 1);
                Console.WriteLine($"Dealer wins! ${currentPlayer.Bet} lost!");

            }
            else if (_dealer.Score > 21)
            {
                CheckPlayerAndMoveCursor(currentPlayer, 1);
                Console.WriteLine($"Player wins! ${currentPlayer.Bet * 2} won!");
                currentPlayer.Wallet += currentPlayer.Bet * 2;
            }
            else if (currentPlayer.Score == _dealer.Score)
            {
                CheckPlayerAndMoveCursor(currentPlayer, 1);
                Console.WriteLine($"It's a tie! ${currentPlayer.Bet} won!");
                currentPlayer.Wallet += currentPlayer.Bet;
            }
            else if (currentPlayer.Score > _dealer.Score)
            {
                CheckPlayerAndMoveCursor(currentPlayer, 1);
                Console.WriteLine($"Player wins! ${currentPlayer.Bet * 2} won!");
                currentPlayer.Wallet += currentPlayer.Bet * 2;
            }
            else
            {
                CheckPlayerAndMoveCursor(currentPlayer, 1);
                Console.WriteLine($"Dealer wins! ${currentPlayer.Bet} lost!");
            }


        }

        public void DrawTable()
        {
            if (_playerCount == 1 && players.Contains(_player3))
            {
                Console.Clear();
                Console.SetCursorPosition(80, 10);
                Console.WriteLine("-----Player 3-----");

                Console.SetCursorPosition(50, 5);
                Console.WriteLine("-----Dealer-----");

                Thread.Sleep(175);
                _player3.Print(80, 12);


                Thread.Sleep(175);
                _dealer.Print(50, 7);

            }
            else if (_playerCount == 1 && players.Contains(_player2))
            {
                Console.Clear();
                Console.SetCursorPosition(20, 10);
                Console.WriteLine("-----Player 2-----");

                Console.SetCursorPosition(50, 5);
                Console.WriteLine("-----Dealer-----");

                Thread.Sleep(175);
                _player2.Print(25, 12);


                Thread.Sleep(175);
                _dealer.Print(50, 7);

            }
            else if (_playerCount == 1)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 17);
                Console.WriteLine("-----Player-----");

                Console.SetCursorPosition(50, 5);
                Console.WriteLine("-----Dealer-----");

                Thread.Sleep(175);
                _player.Print(50, 19);


                Thread.Sleep(175);
                _dealer.Print(50, 7);

            }

            else if (_playerCount == 2 && players.Contains(_player) && players.Contains(_player3))
            {
                Console.Clear();
                Console.SetCursorPosition(50, 17);
                Console.WriteLine("-----Player 1-----");

                Console.SetCursorPosition(80, 10);
                Console.WriteLine("-----Player 3-----");

                Console.SetCursorPosition(50, 5);
                Console.WriteLine("-----Dealer-----");

                Thread.Sleep(175);
                _player.Print(50, 19);


                Thread.Sleep(175);
                _player3.Print(80, 12);


                Thread.Sleep(175);
                _dealer.Print(50, 7);

            }
            else if(_playerCount == 2 && players.Contains(_player2) && players.Contains(_player3))
            {
                Console.Clear();
                Console.SetCursorPosition(25, 10);
                Console.WriteLine("-----Player 2-----");

                Console.SetCursorPosition(80, 10);
                Console.WriteLine("-----Player 3-----");

                Console.SetCursorPosition(50, 5);
                Console.WriteLine("-----Dealer-----");

                Thread.Sleep(175);
                _player2.Print(25, 12);



                Thread.Sleep(175);
                _player3.Print(80, 12);



                Thread.Sleep(175);
                _dealer.Print(50, 7);

            }
            else if (_playerCount == 2)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 17);
                Console.WriteLine("-----Player 1-----");

                Console.SetCursorPosition(20, 10);
                Console.WriteLine("-----Player 2-----");

                Console.SetCursorPosition(50, 5);
                Console.WriteLine("-----Dealer-----");

                Thread.Sleep(175);
                _player.Print(50, 19);


                Thread.Sleep(175);
                _player2.Print(25, 12);


                Thread.Sleep(175);
                _dealer.Print(50, 7);

            }
            else if (_playerCount == 3)
            {
                Console.Clear();
                Console.SetCursorPosition(50, 17);
                Console.WriteLine("-----Player 1-----");

                Console.SetCursorPosition(25, 10);
                Console.WriteLine("-----Player 2-----");

                Console.SetCursorPosition(80, 10);
                Console.WriteLine("-----Player 3-----");

                Console.SetCursorPosition(50, 5);
                Console.WriteLine("-----Dealer-----");

                Thread.Sleep(175);
                _player.Print(50, 19);


                Thread.Sleep(175);
                _player2.Print(25, 12);


                Thread.Sleep(175);
                _player3.Print(80, 12);


                Thread.Sleep(175);
                _dealer.Print(50, 7);

            }

        }

        public void PlaceBet(BlackjackHand currentPlayer)
        {
            int betAmount = 0;
            if (currentPlayer.Wallet > 0)
            {
                CheckPlayerAndMoveCursor(currentPlayer, 1);
                Console.Write($"How much would you like to bet? _____\b\b\b");
                string input = Console.ReadLine();
                while (!int.TryParse(input, out betAmount) || betAmount > currentPlayer.Wallet || betAmount < 0)
                {
                    CheckPlayerAndMoveCursor(currentPlayer, 3);
                    Console.Write("Invalid input or insufficient funds, try again.");
                    CheckPlayerAndMoveCursor(currentPlayer, 4);
                    Console.Write(" _____\b\b\b");
                    input = Console.ReadLine();
                }
            }
            else
            {
                CheckPlayerAndMoveCursor(currentPlayer, 1);
                Console.WriteLine($"Insufficient funds to place bet.");
                Console.ReadKey();
            }
            currentPlayer.Wallet -= betAmount;
            currentPlayer.Bet = betAmount;
            Console.Clear();
            DrawTable();
        }
    }
}
