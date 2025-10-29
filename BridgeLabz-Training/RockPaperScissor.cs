using System;
using System.Text;

public class RockPaperScissor
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name of moves of the two players separated by a space: ");
        String inpt = Console.ReadLine();
        String[] moves = inpt.Split(' ');

        if (moves.Length == 2)
        {
            if (moves[0].ToLower() == "rock")
            {
                if (moves[1].ToLower() == "paper")
                {
                    Console.WriteLine("Player 2 wins");
                }
                else if (moves[1].ToLower() == "scissor")
                {
                    Console.WriteLine("Player 1 wins");
                }
            }
            else if (moves[0].ToLower() == "paper")
            {
                if (moves[1].ToLower() == "rock")
                {
                    Console.WriteLine("Player 1 wins");
                }
                else if (moves[1].ToLower() == "scissor")
                {
                    Console.WriteLine("Player 2 wins");
                }
            }
            else if (moves[0].ToLower() == "scissor")
            {
                if (moves[1].ToLower() == "rock")
                {
                    Console.WriteLine("Player 2 wins");
                }
                else if (moves[1].ToLower() == "paper")
                {
                    Console.WriteLine("Player 1 wins");
                }
            }

        }
        else
        {
            Console.WriteLine("Invalid number of players, this game needs exactly two players!");
        }
    }

}
