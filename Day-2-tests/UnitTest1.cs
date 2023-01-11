using Day_2;

namespace Day_2_tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TotalScore()
    {
        Assert.That(RockPaperScissors.TotalScore(new string[] {"A Y","B X","C Z"}),Is.EqualTo(15));
    }
    
    [Test]
    public void TotalScore2()
    {
        Assert.That(RockPaperScissors.TotalScore(new string[] {"B Y","A Z","A X"}),Is.EqualTo(12));
    }
}