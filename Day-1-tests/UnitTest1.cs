using AdventOfCode;

namespace Day_1_tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ConvertStringToInt()
    {
        Assert.That(Calories.Convert(new string[] {"1","2","3"}),Is.EquivalentTo(new int[] {1,2,3}));
    }
}