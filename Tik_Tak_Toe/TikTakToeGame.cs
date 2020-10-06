using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Text;

namespace TikTakToe
{
    public class TikTakToeGame
    {
        char[] board = new char[10];
        public void CreateBoard()
        {
            int i = 0;
            for (i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
        }
        public char Input()
        {
            int i = 1;
            Console.WriteLine("What do you want to input(X or O)?");
            char input = char.Parse(Console.ReadLine());
            board[i] = input;
            i++;
            return input;
        }
        public void ShowBoard()
        {
            int c = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(board[c] + " | ");
                    c++;
                }
                Console.WriteLine("\n");
                Console.WriteLine("-------------------");  
            }
        }
        public int Move(int input, out char inputChar)
        {
            int count = 1;
            inputChar = ' ';
            if (board[input] != ' ')
            {
                Console.WriteLine("Position already occupied. Enter new position");
                count = 0;
                return count;
            }
            Console.WriteLine("What do you want to enter (X or O)?");
            inputChar = char.Parse(Console.ReadLine());
            board[input] = inputChar;
            return count;
        }
        public int Toss()
        {
            Random random = new Random();
            int toss = random.Next(0, 2);
            if(toss==0)
            {
                Console.WriteLine("Computer's turn");
                return 0;
            }
            else
            {
                Console.WriteLine("Player's turn");
                return 1;
            }
        }
        public int CheckWinner(char ch)
        {
            if ((board[1] == ch && board[2] == ch && board[3] == ch) ||
                (board[4] == ch && board[5] == ch && board[6] == ch) ||
                (board[7] == ch && board[8] == ch && board[9] == ch) ||
                (board[1] == ch && board[4] == ch && board[7] == ch) ||
                (board[2] == ch && board[5] == ch && board[8] == ch) ||
                (board[3] == ch && board[6] == ch && board[9] == ch) ||
                (board[1] == ch && board[5] == ch && board[9] == ch) ||
                (board[3] == ch && board[5] == ch && board[7] == ch)
                )
            {
                Console.WriteLine("You won the game!");
                ShowBoard();
                return 1;
            }
            return 0;
                
        }

    }
}
