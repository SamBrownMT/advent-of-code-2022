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

    [Test]
    public void ScoreCalculator()
    {
        Assert.That(RockPaperScissors.ScoreCalculator("A X"),Is.EqualTo(4));
    }

    [Test]
    public void RoundEndCalculator()
    {
        Assert.That(RockPaperScissors.RoundEndCalculator("B Z"),Is.EqualTo(9));
    }

    [Test]
    public void TotalScoreWithRoundEnd()
    {
        Assert.That(RockPaperScissors.TotalScoreWithRoundEnd(new string[] {"A Y","B X","C Z"}),Is.EqualTo(12));
    }
}