using System;

namespace DES_ninor15.Task8
{
    public class Tennis
    {
        private int[] Scores = new int[2];

        public int GetPlayer1Score()
        {
            return Scores[0];
        }

        public int GetPlayer2Score()
        {
            return Scores[1];
        }

        public void ScoreGoal(int player)
        {
            Scores[player] += 1;
        }

        private String describeSub4(int score)
        {
            switch (score)
            {
                case 0:
                    return "love";

                case 1:
                    return "fifteen";

                case 2:
                    return "thirty";

                default:
                    return "forty";
            }
        }

        public String DescribeScores()
        {
            String finalStatus = "";
            if (GetPlayer1Score() == GetPlayer2Score() && GetPlayer1Score() >= 3 && GetPlayer1Score() >= 3)
            {
                return "deuce";
            }

            if (GetPlayer1Score() > GetPlayer2Score() && GetPlayer1Score() > 3)
            {
                finalStatus = "advantage";
            }
            else
            {
                finalStatus = describeSub4(GetPlayer1Score());
            }
            finalStatus += " : ";
            if (GetPlayer2Score() > GetPlayer1Score() && GetPlayer2Score() > 3)
            {
                finalStatus += "advantage";
            }
            else
            {
                finalStatus += describeSub4(GetPlayer2Score());
            }
            return finalStatus;
        }

        public int CurrentWinner()
        {
            if (GetPlayer1Score() < 4 && GetPlayer2Score() < 4)
            {
                return -1;
            }
            if (GetPlayer1Score() - GetPlayer2Score() > 1)
            {
                return 0;
            }
            if (GetPlayer1Score() - GetPlayer2Score() < -1)
            {
                return 1;
            }
            return -1;
        }
    }
}