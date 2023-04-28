using Day_4;

namespace Day_4_tests;

public class Tests
{
    [Test]
    public void ElfFormatter()
    {
        var elves = "1-2,2-3";
        Assert.That(Cleanup.ElfFormatter(elves),Is.EqualTo(new int[,]{{1,2},{2,3}}));
    }
}