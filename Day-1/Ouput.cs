namespace AdventOfCode
{
    public class Output
    {
        private static readonly string Input =
            File.ReadAllText("/Users/sam.brown/Advent-of-code-2022/Day-1/input.txt");
        private static readonly string[] FormattedInput = InputConverter.Split(Input,"\n");
        private static readonly int[] IntegerArray = Calories.Convert(FormattedInput);
        private static readonly int MostCalories = Calories.Highest(IntegerArray);
        
        static void Main(string[] args)
        {
            Console.WriteLine(IntegerArray[^1]);
        }
    }
}


