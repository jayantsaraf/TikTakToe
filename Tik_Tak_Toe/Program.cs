using System;
using System.Reflection.Emit;

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
            start:
            Console.WriteLine("Enter the position starting from top left you want to enter your next character");
            int input = int.Parse(Console.ReadLine());
            int count = game.Move(input);
            if(count==0)
            {
                goto start;
            }
        }
    }
}
