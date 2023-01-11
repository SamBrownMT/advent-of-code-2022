using AdventOfCode;

namespace  Day_2;

public class Output
{
    private static readonly string Input =
        File.ReadAllText("/Users/sam.brown/Advent-of-code-2022/Day-2/input.txt");
    private static readonly string[] FormattedInput = InputConverter.Split(Input,"\n");
    private static readonly int score = RockPaperScissors.TotalScore(FormattedInput);
    static void Main()
    {
        Console.WriteLine(score);
    }
}


