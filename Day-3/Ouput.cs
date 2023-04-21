using AdventOfCode;

namespace  Day_3;

public class Output
{
    private static readonly string Input =
            File.ReadAllText("/Users/sam.brown/Advent-of-code-2022/Day-3/input.txt");
    private static readonly string[] FormattedInput = InputConverter.Split(Input,"\n");
    private static readonly int TotalPriorities = RuckSack.TotalPriorities(FormattedInput);
    private static readonly int TotalBadgePriorities = RuckSack.TotalBadgePriorities(FormattedInput);
    static void Main()
    {
        Console.WriteLine(TotalPriorities);
        Console.WriteLine(TotalBadgePriorities);
    }
}