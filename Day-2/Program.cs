// See https://aka.ms/new-console-template for more information

namespace Day_2 
{
    public class RockPaperScissors
    {
        public static int TotalScore(string[] arr)
        {
            var score = 0;
            foreach (var round in arr)
            {
                score += ScoreCalculator(round);
            }

            return score;
        }

        public static int ScoreCalculator(string round)
        {
            var score = new int();
            switch (round)
            {
                case "A X": score = 4; 
                    break;
                case "A Y": score = 8; 
                    break;
                case "A Z": score = 3; 
                    break;
                case "B X": score = 1; 
                    break;
                case "B Y": score = 5; 
                    break;
                case "B Z": score = 9; 
                    break;
                case "C X": score = 7; 
                    break;
                case "C Y": score = 2; 
                    break;
                case "C Z": score = 6; 
                    break;
            }

            return score;
        }
    }

}