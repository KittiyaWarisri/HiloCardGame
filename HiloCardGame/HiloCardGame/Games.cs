using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiloCardGame
{
    class Games
    {
        Decks _Game = new Decks();
        bool _end = false;
        Players _player1 = new Players();
        Players _player2 = new Players();

        public void ComparedCard(Cards c1, Cards c2)
        {
            Cards c11, c22;
            Console.WriteLine("Player1 card:  " + c1);
            Console.WriteLine("Player2 card:  " + c2);
            int count = 1;
            while (c1.Ranks == c2.Ranks)
            {

                Console.WriteLine("The same rank : " + c1.Ranks + "\n");
                if (c1.Ranks >= (_Game.GetNumberOfCard() / 2))
                {
                    count += (_Game.GetNumberOfCard() / 2);
                    _end = true;
                }
                else
                {
                    count += c1.Ranks;
                    _end = false;
                }

                if (_Game.GetNumberOfCard() >= 2)
                {
                    c11 = _Game.UseCard();
                    c22 = _Game.UseCard();


                    Console.Write("press to continue:  ");
                    Console.ReadKey();
                    Console.Write("\n");

                    Console.WriteLine("Player1 card:  " + c11.Ranks);
                    Console.WriteLine("Player2 card:  " + c22.Ranks);

                    if (c11.Ranks == c22.Ranks)
                    {
                        Console.WriteLine("The same rank : " + c11.Ranks);
                        Console.WriteLine("Add cards back and sufful....");
                        _Game.AddCard(c11);
                        _Game.AddCard(c22);
                        _Game.AddCard(c1);
                        _Game.AddCard(c2);
                        Console.WriteLine("Each player Cards are available " + (_Game.GetNumberOfCard() / 2) + " in your deck.");
                        _end = false;
                        c1 = _Game.UseCard();
                        c2 = _Game.UseCard();
                        if (_Game.GetNumberOfCard() == 0)
                        {
                            _end = true;
                            break;
                        }
                        Console.WriteLine("Player1 card:  " + c1.Ranks);
                        Console.WriteLine("Player2 card:  " + c2.Ranks);
                        count = 1;
                    }
                    else
                    {
                        c1 = c11;
                        c2 = c22;
                        break;
                    }
                }
                else
                {
                    _end = true;
                    break;
                }
            }

            if (c1.Ranks < c2.Ranks)
            {
                Console.WriteLine("" + _player1.Name + " win " + _player2.Name + " in this round");
                _player1.Score += count * 2;
            }
            else
            {

                Console.WriteLine("" + _player2.Name + " win " + _player1.Name + " in this round");
                _player2.Score += count * 2;
            }

            Console.WriteLine("Player1 Score:  " + _player1.Score);
            Console.WriteLine("Player2 Score:  " + _player2.Score);

            for (int k = 1; k < count - 1; k++)
            {
                c1 = _Game.UseCard();
                c2 = _Game.UseCard();
            }
            Console.WriteLine("Each player has card " + (_Game.GetNumberOfCard() / 2) + " in your deck.");
        }
        public void PlayGame()
        {
            Console.Write("Enter Name (Player1) :  ");
            _player1.Name = Console.ReadLine();
            Console.Write("Enter Name (Player2) :  ");
            _player2.Name = Console.ReadLine();
            Console.Write("press to start:  ");
            Console.ReadKey();
            while (!_end)
            {
                
                if (_Game.GetNumberOfCard() == 2)
                {
                    _end = true;
                }
                Cards c1 = _Game.UseCard();
                Cards c2 = _Game.UseCard();
                ComparedCard(c1, c2);
                Console.WriteLine("\n");
                if(_Game.GetNumberOfCard() >= 2)
                {
                    Console.Write("press to continue:  ");
                    Console.ReadKey();
                    Console.Write("\n");
                }
                

            }
            EndGame();

        }
        public void EndGame()
        {
            if (_player1.Score > _player2.Score)
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>   " + _player1.Name + " is the Winner!!   <<<<<<<<<<<<<<<<<<<<");
            else if (_player1.Score < _player2.Score)
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>   " + _player2.Name + " is the Winner!!   <<<<<<<<<<<<<<<<<<<<");
            else Console.WriteLine(">>>>>>>>>>>>>>>>>>>>   Draw!!   <<<<<<<<<<<<<<<<<<<<");
        }

    }
}
