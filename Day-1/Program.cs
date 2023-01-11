// See https://aka.ms/new-console-template for more information

using AdventOfCode;

namespace Day_1
{
    public class Calories
    {
        public static int HighestCalorie(string[] arr)
        {
            var totalCalories = TotalCalorieArray(arr);
            return totalCalories.Max();
        }

        public static List<int> TotalCalorieArray(string[] arr)
        {
            var totalCalories = (
                from elf in arr select InputConverter.Split(elf, "\n") 
                into elfArray select Array.ConvertAll(elfArray, IntegerParser) 
                into elfIntArray select elfIntArray.Sum()
                ).ToList();
            return totalCalories;
        }

        public static int IntegerParser(string s)
        {
            try
            {
                return Int32.Parse(s);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
} 