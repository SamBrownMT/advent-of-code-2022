using AdventOfCode;
using Day_1;

namespace Day_1_tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CreateCalorieArray()
    {
        Assert.That(Calories.TotalCalorieArray(new string[] {"1\n2\n3\n" }),Is.EquivalentTo(new int[] {6}));
    }
    
    [Test]
    public void CreateCalorieArray2()
    {
        Assert.That(Calories.TotalCalorieArray(new string[] {"1\n2\n3\n","3\n4" }),Is.EquivalentTo(new int[] {6,7}));
    }

    [Test]
    public void Execute()
    {
        Assert.That(Calories.HighestCalorie(new string[] {"1\n2\n3","4\n5"}),Is.EqualTo(9));
    }
}