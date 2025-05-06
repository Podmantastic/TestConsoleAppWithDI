using Moq;
using NUnit.Framework;
using TestConsoleAppWithDI;

namespace TestConsoleAppWithDITest;

[TestFixture]
public class ConsoleAppEntryPointBinaryGapTest
{
    private ConsoleAppEntryPoint _entryPoint = null!;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _entryPoint = new ConsoleAppEntryPoint();
    }

    // FindBinaryGap Tests
    [Test]
    public void FindBinaryGap_ShouldReturn0_WhenNoBinaryGapExists()
    {
        int input = 15; // Binary: 1111
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void FindBinaryGap_ShouldReturn2_WhenBinaryGapIs2()
    {
        int input = 9; // Binary: 1001
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void FindBinaryGap_ShouldReturn4_WhenBinaryGapIs4()
    {
        int input = 529; // Binary: 1000010001
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void FindBinaryGap_ShouldReturn1_WhenBinaryGapIs1()
    {
        int input = 20; // Binary: 10100
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void FindBinaryGap_ShouldReturn0_WhenInputIs0()
    {
        int input = 0; // Binary: 0
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void FindBinaryGap_ShouldHandleLargeNumbersCorrectly()
    {
        int input = 1041; // Binary: 10000010001
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(5));
    }
}