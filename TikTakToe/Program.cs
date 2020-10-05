using System;

namespace TikTakToe
{
    public class TikTakToeGame
    {
        public void UC1_CreateBoard()
        {
            int i = 1;
            int[] board = new int[10];
            for(i=1;i<=10;i++)
            {
                board[i++] = 0;
            }
            
        }
    }
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tik Tak Toe program!");
            TikTakToeGame game = new TikTakToeGame();
            game.UC1_CreateBoard();
        }
    }
}
