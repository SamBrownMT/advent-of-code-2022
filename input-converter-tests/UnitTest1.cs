using AdventOfCode;
using System.IO;

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

    [Test]
    public void SplitTest()
    {
        string readTestFile =
            System.IO.File.ReadAllText("/Users/sam.brown/Advent-of-code-2022/input-converter-tests/test-file.txt");
        string[] readFileArray = new string[] { "I", "Am", "A", "Test" };
        Assert.That(InputConverter.Split(readTestFile,"\n"), Is.EquivalentTo(readFileArray));
    }
    
    [Test]
    public void SplitTest2()
    {
        string toBeSplit = "I Am A Test";
        string[] readFileArray = new string[] { "I", "Am", "A", "Test" };
        Assert.That(InputConverter.Split(toBeSplit," "), Is.EquivalentTo(readFileArray));
    }
}