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
                switch (round)
                {
                    case "A Y": score += 8; 
                        break;
                    case "B X": score += 1; 
                        break;
                    case "C Z": score += 6; 
                        break;
                    case "B Y": score += 5; 
                        break;
                    case "A Z": score += 3; 
                        break;
                    case "A X": score += 4; 
                        break;
                }
            }

            return score;
        }
    }

}