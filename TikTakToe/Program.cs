using System;

namespace TikTakToe
{
    public class Program
    {      
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tik Tak Toe program!");
            TikTakToeGame game = new TikTakToeGame();
            game.CreateBoard();
        }
    }
}
