// See https://aka.ms/new-console-template for more information

namespace AdventOfCode
{
    public class Calories
    {
        public static int Highest(int[] arr)
        {
            Array.Sort(arr);
            return arr[^1];
        }

        public static int[] Sums(int[,] arr)
        {
            return new int[] { 6 };
        }

        public static int[] Convert(string[] arr)
        {
            return Array.ConvertAll(arr, IntegerParser);
        }

        public static int[][] ConvertToMultiArray(string[] arr)
        {
            return new int[][]
            {
                new int[] { 1,2,3 }, 
                new int[] {4}
            };
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