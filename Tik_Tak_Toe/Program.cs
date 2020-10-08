using System;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace TikTakToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int checkResult = 0;
            Console.WriteLine("Welcome to Tik Tak Toe program!");
            TikTakToeGame game = new TikTakToeGame();
            game.CreateBoard();
            Toss:
            int tossResult = game.Toss();
            if (tossResult == 0)
            {
                Console.WriteLine("Toss Again");
                goto Toss;
            }
            char inputByUser = game.Input();
            int c = 1;
            while (c == 1)
            {
                startGame:
                Console.WriteLine("Computer's turn");
                char compInput = game.ComputerPlay();
                int winnerResult = game.CheckWinner(compInput);
                if (winnerResult == 1)
                {
                    c = 0;
                    Console.WriteLine("Computer Won the game");
                    game.ShowBoard();
                    break;
                }
                Console.WriteLine("Enter choice 1.Input next number, 2.Show board, 3.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        
                        int winningPositionResult = game.CheckWinningPosition(compInput);
                        if (winningPositionResult != 0)
                        {
                            Console.WriteLine("Opponent can win. To block make move at position: " + winningPositionResult);
                            game.ShowBoard();
                        }
                        TakeInput:
                        Console.WriteLine("Enter the position starting from top left you want to enter your next character");
                        int input = int.Parse(Console.ReadLine());
                        int count = game.Move(input, out char inputChar);
                        if (count == 0)
                        {
                            goto TakeInput;
                        }
                        winnerResult = game.CheckWinner(inputChar);
                        if (winnerResult == 0)
                        {
                            goto startGame;
                        }
                        else
                        {
                            Console.WriteLine("You won the game");
                            game.ShowBoard();
                            c = 0;
                        }
                        break;
                    case 2:
                        game.ShowBoard();
                        break;
                    case 3:
                        c = 0;
                        break;
                }
            }

        }
    }
}


