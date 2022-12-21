using AdventOfCode;

namespace input_converter_tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void ConnectTest() => Assert.That(new InputConverter(), Is.Not.Null);
}