using Day_3;

namespace Day_3_tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RepeatedItem()
    {
        Assert.That(RuckSack.RepeatedItem("vJrwpWtwJgWrhcsFMMfFFhFp"),Is.EqualTo("p"));
    }
    
    [Test]
    public void RepeatedItem2()
    {
        Assert.That(RuckSack.RepeatedItem("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL"),Is.EqualTo("L"));
    }
    [Test]
    public void RepeatedItem3()
    {
        Assert.That(RuckSack.RepeatedItem("PmmdzqPrVvPwwTWBwg"),Is.EqualTo("P"));
    }
}