using Day_1;

namespace AdventOfCode
{
    public class Output
    {
        private static readonly string Input =
            File.ReadAllText("/Users/sam.brown/Advent-of-code-2022/Day-1/input.txt");
        private static readonly string[] FormattedInput = InputConverter.Split(Input,"\n\n");
        private static readonly int MostCalories = Calories.HighestCalorie(FormattedInput);
        
        static void Main(string[] args)
        {
            Console.WriteLine(MostCalories);
        }
    }
}


