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
            game.Input();
            game.ShowBoard();
            Console.WriteLine("Enter the position starting from top left you want to enter your next character");
            int input = int.Parse(Console.ReadLine());
            game.Move(input);
        }
    }
}
