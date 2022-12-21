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
    
    [Test]
    public void ConvertsNull()
    {
        Assert.That(Calories.Convert(new string[] {" ","notSpace","3"}),Is.EquivalentTo(new int[] {0,0,3}));
    }

    [Test]
    public void ReturnsHighestCalories()
    {
        Assert.That(Calories.Highest(new int[] {1,2,3}),Is.EqualTo(3));
    }
    [Test]
    public void ReturnsHighestCalories2()
    {
        Assert.That(Calories.Highest(new int[] {3,2,1}),Is.EqualTo(3));
    }
}