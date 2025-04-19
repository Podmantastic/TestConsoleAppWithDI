using Moq;
using NUnit.Framework;
using TestConsoleAppWithDI;

namespace TestConsoleAppWithDITest;

[TestFixture]
public class ConsoleAppEntryPointTest
{
    private ConsoleAppEntryPoint _entryPoint = null!;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _entryPoint = new ConsoleAppEntryPoint();
    }

    // FindLargestMissingPositiveInteger Tests
    [Test]
    public void FindLargestMissingPositiveInteger_ShouldReturn1_WhenArrayIsEmpty()
    {
        int[] input = [];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void FindLargestMissingPositiveInteger_ShouldReturn1_WhenNoPositiveNumbers()
    {
        int[] input = [-1, -2, -3];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void FindLargestMissingPositiveInteger_ShouldReturnSmallestMissingPositiveNumber()
    {
        int[] input = [1, 3, 6, 4, 1, 2];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void FindLargestMissingPositiveInteger_ShouldReturnNextPositiveNumber_WhenAllNumbersAreSequential()
    {
        int[] input = [1, 2, 3];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void FindLargestMissingPositiveInteger_ShouldReturnMinus1_WhenNumberOutOfRange()
    {
        int[] input = [1, 2, 1000001];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void FindLargestMissingPositiveInteger_ShouldIgnoreNegativeNumbersAndReturnSmallestMissingPositive()
    {
        int[] input = [-1, -3, 1, 2, 4];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(3));
    }

    // Solution Tests
    [Test]
    public void Solution_ShouldReturn0_WhenNoBinaryGapExists()
    {
        int input = 15; // Binary: 1111
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Solution_ShouldReturn2_WhenBinaryGapIs2()
    {
        int input = 9; // Binary: 1001
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Solution_ShouldReturn4_WhenBinaryGapIs4()
    {
        int input = 529; // Binary: 1000010001
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Solution_ShouldReturn1_WhenBinaryGapIs1()
    {
        int input = 20; // Binary: 10100
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Solution_ShouldReturn0_WhenInputIs0()
    {
        int input = 0; // Binary: 0
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Solution_ShouldHandleLargeNumbersCorrectly()
    {
        int input = 1041; // Binary: 10000010001
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(5));
    }
}
