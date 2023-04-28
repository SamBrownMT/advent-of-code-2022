using Day_4;

namespace Day_4_tests;

public class Tests
{
    [Test]
    public void ElfFormatter()
    {
        var elves = "1-2,2-3";
        Assert.That(Cleanup.ElfFormatter(elves),Is.EqualTo(new int[][] { new int[] {1,2},new int[] {2,3}}));
    }
    [Test]
    public void ElfFormatter2()
    {
        var elves = "1-5,2-5";
        Assert.That(Cleanup.ElfFormatter(elves),Is.EqualTo(new int[][]{new int[] {1,5},new int[] {2,5}}));
    }
    [Test]
    public void IsFullyContained()
    {
        var elves = new int[][] {new int[] {2,3},new int[]{1,4}};
        Assert.That(Cleanup.IsFullyContained(elves),Is.EqualTo(true));
    }
    [Test]
    public void IsFullyContained2()
    {
        var elves = new int[][] {new int[] {2,5},new int[]{1,4}};
        Assert.That(Cleanup.IsFullyContained(elves),Is.EqualTo(false));
    }
    [Test]
    public void IsFullyContained3()
    {
        var elves = new int[][] {new int[] {2,5},new int[]{2,4}};
        Assert.That(Cleanup.IsFullyContained(elves),Is.EqualTo(true));
    }
    [Test]
    public void IsFullyContained4()
    {
        var elves = new int[][] {new int[] {2,5},new int[]{4,5}};
        Assert.That(Cleanup.IsFullyContained(elves),Is.EqualTo(true));
    }
}