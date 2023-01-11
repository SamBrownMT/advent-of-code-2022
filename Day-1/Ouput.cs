using AdventOfCode;

namespace Day_1
{
    public class Output
    {
        private static readonly string Input =
            File.ReadAllText("/Users/sam.brown/Advent-of-code-2022/Day-1/input.txt");
        private static readonly string[] FormattedInput = InputConverter.Split(Input,"\n\n");
        private static readonly int MostCalories = Calories.HighestCalorie(FormattedInput);
        private static readonly List<int> TotalCalorieArray = Calories.TotalCalorieArray(FormattedInput);
        private static readonly int TopThree = Calories.SumHighestXCalories(TotalCalorieArray, 3);
        static void Main(string[] args)
        {
            Console.WriteLine(MostCalories);
            Console.WriteLine(TopThree);
        }
    }
}


