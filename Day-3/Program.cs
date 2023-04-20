// See https://aka.ms/new-console-template for more information

namespace Day_3;

public class RuckSack
{
    public static string RepeatedItem(string bag)
    {
        var bagSize = bag.Length;
        var firstCompartment = bag.Substring(0, bagSize / 2);
        var secondCompartment = bag.Substring((bagSize / 2), bagSize / 2);
        var repeatedItem = firstCompartment.Intersect(secondCompartment);
        return string.Join(" ",repeatedItem);
    }
    public static int Priority(char letter)
    {
        var upperLetter = char.ToUpper(letter);
        int value = upperLetter;
        if (upperLetter == letter)
        {
            value -= 38;
        }
        else
        {
            value -= 64;
        }
        return value;
    }
    
}