// See https://aka.ms/new-console-template for more information

namespace AdventOfCode
{
    public class InputConverter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Split(args[0]));
        }

        public static string[] Split(string text)
        {
            return text.Split("\n");
        }
    }
}

