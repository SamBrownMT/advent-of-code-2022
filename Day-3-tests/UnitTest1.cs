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
}