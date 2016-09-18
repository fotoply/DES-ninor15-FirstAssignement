using System;

namespace DES_ninor15.Task8
{
    public class Task8
    {
        public void Main()
        {
            Tennis tennis = new Tennis();
            Random rnd = new Random();
            while (tennis.CurrentWinner() == -1)
            {
                tennis.ScoreGoal(rnd.Next(2));
                Console.WriteLine("Status: " + tennis.DescribeScores());
            }
            Console.WriteLine("Winner: Player" + (tennis.CurrentWinner() + 1));
        }
    }
}