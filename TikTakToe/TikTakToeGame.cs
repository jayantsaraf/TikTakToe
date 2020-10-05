using System;
using System.Collections.Generic;
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
        public void Input()
        {
            int i = 1;
            Console.WriteLine("What do you want to input(X or O)?");
            char input = char.Parse(Console.ReadLine());
            board[i] = input;
            i++;
        }
    }
}
