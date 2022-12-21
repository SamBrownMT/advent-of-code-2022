// See https://aka.ms/new-console-template for more information

namespace AdventOfCode
{
    public class Calories
    {
        public static void Main(string[] args) {
            Console.WriteLine(Convert(new string[] {" "}));
        }

        public static int Highest(int[] arr)
        {
            Array.Sort(arr);
            return arr[^1];
        }

        public static int[] Convert(string[] arr)
        {
            return Array.ConvertAll(arr, IntegerParser);
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

 