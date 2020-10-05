using System;

namespace TikTakToe
{
    public class TikTakToeGame
    {
        public void UC1_CreateBoard()
        {
            int[] board = new int[20];
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
