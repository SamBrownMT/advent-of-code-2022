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
    public void ConvertsMultiArray()
    {
        var multiArray = Calories.ConvertToMultiArray(new string[] { "1\n2\n3", "4" });
        int[][] expected =
        {
            new int[] { 1, 2, 3 } ,
            new int[] { 4 }
        };

        Assert.That(multiArray,Is.EquivalentTo(expected));
    }

    [Test]
    public void ReturnsSumsOfFood()
    {
        Assert.That(Calories.Sums(new int[,] {{1,2,3}}),Is.EqualTo(new int[] {6}));
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