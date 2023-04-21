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
    [Test]
    public void PriorityNumber()
    {
        const char c = 'p';
        Assert.That(RuckSack.Priority(c),Is.EqualTo(16));
    }
    [Test]
    public void PriorityNumber2()
    {
        const char c = 'L';
        Assert.That(RuckSack.Priority(c),Is.EqualTo(38));
    }
    [Test]
    public void PriorityNumber3()
    {
        const char c = 'A';
        Assert.That(RuckSack.Priority(c),Is.EqualTo(27));
    }
    [Test]
    public void PriorityNumber4()
    {
        const char c = 'a';
        Assert.That(RuckSack.Priority(c),Is.EqualTo(1));
    }
    [Test]
    public void PriorityNumber5()
    {
        const char c = 'Z';
        Assert.That(RuckSack.Priority(c),Is.EqualTo(52));
    }
    [Test]
    public void PriorityNumber6()
    {
        const char c = 'z';
        Assert.That(RuckSack.Priority(c),Is.EqualTo(26));
    }
    [Test]
    public void TotalPriorities()
    {
        var bags = new string[]
        {
            "vJrwpWtwJgWrhcsFMMfFFhFp",
            "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
            "PmmdzqPrVvPwwTWBwg",
            "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
            "ttgJtRGJQctTZtZT",
            "CrZsJsPPZsGzwwsLwLmpwMDw"
        };
        
        Assert.That(RuckSack.TotalPriorities(bags).Equals(157));
    }
    [Test]
    public void RepeatedItemList()
    {
        Assert.That(RuckSack.RepeatedItem(new string[] {"vJrwpWtwJgWrhcsFMMfFFhFp",
            "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
            "PmmdzqPrVvPwwTWBwg"}),Is.EqualTo("r"));
    }
    [Test]
    public void RepeatedItemList2()
    {
        Assert.That(RuckSack.RepeatedItem(new string[] {"wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
"ttgJtRGJQctTZtZT",
"CrZsJsPPZsGzwwsLwLmpwMDw",}),Is.EqualTo("Z"));
    }
    [Test]
    public void TotalBadgePriorities()
    {
        var bags = new string[]
        {
            "vJrwpWtwJgWrhcsFMMfFFhFp",
            "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
            "PmmdzqPrVvPwwTWBwg",
            "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
            "ttgJtRGJQctTZtZT",
            "CrZsJsPPZsGzwwsLwLmpwMDw"
        };
        
        Assert.That(RuckSack.TotalBadgePriorities(bags),Is.EqualTo(70));
    }
}