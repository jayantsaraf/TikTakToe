using System;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Threading.Tasks.Dataflow;

namespace TikTakToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tik Tak Toe program!");
            TikTakToeGame game = new TikTakToeGame();
            game.CreateBoard();
            game.Toss();
            char inputByUser = game.Input();
            int c = 0;
            c = game.CheckWinner(inputByUser);
            game.ShowBoard();
            if (c == 0)
            {
                start:
                Console.WriteLine("Enter the position starting from top left you want to enter your next character");
                int input = int.Parse(Console.ReadLine());
                int count = game.Move(input);
                if (count == 0)
                {
                    goto start;
                }
                game.ShowBoard();
            }
            
        }
    }
}
