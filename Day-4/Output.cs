using AdventOfCode;

namespace Day_4;

public class Output
{
    private static readonly string Input =
            File.ReadAllText("/Users/sam.brown/Advent-of-code-2022/Day-4/input.txt");
    private static readonly string[] FormattedInput = InputConverter.Split(Input,"\n");
    private static readonly int ContainedSum = Cleanup.FullyContainedSum(FormattedInput);
    private static readonly int OverlapSum = Cleanup.OverlapSum(FormattedInput);
    static void Main()
    {
        Console.WriteLine(ContainedSum);
        Console.WriteLine(OverlapSum);
    }
}

