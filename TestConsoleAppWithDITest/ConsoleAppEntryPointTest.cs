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

    [Test]
    public void Solution_ShouldReturn1_WhenArrayIsEmpty()
    {
        int[] input = [];
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Solution_ShouldReturn1_WhenNoPositiveNumbers()
    {
        int[] input = [-1, -2, -3];
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Solution_ShouldReturnSmallestMissingPositiveNumber()
    {
        int[] input = [1, 3, 6, 4, 1, 2];
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Solution_ShouldReturnNextPositiveNumber_WhenAllNumbersAreSequential()
    {
        int[] input = [1, 2, 3];
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Solution_ShouldReturnMinus1_WhenNumberOutOfRange()
    {
        int[] input = [1, 2, 1000001];
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Solution_ShouldIgnoreNegativeNumbersAndReturnSmallestMissingPositive()
    {
        int[] input = [-1, -3, 1, 2, 4];
        int result = _entryPoint.solution(input);
        Assert.That(result, Is.EqualTo(3));
    }
}
